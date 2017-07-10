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
        public FormManage(UserInfo u, ProjectInfo p)
        {
            this.user = u;
            this.pro = p;
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

        private void listProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listProject.SelectedItems.Count != 0)
            {
                String pname = this.listProject.SelectedItems[0].ToString();
                this.pro.identifyProject(pname);
                freshInfo();
            }
        }

        private void buttonInfoSubmit_Click(object sender, EventArgs e)
        {
            this.pro.modifyDetail(this.textPname.Text);
            freshManagedProjects();
        }
    }
}
