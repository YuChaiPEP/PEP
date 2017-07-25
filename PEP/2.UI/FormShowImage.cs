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
        Image image = null;

        public FormShowImage(CCWin.SkinControl.SkinDataGridView grid)
        {
            InitializeComponent();
            this.grid = grid;
        }

        private void drawBox(Graphics graph, string taskName, string taskState, int width, int height, int x, int y)
        {
            SolidBrush brush = null;
            switch (taskState)
            {
                case "未开始":
                    brush = new SolidBrush(Color.Gray);
                    break;
                case "进行中":
                    brush = new SolidBrush(Color.Red);
                    break;
                case "已完成":
                    brush = new SolidBrush(Color.Green);
                    break;
                default:
                    brush = new SolidBrush(Color.Black);
                    break;
            }
            Rectangle rect = new Rectangle(x, y, width, height);
            graph.FillRectangle(brush, rect);
            graph.DrawString(taskName, new Font("楷体", 10), new SolidBrush(Color.Black), x, y + height / 3);
        }

        private void FormShowImage_Load(object sender, EventArgs e)
        {
            int taskCnt = grid.Rows.Count;
            Dictionary<DateTime, List<int>> dic = new Dictionary<DateTime, List<int>>();
            for (int i = 0; i < taskCnt; ++i)
            {
                if (grid.Rows[i].Cells[3].Value == null)
                {
                    MessageBox.Show("日期不能为空！");
                    return;
                }
                string dateStr = grid.Rows[i].Cells[3].Value.ToString();
                try
                {
                    DateTime date = DateTime.ParseExact(dateStr, "yyyy年M月d日", System.Globalization.CultureInfo.CurrentCulture);
                    if (!dic.ContainsKey(date))
                    {
                        dic[date] = new List<int>();
                    }
                    dic[date].Add(i);
                }
                catch
                {
                    MessageBox.Show("日期格式有误！");
                    return;
                }
            }
            var dicSort = from objDic in dic orderby objDic.Key select objDic;
            const int charWidth = 15;
            const int boxHeight = 30;
            const int interval = 10;
            const int startX = 100;
            const int startY = 10;
            int totalHeight = (boxHeight + interval) * dic.Count;
            int totalWidth = 0;
            foreach (KeyValuePair<DateTime, List<int>> kvp in dic)
            {
                int _width = startX;
                foreach (int index in kvp.Value)
                {
                    string taskName = grid.Rows[index].Cells[1].Value.ToString();
                    int width = taskName.Length * charWidth;
                    _width += (width + interval);
                }
                if (_width > totalWidth)
                {
                    totalWidth = _width;
                }
            }

            image = new Bitmap(totalWidth, totalHeight);
            Graphics graph = Graphics.FromImage(image);
            int x = startX;
            int y = startY;
            foreach (KeyValuePair<DateTime, List<int>> kvp in dicSort)
            {
                graph.DrawString(kvp.Key.ToLongDateString(), new Font("宋体", 10), new SolidBrush(Color.Black), 2, y + boxHeight / 3);
                x = startX;
                foreach (int index in kvp.Value)
                {
                    string taskName = grid.Rows[index].Cells[1].Value.ToString();
                    string taskState = grid.Rows[index].Cells[2].Value.ToString();
                    int width = taskName.Length * charWidth;
                    drawBox(graph, taskName, taskState, width, boxHeight, x, y);
                    x = x + width + interval;
                }
                y = y + boxHeight + interval;
            }
            this.pictureBox.Image = image;
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            if (this.image == null)
            {
                MessageBox.Show("图片不存在！");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "任务流程图.bmp";
            saveFileDialog.Filter = "bmp文件|*.bmp";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string saveName = saveFileDialog.FileName;
                this.image.Save(saveName);
            }
        }
    }
}
