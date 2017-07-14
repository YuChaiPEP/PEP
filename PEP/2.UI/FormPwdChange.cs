using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

/************************2017/7/14*****************************
 * 
 * UI.FormPwdChange
 * 功能：实现上层用户的密码修改界面（可扩充为个人信息修改界面）
 * 主要接口：-
 * 注意事项：-
 * 
 *************************************************************/

namespace PEP
{
    public partial class FormPwdChange : CCSkinMain
    {
        UserInfo user;
        public FormPwdChange(UserInfo u)
        {
            this.user = u;
            InitializeComponent();
            this.textUname.Text = this.user.getUname();
            this.textOldPwd.SkinTxt.PasswordChar = '*';
            this.textNewPwd.SkinTxt.PasswordChar = '*';
            this.textRepeatedPwd.SkinTxt.PasswordChar = '*';
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
           int res =  this.user.modifyPwd(this.textOldPwd.Text, this.textNewPwd.Text, this.textRepeatedPwd.Text);
            bool change = false;
           switch (res) //对不同异常返回值进行警告
            {
                case 1:
                    MessageBox.Show("新密码不能为空！");
                    break;
                case 2:
                    MessageBox.Show("重复密码不一致！");
                    break;
                case 3:
                    MessageBox.Show("旧密码错误！");
                    break;
                default:
                    MessageBox.Show("修改成功。");
                    change = true;
                    break;
            }
            if (change)
                this.Close();
        }
    }
}
