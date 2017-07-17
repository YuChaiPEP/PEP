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
 * UI.FormManage
 * 功能：实现上层用户管理者主界面（管理人员视角）
 * 主要接口：-
 * 注意事项：对不同页面实现了不同的刷新函数
 *           列表中新添item时，需要new一个新item，不能只对旧item进行拷贝
 *           批阅日志后通过dialog返回值判断是否刷新页面
 * 
 *************************************************************/

namespace PEP
{
    public partial class FormManage : CCSkinMain
    {
        private UserInfo user;
        private ProjectInfo pro;
        private TaskInfo task;
        public FormManage(UserInfo u)
        {
            this.user = u;
            this.pro = new ProjectInfo();
            this.task = new TaskInfo();
            InitializeComponent();
            this.tabControl.SelectedIndex = 0;
            this.labelWelcome.Text = "欢迎" + user.getUname() + "进入管理者界面";
            freshManagedProjects();
            this.gridChecker.RowHeadersVisible = false;
            this.gridChecker.AllowUserToAddRows = false;
            DataGridViewComboBoxColumn c01 = new DataGridViewComboBoxColumn(); //实现在grid的某个单元格中增加下拉列功能
            c01.HeaderText = "负责人";
            this.gridChecker.Columns.Add(c01);
            this.gridTaskProcess.RowHeadersVisible = false;
            this.gridTaskProcess.AllowUserToAddRows = false;
            DataGridViewComboBoxColumn c11 = new DataGridViewComboBoxColumn();
            c11.HeaderText = "任务进度";
            c11.Items.Add("未开始");
            c11.Items.Add("进行中");
            c11.Items.Add("已完成");
            this.gridTaskProcess.Columns.Add(c11);
            this.buttonInfoSubmit.Enabled = false;
            this.buttonTaskSubmit.Enabled = false;
            this.buttonPersonSubmit.Enabled = false;
            this.buttonCheckerSubmit.Enabled = false;
            this.buttonTaskProcessSubmit.Enabled = false;
            this.buttonProjectProcessSubmit.Enabled = false;
        }
        private void freshManagedProjects()
        {
            this.listProject.Items.Clear();
            MySqlDataReader dr = this.user.getManagedLiveProjects();
            while (dr.Read())
            {
                this.listProject.Items.Add(new CCWin.SkinControl.SkinListBoxItem(dr["pname"].ToString()));
            }
            dr.Close();
        }

        private void freshInfo()
        {
            this.buttonInfoSubmit.Enabled = false;
            this.textNumber.ResetText();
            this.textPname.ResetText();
            this.textTime.ResetText();
            this.radioIng.Checked = false;
            this.radioPause.Checked = false;
            MySqlDataReader dr = this.pro.getDetail();
            if (dr.Read())
            {
                this.textNumber.Text = dr["pid"].ToString();
                this.textPname.Text = dr["pname"].ToString();
                this.textTime.Text = dr["timestamp"].ToString();
                if (dr["project_state"].ToString() == "进行中")
                    this.radioIng.Checked = true;
                else
                    this.radioPause.Checked = true;

            }
            dr.Close();
        }

        private void freshTask()
        {
            this.buttonTaskSubmit.Enabled = false;
            this.listAllTask.Items.Clear();
            this.listIncludedTask.Items.Clear();
            this.buttonTaskLeft.Enabled = false;
            this.buttonTaskRight.Enabled = false;
            MySqlDataReader dr = this.pro.getTaskInfo();
            while (dr.Read())
            {
                this.listIncludedTask.Items.Add(new CCWin.SkinControl.SkinListBoxItem(dr["tname"].ToString()));
            }
            dr.Close();
            dr = this.task.getAllTask();
            while (dr.Read())
            {
                this.listAllTask.Items.Add(new CCWin.SkinControl.SkinListBoxItem(dr["tname"].ToString()));
            }
            dr.Close();
        }

        private void freshPerson()
        {
            this.buttonPersonSubmit.Enabled = false;
            this.listAllPerson.Items.Clear();
            this.listIncludedPerson.Items.Clear();
            this.buttonPersonLeft.Enabled = false;
            this.buttonPersonRight.Enabled = false; //防止误操作
            MySqlDataReader dr = this.pro.getMember();
            while (dr.Read())
            {
                this.listIncludedPerson.Items.Add(new CCWin.SkinControl.SkinListBoxItem(dr["uname"].ToString()));
            }
            dr.Close();
            dr = this.user.getAllUser();
            while (dr.Read())
            {
                this.listAllPerson.Items.Add(new CCWin.SkinControl.SkinListBoxItem(dr["uname"].ToString()));
            }
            dr.Close();
        }

        private void freshChecker()
        {
            this.buttonCheckerSubmit.Enabled = false;
            this.gridChecker.Rows.Clear();
            DataGridViewComboBoxColumn c01 = (DataGridViewComboBoxColumn)this.gridChecker.Columns[1];
            MySqlDataReader dr = this.pro.getMember();
            c01.Items.Clear();
            while (dr.Read())
            {
                c01.Items.Add(dr["uname"].ToString());
            }
            dr.Close();
            dr = this.pro.getTaskInfo();
            int index = 0;
            while (dr.Read())
            {
                this.gridChecker.Rows.Add();
                this.gridChecker.Rows[index].Cells[0].Value = dr["tname"];
                if (dr["checker"].ToString() != "" && c01.Items.Contains(dr["checker"])) //处理数据库中为null时的情况；处理项目人员被删除时无法找到合法选项的情况
                    this.gridChecker.Rows[index++].Cells[1].Value = dr["checker"];
                else
                    this.gridChecker.Rows[index++].Cells[1].Value = null;
            }
            dr.Close();
        }

        private void freshLog()
        {
            this.gridCheckLog.Rows.Clear();
            MySqlDataReader dr = this.pro.getLogInfo();
            int rowIdx = 0;
            while (dr.Read())
            {
                this.gridCheckLog.Rows.Add();
                this.gridCheckLog.Rows[rowIdx].Cells["columnNumber"].Value = dr["lid"].ToString();
                int uid = Convert.ToInt32(dr["uid"]);
                this.gridCheckLog.Rows[rowIdx].Cells["columnUser"].Value = this.user.searchUser(uid);
                this.gridCheckLog.Rows[rowIdx].Cells["columnTime"].Value = dr["timestamp"].ToString();
                int tid = Convert.ToInt32(dr["tid"]);
                this.gridCheckLog.Rows[rowIdx].Cells["columnTask"].Value = this.task.searchTask(tid);
                this.gridCheckLog.Rows[rowIdx].Cells["columnIsChecked"].Value = dr["checked"].ToString();
                ++rowIdx;
            }
            dr.Close();
        }
        private void freshProcess()
        {
            this.buttonTaskProcessSubmit.Enabled = false;
            this.buttonProjectProcessSubmit.Enabled = false;
            this.gridTaskProcess.Rows.Clear();
            this.radioFinish.Checked = false;
            this.radioAbort.Checked = false;
            MySqlDataReader dr = this.pro.getTaskInfo();
            int index = 0;
            while (dr.Read())
            {
                this.gridTaskProcess.Rows.Add();
                this.gridTaskProcess.Rows[index].Cells[0].Value = dr["tname"];
                if (dr["task_state"].ToString() != "")
                    this.gridTaskProcess.Rows[index++].Cells[1].Value = dr["task_state"];
                else
                    this.gridTaskProcess.Rows[index++].Cells[1].Value = null; //null不是空字符串
            }
            dr.Close();
        }
        private void listProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listProject.SelectedItems.Count != 0)
            {
                String pname = this.listProject.SelectedItems[0].ToString();
                this.pro.identifyProject(pname);
                freshInfo();
                freshTask();
                freshPerson();
                freshChecker();
                freshLog();
                freshProcess();
                this.buttonInfoSubmit.Enabled = true;
                this.buttonTaskSubmit.Enabled = true;
                this.buttonPersonSubmit.Enabled = true;
                this.buttonCheckerSubmit.Enabled = true;
                this.buttonTaskProcessSubmit.Enabled = true;
                this.buttonProjectProcessSubmit.Enabled = true;
            }
        }

        private void buttonInfoSubmit_Click(object sender, EventArgs e)
        {
            int stateNo = 0;
            if (this.radioIng.Checked)
                stateNo = 1;
            if (this.radioPause.Checked)
                stateNo = 2;
            this.pro.modifyDetail(this.textPname.Text, stateNo);
            freshManagedProjects();
            MessageBox.Show("项目基本信息已修改。");
        }

        private void listAllTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listAllTask.SelectedItems.Count != 0)
            {
                this.buttonTaskRight.Enabled = true;
            }
            else
            {
                this.buttonTaskRight.Enabled = false;
            }
        }

        private void listIncludedTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listIncludedTask.SelectedItems.Count != 0)
            {
                this.buttonTaskLeft.Enabled = true;
            }
            else
            {
                this.buttonTaskLeft.Enabled = false;
            }
        }

        private void buttonTaskRight_Click(object sender, EventArgs e)
        {
            this.listIncludedTask.Items.Add(new CCWin.SkinControl.SkinListBoxItem(this.listAllTask.SelectedItem.ToString())); //new新的item以防错误
        }

        private void buttonTaskLeft_Click(object sender, EventArgs e)
        {
            this.listIncludedTask.Items.Remove(this.listIncludedTask.SelectedItem as CCWin.SkinControl.SkinListBoxItem);
        }

        private void buttonTaskSubmit_Click(object sender, EventArgs e)
        {
            this.pro.modifyTask(this.listIncludedTask);
            freshChecker();
            MessageBox.Show("子任务信息已修改。");
        }

        private void buttonPersonRight_Click(object sender, EventArgs e)
        {
            this.listIncludedPerson.Items.Add(new CCWin.SkinControl.SkinListBoxItem(this.listAllPerson.SelectedItem.ToString()));
        }

        private void buttonPersonLeft_Click(object sender, EventArgs e)
        {
            this.listIncludedPerson.Items.Remove(this.listIncludedPerson.SelectedItem as CCWin.SkinControl.SkinListBoxItem);
        }

        private void buttonPersonSubmit_Click(object sender, EventArgs e)
        {
            this.pro.modifyPerson(this.listIncludedPerson);
            freshChecker();
            MessageBox.Show("人员信息已修改。");
        }

        private void listAllPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listAllPerson.SelectedItems.Count != 0)
            {
                this.buttonPersonRight.Enabled = true;
            }
            else
            {
                this.buttonPersonRight.Enabled = false;
            }
        }

        private void listIncludedPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listIncludedPerson.SelectedItems.Count != 0)
            {
                this.buttonPersonLeft.Enabled = true;
            }
            else
            {
                this.buttonPersonLeft.Enabled = false;
            }
        }

        private void buttonCheckerSubmit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.gridChecker.RowCount; i++)
            {
                if (this.gridChecker.Rows[i].Cells[1].Value == null)
                    this.pro.modifyChecker(this.gridChecker.Rows[i].Cells[0].Value.ToString(), true, "null");
                else
                    this.pro.modifyChecker(this.gridChecker.Rows[i].Cells[0].Value.ToString(), false, this.gridChecker.Rows[i].Cells[1].Value.ToString());
            }
            MessageBox.Show("负责人已设置。");
        }

        private void gridCheckLog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int lid = Convert.ToInt32(this.gridCheckLog.SelectedRows[0].Cells["ColumnNumber"].Value);    
            FormLog formLog = new FormLog(pro, lid, true);
            formLog.ShowDialog();
            if (formLog.DialogResult == DialogResult.OK) //已批阅时才进行刷新
            {
                freshLog();
            }
        }

        private void buttonTaskProcessSubmit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.gridTaskProcess.RowCount; i++)
            {
                this.pro.modifyProcess(this.gridTaskProcess.Rows[i].Cells[0].Value.ToString(), this.gridTaskProcess.Rows[i].Cells[1].Value.ToString());
            }
            MessageBox.Show("项目进度已更新。");
        }

        private void buttonCreateProject_Click(object sender, EventArgs e)
        {
            FormCreateProject formCreateProject = new FormCreateProject(user);
            formCreateProject.ShowDialog();
            if (formCreateProject.DialogResult == DialogResult.OK)
            {
                freshManagedProjects();
            }
        }

        private void buttonProjectProcessSubmit_Click(object sender, EventArgs e)
        {
            if (this.radioFinish.Checked)
            {
                MessageBox.Show("项目已完成。");
                this.pro.finishProject();
                this.freshInfo();
                this.freshTask();
                this.freshPerson();
                this.freshChecker();
                this.freshLog();
                this.freshProcess();
            }
            if (this.radioAbort.Checked)
            {
                MessageBox.Show("项目已终止。");
                this.pro.abortProject();
                this.freshInfo();
                this.freshTask();
                this.freshPerson();
                this.freshChecker();
                this.freshLog();
                this.freshProcess();
            }
            freshManagedProjects();
        }
    }
}
