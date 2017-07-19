using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CCWin;

/************************2017/7/14*****************************
 * 
 * UI.FormUser
 * 功能：实现上层用户个人主界面（员工视角）
 * 主要接口：-
 * 注意事项：对不同页面实现了不同的刷新函数
 *           涉及到listBox时，没有使用CSkin提供的UI类，因为当每个item字符串过长时，该类不能实现水平滚动
 * 
 *************************************************************/

namespace PEP
{
    public partial class FormUser : CCSkinMain
    {
        private UserInfo user;
        private ProjectInfo pro;
        private TaskInfo task;
        private PushControl push;
        private string safeFileName;

        private String generatePushFormat(MySqlDataReader dr)
        {
            return "推送时间：" + dr["timestamp"].ToString() + "  推送人：" + this.user.searchUser((int)dr["uid"]) + System.Environment.NewLine + dr["push"].ToString();
        }
        public FormUser(String uname)
        {
            this.user = new UserInfo(uname);
            this.pro = new ProjectInfo();
            this.task = new TaskInfo();
            this.push = new PushControl();
            InitializeComponent();
            this.tabControl.SelectedIndex = 0;
            this.labelWelcome.Text = "欢迎" + uname + "使用PEP系统";
            freshAttendedProjects();
            this.gridProjectOverview.RowHeadersVisible = false;
            this.gridProjectOverview.AllowUserToAddRows = false;
            this.tabPageOverview.Controls.Add(this.gridProjectOverview);
            this.gridProjectTask.RowHeadersVisible = false;
            this.gridProjectTask.AllowUserToAddRows = false;
            this.tabPageTask.Controls.Add(this.gridProjectTask);
            this.tabPageLog.Controls.Add(this.panelLog);
            this.radioButtonAllLogs.Select();
            MySqlDataReader dr = this.push.getInitialText();
            if (dr.Read())
            {
                this.textPush.Text = generatePushFormat(dr);
            }
            dr.Close();
            if (this.user.isManager())
                this.buttonManage.Enabled = true;
            else
                this.buttonManage.Enabled = false;
            this.buttonLogSubmit.Enabled = false;
            this.buttonLogClear.Enabled = false;
        }

        private void freshAttendedProjects()
        {
            this.listProject.Items.Clear();
            MySqlDataReader dr = this.user.getAttendedActiveProjects();
            while (dr.Read())
            {
                this.listProject.Items.Add(dr["pname"].ToString());
            }
            dr.Close();
        }

        private void freshProjectOverview()
        {
            this.gridProjectOverview.Rows.Clear();
            MySqlDataReader dr = this.pro.getDetail();
            if (dr.Read())
            {
                int index = 0;
                this.gridProjectOverview.Rows.Add();
                this.gridProjectOverview.Rows[index].Cells[0].Value = "项目编号";
                this.gridProjectOverview.Rows[index++].Cells[1].Value = dr["pid"].ToString();
                this.gridProjectOverview.Rows.Add();
                this.gridProjectOverview.Rows[index].Cells[0].Value = "项目名称";
                this.gridProjectOverview.Rows[index++].Cells[1].Value = dr["pname"].ToString();
                this.gridProjectOverview.Rows.Add();
                this.gridProjectOverview.Rows[index].Cells[0].Value = "建立时间";
                this.gridProjectOverview.Rows[index++].Cells[1].Value = dr["timestamp"].ToString();
                this.gridProjectOverview.Rows.Add();
                this.gridProjectOverview.Rows[index].Cells[0].Value = "负责人";
                int managerID = (int)dr["manager_id"];
                this.gridProjectOverview.Rows[index++].Cells[1].Value = this.user.searchUser(managerID); //若数据库中manager_id为空可能报错，需要生成条目时赋值形成闭环
                this.gridProjectOverview.Rows.Add();
                this.gridProjectOverview.Rows[index].Cells[0].Value = "子任务数目";
                this.gridProjectOverview.Rows[index++].Cells[1].Value = dr["task"].ToString();
                this.gridProjectOverview.Rows.Add();
                this.gridProjectOverview.Rows[index].Cells[0].Value = "完成进度";
                this.gridProjectOverview.Rows[index++].Cells[1].Value = dr["process"].ToString();
            }
            dr.Close();
        }

        private void freshProjectTask()
        {
            this.gridProjectTask.Rows.Clear();
            MySqlDataReader dr = this.pro.getTaskInfo();
            int row = 0;
            while (dr.Read())
            {
                int column = 0;
                this.gridProjectTask.Rows.Add();
                this.gridProjectTask.Rows[row].Cells[column++].Value = dr["tid"].ToString();
                this.gridProjectTask.Rows[row].Cells[column++].Value = dr["tname"].ToString();
                this.gridProjectTask.Rows[row].Cells[column++].Value = dr["task_state"].ToString();
                this.gridProjectTask.Rows[row++].Cells[column++].Value = dr["checker"].ToString();
            }
            dr.Close();
        }
        private void freshLogTask()
        {
            this.buttonLogSubmit.Enabled = false;
            this.buttonLogClear.Enabled = false;
            this.comboLogTask.Items.Clear();
            this.comboLogTask.ResetText();
            this.textLogContent.ResetText();
            this.textFileName.ResetText();
            MySqlDataReader dr = this.pro.getTaskInfo();
            while (dr.Read())
            {
                this.comboLogTask.Items.Add(dr["tname"].ToString());
            }
            dr.Close();
            this.comboLogTask.SelectedIndex = 0;
        }

        private void freshReadLog()
        {
            this.gridReadLog.Rows.Clear();
            MySqlDataReader dr = null;
            if (this.radioButtonAllLogs.Checked)
            {
                dr = this.pro.getLogInfo();
            }
            else if (this.radioButtonMyLogs.Checked)
            {
                dr = this.pro.getLogInfo(uid: this.user.getUID(), flag: true);
            }
            else if (this.radioButtonTeammateLogs.Checked)
            {
                dr = this.pro.getLogInfo(uid: this.user.getUID(), flag: false);
            }
            int rowIdx = 0;
            while (dr.Read())
            {
                this.gridReadLog.Rows.Add();
                this.gridReadLog.Rows[rowIdx].Cells["columnNumber"].Value = dr["lid"].ToString();
                int uid = Convert.ToInt32(dr["uid"]);
                this.gridReadLog.Rows[rowIdx].Cells["columnUser"].Value = this.user.searchUser(uid);
                this.gridReadLog.Rows[rowIdx].Cells["columnTime"].Value = dr["timestamp"].ToString();
                int tid = Convert.ToInt32(dr["tid"]);
                this.gridReadLog.Rows[rowIdx].Cells["columnTask"].Value = this.task.searchTask(tid);
                this.gridReadLog.Rows[rowIdx].Cells["columnChecked"].Value = dr["checked"].ToString();
                ++rowIdx;
            }
            dr.Close();
        }
        private void listProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listProject.SelectedItems.Count != 0)
            {
                String pname = this.listProject.SelectedItems[0].ToString();
                this.pro.identifyProject(pname);
                freshProjectOverview();
                freshProjectTask();
                freshLogTask();
                freshReadLog();
                this.buttonLogSubmit.Enabled = true;
                this.buttonLogClear.Enabled = true;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name == "tabPageLog")
            {
                this.textLogPerson.Text = this.user.getUname();
                this.textLogTime.Text = System.DateTime.Now.ToString("G");
            }
        }

        private void buttonLogClear_Click(object sender, EventArgs e)
        {
            this.textLogContent.SkinTxt.Clear();
        }

        private void buttonLogSubmit_Click(object sender, EventArgs e)
        {
            if (this.comboLogTask.Text == "")
            {
                MessageBox.Show("所属任务不能为空！");
                return;
            }
            if (this.textLogContent.Text == "")
            {
                MessageBox.Show("日志内容不能为空！");
                return;
            }
            string filename = null;
            if (this.textFileName.Text.Length > 0)
            {
                string sourceName = this.textFileName.Text;
                string timeString = this.textLogTime.Text.Replace('/', '_').Replace(' ', '_').Replace(':', '_');
                string targetName = this.user.getUname() + "-" + timeString + "-" + safeFileName;;
                if (FileManager.uploadLogFile(sourceName, targetName, this.listProject.SelectedItem.ToString(), this.comboLogTask.Text))
                {
                    filename = targetName;
                }
                else
                {
                    MessageBox.Show("文件上传失败！");
                    return;
                }
            }
            this.pro.submitLog(this.user.getUID(), this.textLogTime.Text, this.comboLogTask.Text, this.textLogContent.Text, filename);
            MessageBox.Show("日志已提交。");
            freshLogTask();
            freshReadLog();
        }

        private void buttonPushNext_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr = this.push.getNextPush();
            if (dr.Read())
            {
                this.textPush.Text = generatePushFormat(dr);
            }
            dr.Close();
        }

        private void buttonPushLast_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr = this.push.getLastPush();
            if (dr.Read())
            {
                this.textPush.Text = generatePushFormat(dr);
            }
            dr.Close();
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            FormPushSend formPushSend = new FormPushSend(this.user.getUID());
            formPushSend.Show();
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            FormStatistics formStatistics = new FormStatistics(this.user);
            formStatistics.Show();
        }

        private void buttonManage_Click(object sender, EventArgs e)
        {
            FormManage formManage = new FormManage(this.user);
            formManage.Show();
        }

        private void radioButtonAllLogs_CheckedChanged(object sender, EventArgs e)
        {
            freshReadLog();
        }

        private void radioButtonMyLogs_CheckedChanged(object sender, EventArgs e)
        {
            freshReadLog();
        }

        private void radioButtonTeammateLogs_CheckedChanged(object sender, EventArgs e)
        {
            freshReadLog();
        }

        private void gridReadLog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int lid = Convert.ToInt32(this.gridReadLog.SelectedRows[0].Cells["ColumnNumber"].Value);
            FormLog formLog = new FormLog(pro, lid, false);
            formLog.ShowDialog();
        }

        private void buttonPwdChange_Click(object sender, EventArgs e)
        {
            FormPwdChange formPwdChange = new FormPwdChange(this.user);
            formPwdChange.Show();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.textFileName.Text = openFileDialog.FileName;
                this.safeFileName = openFileDialog.SafeFileName;
            }
        }
    }
}
