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
        private const string SaveFileName = @"login.ini";
        private const string Key = @"PEP12345";

        public FormLogin()
        {
            InitializeComponent();
            this.textPwd.SkinTxt.PasswordChar = '*';
        }

        public String getUsername()
        {
            return this.username;
        }

        private void saveInfo()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            if (this.checkBoxSavePwd.Checked)
            {
                string user = this.textUser.SkinTxt.Text;
                string pwd = this.textPwd.SkinTxt.Text;
                if (user.Length > 0 && pwd.Length > 0)
                {
                    string content = "yes\n";
                    content += (user + "\n");
                    bool success = true;
                    string cryptoPwd = CryptoHandler.DESEncrypt(pwd, Key, ref success);
                    if (success)
                    {
                        content += cryptoPwd;
                        FileHandler.fileSave(baseDir, SaveFileName, content, true);
                    }
                }
            }
            else
            {
                string content = "no\n.\n.";
                FileHandler.fileSave(baseDir, SaveFileName, content, true);
            }
        }
        
        private void FormLogin_Load(object sender, EventArgs e)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string content = FileHandler.fileRead(baseDir, SaveFileName);
            if (content == null)
            {
                return;
            }
            string[] contentArray = content.Split('\n');
            if (contentArray.Length == 3)
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
                bool success = true;
                string pwd = CryptoHandler.DESDecrypt(contentArray[2], Key, ref success);
                if (success)
                {
                    this.textPwd.Text = pwd;
                }
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
                saveInfo();
            }
            else
                MessageBox.Show("认证失败！");
        }
    }
}