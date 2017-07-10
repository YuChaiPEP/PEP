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
    public partial class FormLogin : Form
    {
        SQLHandler sql;
        String username;
        public FormLogin()
        {
            InitializeComponent();
            this.textPwd.PasswordChar = '*';
        }

        public String getUsername()
        {
            return this.username;
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
            }
            else
                MessageBox.Show("认证失败！");
        }
    }
}
