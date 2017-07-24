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
    public partial class FormShowImage : CCSkinMain
    {
        CCWin.SkinControl.SkinDataGridView grid;

        public FormShowImage(CCWin.SkinControl.SkinDataGridView grid)
        {
            InitializeComponent();
            this.grid = grid;
        }

        private void FormShowImage_Load(object sender, EventArgs e)
        {
            Image img = new Bitmap(500, 500);
            Graphics graph = Graphics.FromImage(img);
            int taskCnt = grid.Rows.Count;
            int x = 10;
            for (int i = 0; i < taskCnt; ++i)
            {
                string taskName = grid.Rows[i].Cells[1].Value.ToString();
                int width = taskName.Length * 20;
                SolidBrush brush = new SolidBrush(Color.Red);
                Rectangle rect = new Rectangle(x, 10, width, 30);
                x = x + width + 20;
                //graph.FillRectangle(brush, rect);
                graph.DrawString(taskName, new Font("微软雅黑", 10), new SolidBrush(Color.Black), x, 10);
            }
            this.pictureBox.Image = img;
        }
    }
}
