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
 * UI.FormPushSend
 * 功能：实现上层用户的推送界面
 * 主要接口：-
 * 注意事项：注意时间戳的格式规范
 * 
 *************************************************************/

namespace PEP
{
    public partial class FormPushSend : CCSkinMain
    {
        private int uid;
        public FormPushSend(int uid)
        {
            this.uid = uid;
            InitializeComponent();
        }

        private void buttonPushSubmit_Click(object sender, EventArgs e)
        {
            PushControl push = new PushControl();
            push.pushSubmit(textPushEdit.SkinTxt.Text, System.DateTime.Now.ToString("G"), this.uid);
            MessageBox.Show("推送成功！");
            this.Close();
        }
    }
}
