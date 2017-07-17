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
            this.labelWelcome.Text = "欢迎" + user.getUname() + "进入管理者界面";
            freshManagedProjects();
            this.gridChecker.RowHeadersVisible = false;
            this.gridChecker.AllowUserToAddRows = false;
            DataGridViewComboBoxColumn c01 = new DataGridViewComboBoxColumn(); //实现在grid的某个单元格中增加下拉列功能
            c01.HeaderText = "负责人";
            this.gridChecker.Columns.Add(c01);
            this.gridProcess.RowHeadersVisible = false;
            this.gridProcess.AllowUserToAddRows = false;
            DataGridViewComboBoxColumn c11 = new DataGridViewComboBoxColumn();
            c11.HeaderText = "任务进度";
            c11.Items.Add("未开始");
            c11.Items.Add("进行中");
            c11.Items.Add("已完成");
            this.gridProcess.Columns.Add(c11);      
        }
        private void freshManagedProjects()
        {
            this.listProject.Items.Clear();
            MySqlDataReader dr = this.user.getManagedProjects();
            while (dr.Read())
            {
                this.listProject.Items.Add(new CCWin.SkinControl.SkinListBoxItem(dr["pname"].ToString()));
            }
            dr.Close();
        }

        private void freshInfo()
        {
            MySqlDataReader dr = this.pro.getDetail();
            if (dr.Read())
            {
                this.textNumber.Text = dr["pid"].ToString();
                this.textPname.Text = dr["pname"].ToString();
                this.textTime.Text = dr["timestamp"].ToString();
            }
            dr.Close();
        }

        private void freshTask()
        {
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
            this.gridProcess.Rows.Clear();
            MySqlDataReader dr = this.pro.getTaskInfo();
            int index = 0;
            while (dr.Read())
            {
                this.gridProcess.Rows.Add();
                this.gridProcess.Rows[index].Cells[0].Value = dr["tname"];
                if (dr["task_state"].ToString() != "")
                    this.gridProcess.Rows[index++].Cells[1].Value = dr["task_state"];
                else
                    this.gridProcess.Rows[index++].Cells[1].Value = null; //null不是空字符串
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
            }
        }

        private void buttonInfoSubmit_Click(object sender, EventArgs e)
        {
            this.pro.modifyDetail(this.textPname.Text);
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

        private void buttonProcessSubmit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.gridProcess.RowCount; i++)
            {
                this.pro.modifyProcess(this.gridProcess.Rows[i].Cells[0].Value.ToString(), this.gridProcess.Rows[i].Cells[1].Value.ToString());
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
    }
}
