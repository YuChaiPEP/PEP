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
 * UI.FormCreateProject
 * 功能：实现上层用户管理者的新建项目界面
 * 主要接口：-
 * 注意事项：对不同页面实现了不同的刷新函数
 *           当有时间需要写入数据库的timestamp表列时，需要注意时间字符串的格式，采用"G"参数进行规范
 * 
 *************************************************************/

namespace PEP
{
    public partial class FormCreateProject : CCSkinMain
    {
        private UserInfo user;
        private ProjectInfo pro;
        private TaskInfo task;
        public FormCreateProject(UserInfo u)
        {
            InitializeComponent();
            user = u;
            pro = new ProjectInfo();
            task = new TaskInfo();
        }

        private void FormCreateProject_Load(object sender, EventArgs e)
        {
            tabCreateProject.SizeMode = TabSizeMode.Fixed;
            tabCreateProject.ItemSize = new Size(0, 1);
            this.buttonLast.Visible = false;
            this.Text = "新建项目-" + this.tabCreateProject.SelectedTab.Text;
            freshInfo();
            freshTask();
            freshPerson();
        }

        private void freshInfo()
        {
            int newPid = pro.getMaxPid() + 1;
            this.textNumber.Text = newPid.ToString();
            this.textTime.Text = System.DateTime.Now.ToString("G"); //规范时间格式
        }

        private void freshTask()
        {
            this.listAllTask.Items.Clear();
            this.listIncludedTask.Items.Clear();
            this.buttonTaskLeft.Enabled = false;
            this.buttonTaskRight.Enabled = false;
            MySqlDataReader dr = task.getAllTask();
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
            this.buttonPersonRight.Enabled = false;
            MySqlDataReader dr = user.getAllUser();
            while (dr.Read())
            {
                this.listAllPerson.Items.Add(new CCWin.SkinControl.SkinListBoxItem(dr["uname"].ToString()));
            }
            dr.Close();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            --this.tabCreateProject.SelectedIndex;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            switch(this.tabCreateProject.SelectedIndex) //逐步检查各阶段的信息填写
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
                    if (this.listIncludedTask.Items.Count == 0)
                    {
                        MessageBox.Show("子任务数不能为零！");
                        break;
                    }
                    ++this.tabCreateProject.SelectedIndex;
                    break;
                case 2:
                    if (this.listIncludedPerson.Items.Count == 0)
                    {
                        MessageBox.Show("参与人员数不能为零！");
                        break;
                    }
                    pro.createProject(Convert.ToInt32(this.textNumber.Text), this.textPname.Text, this.textTime.Text, user.getUID(), this.listIncludedTask, this.listIncludedPerson);
                    this.DialogResult = DialogResult.OK;
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
                this.buttonLast.Visible= false;
            } else
            {
                this.buttonLast.Visible = true;
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

        private void buttonTaskLeft_Click(object sender, EventArgs e)
        {
            this.listIncludedTask.Items.Remove((CCWin.SkinControl.SkinListBoxItem)this.listIncludedTask.SelectedItem);
        }

        private void buttonTaskRight_Click(object sender, EventArgs e)
        {
            this.listIncludedTask.Items.Add(new CCWin.SkinControl.SkinListBoxItem(this.listAllTask.SelectedItem.ToString())); //增加item时new出新的对象
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

        private void buttonPersonRight_Click(object sender, EventArgs e)
        {
            this.listIncludedPerson.Items.Add((CCWin.SkinControl.SkinListBoxItem)this.listAllPerson.SelectedItem);
        }

        private void buttonPersonLeft_Click(object sender, EventArgs e)
        {
            this.listIncludedPerson.Items.Remove(new CCWin.SkinControl.SkinListBoxItem(this.listIncludedPerson.SelectedItem.ToString()));
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
    }
}
