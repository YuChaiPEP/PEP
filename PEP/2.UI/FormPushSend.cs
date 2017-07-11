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
    public partial class FormPushSend : Form
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
            push.pushSubmit(textPushEdit.Text, System.DateTime.Now.ToString("G"), this.uid);
            MessageBox.Show("推送成功！");
            this.Close();
        }
    }
}
