using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEP
{
    public partial class FormCreateProject : Form
    {
        public FormCreateProject()
        {
            InitializeComponent();
        }

        private void FormCreateProject_Load(object sender, EventArgs e)
        {
            tabCreateProject.SizeMode = TabSizeMode.Fixed;
            tabCreateProject.ItemSize = new Size(0, 1);
            this.buttonLast.Enabled = false;
            this.Text = "新建项目-" + this.tabCreateProject.SelectedTab.Text;
            freshInfo();
        }

        private void freshInfo()
        {
            ProjectInfo pro = new ProjectInfo();
            int newPid = pro.getMaxPid() + 1;
            this.textNumber.Text = newPid.ToString();
            this.textTime.Text = System.DateTime.Now.ToString("G");
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            --this.tabCreateProject.SelectedIndex;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            switch(this.tabCreateProject.SelectedIndex)
            {
                case 0:
                    if (this.textPname.Text.Length == 0)
                    {
                        MessageBox.Show("项目名不能为空！");
                        break;
                    }
                    ++this.tabCreateProject.SelectedIndex;
                    break;
                case 1:
                    ++this.tabCreateProject.SelectedIndex;
                    break;
                case 2:
                    ++this.tabCreateProject.SelectedIndex;
                    break;
                case 3:
                    this.Close();
                    break;
                default:
                    break;

            }
        }

        private void tabCreateProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabCreateProject.SelectedIndex == 0)
            {
                this.buttonLast.Enabled = false;
            } else
            {
                this.buttonLast.Enabled = true;
            }

            if (this.tabCreateProject.SelectedIndex == this.tabCreateProject.TabCount - 1)
            {
                this.buttonNext.Text = "创建";
            } else
            {
                this.buttonNext.Text = "下一步";
            }

            this.Text = "新建项目-" + this.tabCreateProject.SelectedTab.Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
