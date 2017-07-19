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
 * UI.FormStatistics
 * 功能：实现上层用户的个人数据查看界面，对其参与项目、推送、日志情况进行了统计
 * 主要接口：-
 * 注意事项：-
 * 
 *************************************************************/

namespace PEP
{
    public partial class FormStatistics : CCSkinMain
    {
        private UserInfo user;
        public FormStatistics(UserInfo u)
        {
            this.user = u;
            InitializeComponent();
            this.labelUnameValue.Text = this.user.getUname();
            this.labelProjectValue.Text = this.user.getAttendedLiveProjectsCount();
            this.labelProjectEDValue.Text = this.user.getAttendedFinishedProjectsCount();
            this.labelLogValue.Text = this.user.getLogCount();
            this.labelLogMonthValue.Text = this.user.getLogMonthCount();
            this.labelPushValue.Text = this.user.getPushCount();
            this.labelPushMonthValue.Text = this.user.getPushMonthCount();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
