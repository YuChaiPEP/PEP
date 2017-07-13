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

namespace PEP
{
    public partial class FormLogin : CCSkinMain
    {
        SQLHandler sql;
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
            if (this.checkBoxSavePwd.Checked)
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string user = this.textUser.SkinTxt.Text;
                string pwd = this.textPwd.SkinTxt.Text;
                if (user.Length > 0 && pwd.Length > 0)
                {
                    string content = "yes\n";
                    if (this.checkBoxAutoLogin.Checked)
                    {
                        content += "yes\n";
                    }
                    else
                    {
                        content += "no\n";
                    }
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
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string content = FileHandler.fileRead(baseDir, SaveFileName);
            string[] contentArray = content.Split('\n');
            if (contentArray.Length == 4)
            { 
                this.textUser.Text = contentArray[2];
                bool success = true;
                string pwd = CryptoHandler.DESDecrypt(contentArray[3], Key, ref success);
                if (success)
                {
                    this.textPwd.Text = pwd;
                }
                if (contentArray[0] == "yes")
                {
                    this.checkBoxSavePwd.Checked = true;
                }
                if (contentArray[1] == "yes")
                {
                    this.checkBoxAutoLogin.Checked = true;
                    //this.buttonLogin.PerformClick();
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