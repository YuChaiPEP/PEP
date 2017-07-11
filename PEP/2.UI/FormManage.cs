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

namespace PEP
{
    public partial class FormManage : Form
    {
        private UserInfo user;
        private ProjectInfo pro;
        private TaskInfo task;
        public FormManage(UserInfo u, ProjectInfo p)
        {
            this.user = u;
            this.pro = p;
            this.task = new TaskInfo();
            InitializeComponent();
            this.labelWelcome.Text = "欢迎" + user.getUname() + "进入管理者界面";
            freshManagedProjects();
        }
        private void freshManagedProjects()
        {
            this.listProject.Items.Clear();
            MySqlDataReader dr = this.user.getManagedProjects();
            while (dr.Read())
            {
                this.listProject.Items.Add(dr["pname"].ToString());
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
            this.buttonLeft.Enabled = false;
            this.buttonRight.Enabled = false;
            MySqlDataReader dr = this.pro.getTaskInfo();
            while (dr.Read())
            {
                this.listIncludedTask.Items.Add(dr["tname"].ToString());
            }
            dr.Close();
            dr = this.task.getAllTask();
            while (dr.Read())
            {
                this.listAllTask.Items.Add(dr["tname"].ToString());
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
                this.buttonRight.Enabled = true;
            }
        }

        private void listIncludedTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listIncludedTask.SelectedItems.Count != 0)
            {
                this.buttonLeft.Enabled = true;
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            this.listIncludedTask.Items.Add(this.listAllTask.SelectedItem);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            this.listIncludedTask.Items.Remove(this.listIncludedTask.SelectedItem);
        }

        private void buttonTaskSubmit_Click(object sender, EventArgs e)
        {
            this.pro.modifyTask(this.listIncludedTask);
            MessageBox.Show("子任务信息已修改。");
        }
    }
}
