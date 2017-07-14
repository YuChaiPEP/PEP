using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CCWin;

/************************2017/7/14*****************************
 * 
 * UI.FormLogin
 * 功能：实现上层用户登录界面
 * 主要接口：-
 * 注意事项：
 * 
 *************************************************************/

namespace PEP
{
    public partial class FormLogin : CCSkinMain
    {
        String username;

        public FormLogin()
        {
            InitializeComponent();
            this.textPwd.SkinTxt.PasswordChar = '*';
        }

        public String getUsername()
        {
            return this.username;
        }
        
        private void FormLogin_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            string[] contentArray = login.readInfo(AppDomain.CurrentDomain.BaseDirectory);
            if (contentArray != null)
            {
                if (contentArray[0] == "yes")
                {
                    this.checkBoxSavePwd.Checked = true;
                }
                else
                {
                    return;
                }
                this.textUser.Text = contentArray[1];
                this.textPwd.Text = contentArray[2];
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String user = this.textUser.Text;
            String pwd = this.textPwd.Text;
            Login login = new Login();
            if (login.identifyAuthentication(user, pwd))
            {
                MessageBox.Show("认证通过！");
                this.DialogResult = DialogResult.OK;
                this.username = user;
                login.saveInfo(AppDomain.CurrentDomain.BaseDirectory, this.checkBoxSavePwd.Checked, this.textUser.SkinTxt.Text, this.textPwd.SkinTxt.Text);
            }
            else
                MessageBox.Show("认证失败！");
        }
    }
}