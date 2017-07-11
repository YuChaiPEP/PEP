using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CCWin;

namespace PEP
{
    public partial class FormLog : CCSkinMain
    {
        private ProjectInfo pro;
        private int lid;
        public FormLog(ProjectInfo p, int id)
        {
            InitializeComponent();
            pro = p;
            lid = id;
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            MySqlDataReader dr = this.pro.getLogInfo(lid);
            string logText = "";
            if (dr.Read())
            {
                logText = dr["content"].ToString();
            }
            dr.Close();
            this.textBoxLog.Text = logText;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            this.pro.modifyLogChecked(lid, "已批阅");
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
