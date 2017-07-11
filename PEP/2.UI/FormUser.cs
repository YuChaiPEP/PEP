using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace PEP
{
    public partial class FormUser : Form
    {
        private UserInfo user;
        private ProjectInfo pro;
        private PushControl push;

        private String generatePushFormat(MySqlDataReader dr)
        {
            return "推送时间：" + dr["timestamp"].ToString() + "  推送人：" + this.user.searchUser((int)dr["uid"]) + System.Environment.NewLine + dr["push"].ToString();
        }
        public FormUser(String uname)
        {
            this.user = new UserInfo(uname);
            this.pro = new ProjectInfo();
            this.push = new PushControl();
            InitializeComponent();
            this.labelWelcome.Text = "欢迎" + uname + "使用PEP系统";
            freshAttendedProjects();
            this.gridProjectOverview.RowHeadersVisible = false;
            this.gridProjectOverview.AllowUserToAddRows = false;
            this.tabPageOverview.Controls.Add(this.gridProjectOverview);
            this.gridProjectTask.RowHeadersVisible = false;
            this.gridProjectTask.AllowUserToAddRows = false;
            this.tabPageTask.Controls.Add(this.gridProjectTask);
            this.tabPageLog.Controls.Add(this.panelLog);
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
        }

        private void freshAttendedProjects()
        {
            this.listProject.Items.Clear();
            MySqlDataReader dr = this.user.getAttendedProjects();
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
                this.gridProjectOverview.Rows[index++].Cells[1].Value = this.user.searchUser(managerID);
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
                this.gridProjectTask.Rows[row].Cells[column++].Value = dr["checker"].ToString();
                this.gridProjectTask.Rows[row++].Cells[column++].Value = dr["grade"].ToString();
            }
            dr.Close();
        }
        private void freshLogTask()
        {
            this.comboLogTask.Items.Clear();
            this.comboLogTask.ResetText();
            MySqlDataReader dr = this.pro.getTaskInfo();
            while (dr.Read())
            {
                this.comboLogTask.Items.Add(dr["tname"].ToString());
            }
            dr.Close();
            this.comboLogTask.SelectedIndex = 0;
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
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name == "tabPageLog")
            {
                this.textLogPerson.Text = this.user.getUname();
                this.textLogTime.Text = System.DateTime.Now.ToString();
            }
        }

        private void buttonLogClear_Click(object sender, EventArgs e)
        {
            this.textLogContent.Clear();
        }

        private void buttonLogSubmit_Click(object sender, EventArgs e)
        {
            this.pro.submitLog(this.user.getUID(), this.textLogTime.Text, this.comboLogTask.Text, this.textLogContent.Text);
            MessageBox.Show("日志已提交。");
            freshLogTask();
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
            FormManage formManage = new FormManage(this.user, this.pro);
            formManage.Show();
        }
    }
}
