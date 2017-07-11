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
    public partial class FormLog : CCSkinMain
    {
        private string logText;
        public FormLog(string text)
        {
            InitializeComponent();
            logText = text;
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            this.textBoxLog.Text = logText;
        }
    }
}
