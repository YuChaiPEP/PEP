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

/************************2017/7/14*****************************
 * 
 * UI.FormLog
 * 功能：实现上层用户的日志查看和批阅界面
 * 主要接口：-
 * 注意事项：对不同权限的用户（员工、管理人员）进行了不同的功能赋予
 * 
 *************************************************************/

namespace PEP
{
    public partial class FormLog : CCSkinMain
    {
        private ProjectInfo pro;
        private int lid;
        private bool check;
        private string filename;
        public FormLog(ProjectInfo p, int id, bool isCheck)
        {
            InitializeComponent();
            pro = p;
            lid = id;
            check = isCheck;
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            MySqlDataReader dr = this.pro.getLogInfo(lid);
            string logText = "";
            if (dr.Read())
            {
                logText = dr["content"].ToString();
                this.filename = dr["filename"].ToString();
            }
            dr.Close();
            this.textBoxLog.Text = logText;
            this.textBoxLog.SkinTxt.SelectionStart = 0;
            this.textBoxLog.SkinTxt.SelectionLength = 0;
            if (check) //权限分流
            {
                this.buttonConfirm.Visible = false;
            }
            else
            {
                this.buttonCheck.Visible = false;
                this.buttonCancel.Visible = false;
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            this.pro.modifyLogChecked(lid, "已批阅");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if (this.filename.Length == 0)
            {
                MessageBox.Show("文件不存在！");
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = this.filename;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string targetName = saveFileDialog.FileName;
                    if (FileManager.downloadLogFile(this.filename, targetName))
                    {
                        MessageBox.Show("文件下载成功！");
                    }
                    else
                    {
                        MessageBox.Show("文件下载失败！");
                    }
                }
            }
        }
    }
}
