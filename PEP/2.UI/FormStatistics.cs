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
            this.labelProjectValue.Text = this.user.getAttendedProjectsCount();
            this.labelLogValue.Text = this.user.getLogCount();
            this.labelPushValue.Text = this.user.getPushCount();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
