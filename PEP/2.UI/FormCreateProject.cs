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
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            --this.tabCreateProject.SelectedIndex;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (this.buttonNext.Text == "下一步")
            {
                ++this.tabCreateProject.SelectedIndex;
            } else
            {
                this.Close();
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
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
