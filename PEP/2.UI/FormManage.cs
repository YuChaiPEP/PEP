﻿using System;
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
using System.Text.RegularExpressions;

/************************2017/7/19*****************************
 * 
 * UI.FormManage
 * 功能：实现上层用户管理者主界面（管理人员视角）
 * 主要接口：-
 * 注意事项：对不同页面实现了不同的刷新函数
 *           批阅日志后通过dialog返回值判断是否刷新页面
 *           涉及到listBox时，没有使用CSkin提供的UI类，因为当每个item字符串过长时，该类不能实现水平滚动
 *           手动添加了日历输入日期，若该列发生变化，需要修改CalendarRow和CalendarColumn
 * 
 *************************************************************/

namespace PEP
{
    public partial class FormManage : CCSkinMain
    {
        private UserInfo user;
        private ProjectInfo pro;
        private TaskInfo task;
        private string taskFilename;
        private DateTimePicker dTimePicker = new DateTimePicker();
        Rectangle _Rectangle;
        private int CalendarRow = -1; //标题行不需要使用日历
        private int CalendarColumn = 2; //第二列需要使用日历
        private String defaultDDL = "1970年1月23日"; //截止日期的默认值

        public FormManage(UserInfo u)
        {
            this.user = u;
            this.pro = new ProjectInfo();
            this.task = new TaskInfo();
            InitializeComponent();
            this.tabControl.SelectedIndex = 0;
            this.labelWelcome.Text = "欢迎" + user.getUname() + "进入管理者界面";
            freshManagedProjects();
            this.gridChecker.RowHeadersVisible = false;
            this.gridChecker.AllowUserToAddRows = false;
            DataGridViewComboBoxColumn c01 = new DataGridViewComboBoxColumn(); //实现在grid的某个单元格中增加下拉列功能
            c01.HeaderText = "负责人";
            this.gridChecker.Columns.Add(c01);
            this.gridTaskProcess.RowHeadersVisible = false;
            this.gridTaskProcess.AllowUserToAddRows = false;
            DataGridViewComboBoxColumn c11 = new DataGridViewComboBoxColumn();
            c11.HeaderText = "任务进度";
            c11.Items.Add("未开始");
            c11.Items.Add("进行中");
            c11.Items.Add("已完成");
            this.gridTaskProcess.Columns.Add(c11);
            this.groupBoxTask.Controls.Add(this.dTimePicker);
            this.dTimePicker.BringToFront();
            DataGridViewTextBoxColumn c12 = new DataGridViewTextBoxColumn();
            c12.HeaderText = "截止日期";
            this.gridTaskProcess.Columns.Add(c12);
            this.dTimePicker.Visible = false;
            this.gridTaskProcess.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTaskProcess_CellClick);
            this.gridTaskProcess.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.gridTaskProcess_ColumnWidthChanged);
            this.gridTaskProcess.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gridTaskProcess_Scroll);
            this.gridTaskProcess.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.gridTaskProcess_CellStateChanged);
            this.buttonInfoSubmit.Enabled = false;
            this.buttonTaskSubmit.Enabled = false;
            this.buttonPersonSubmit.Enabled = false;
            this.buttonCheckerSubmit.Enabled = false;
            this.buttonTaskProcessSubmit.Enabled = false;
            this.buttonProjectProcessSubmit.Enabled = false;
            this.buttonChooseFile.Enabled = false;
            this.buttonUpload.Enabled = false;
            this.buttonTaskLeft.Enabled = false;
            this.buttonTaskRight.Enabled = false;
            this.buttonPersonLeft.Enabled = false;
            this.buttonPersonRight.Enabled = false;
            this.buttonTaskProcessReset.Enabled = false;
        }
        private void freshManagedProjects()
        {
            this.listProject.Items.Clear();
            MySqlDataReader dr = this.user.getManagedLiveProjects();
            while (dr.Read())
            {
                this.listProject.Items.Add(dr["pname"].ToString());
            }
            dr.Close();
        }

        private void freshInfo()
        {
            this.buttonInfoSubmit.Enabled = false;
            this.textNumber.ResetText();
            this.textPname.ResetText();
            this.textTime.ResetText();
            this.radioIng.Checked = false;
            this.radioPause.Checked = false;
            MySqlDataReader dr = this.pro.getDetail();
            if (dr.Read())
            {
                this.textNumber.Text = dr["pid"].ToString();
                this.textPname.Text = dr["pname"].ToString();
                this.textTime.Text = dr["timestamp"].ToString();
                if (dr["project_state"].ToString() == "进行中")
                    this.radioIng.Checked = true;
                else
                    this.radioPause.Checked = true;

            }
            dr.Close();
            if (this.listProject.SelectedItems.Count != 0)
                this.buttonInfoSubmit.Enabled = true;
        }

        private void freshTask()
        {
            this.buttonTaskSubmit.Enabled = false;
            this.listAllTask.Items.Clear();
            this.listIncludedTask.Items.Clear();
            this.buttonTaskLeft.Enabled = false;
            this.buttonTaskRight.Enabled = false;

            this.comboTask.Items.Clear();
            this.comboTaskFile.Items.Clear();
            this.buttonChooseFile.Enabled = false;
            this.buttonUpload.Enabled = false;

            MySqlDataReader dr = this.pro.getTaskInfo();
            while (dr.Read())
            {
                this.listIncludedTask.Items.Add(dr["tname"].ToString());
                this.comboTask.Items.Add(dr["tname"].ToString());
            }
            dr.Close();
            if (this.comboTask.Items.Count > 0)
            {
                this.comboTask.SelectedIndex = 0;
            }
            dr = this.task.getAllTask();
            while (dr.Read())
            {
                this.listAllTask.Items.Add(dr["tname"].ToString());
            }
            dr.Close();
            if (this.listProject.SelectedItems.Count != 0)
            {
                this.buttonTaskSubmit.Enabled = true;
            }
        }

        private void freshPerson()
        {
            this.buttonPersonSubmit.Enabled = false;
            this.listAllPerson.Items.Clear();
            this.listIncludedPerson.Items.Clear();
            this.buttonPersonLeft.Enabled = false;
            this.buttonPersonRight.Enabled = false; //防止误操作
            MySqlDataReader dr = this.pro.getMember();
            while (dr.Read())
            {
                this.listIncludedPerson.Items.Add(dr["uname"].ToString());
            }
            dr.Close();
            dr = this.user.getAllUser();
            while (dr.Read())
            {
                this.listAllPerson.Items.Add(dr["uname"].ToString());
            }
            dr.Close();
            if (this.listProject.SelectedItems.Count != 0)
                this.buttonPersonSubmit.Enabled = true;
        }

        private void freshChecker()
        {
            this.buttonCheckerSubmit.Enabled = false;
            this.gridChecker.Rows.Clear();
            DataGridViewComboBoxColumn c01 = (DataGridViewComboBoxColumn)this.gridChecker.Columns[1];
            MySqlDataReader dr = this.pro.getMember();
            c01.Items.Clear();
            while (dr.Read())
            {
                c01.Items.Add(dr["uname"].ToString());
            }
            dr.Close();
            dr = this.pro.getTaskInfo();
            int index = 0;
            while (dr.Read())
            {
                this.gridChecker.Rows.Add();
                this.gridChecker.Rows[index].Cells[0].Value = dr["tname"];
                if (dr["checker"].ToString() != "" && c01.Items.Contains(dr["checker"])) //处理数据库中为null时的情况；处理项目人员被删除时无法找到合法选项的情况
                    this.gridChecker.Rows[index++].Cells[1].Value = dr["checker"];
                else
                    this.gridChecker.Rows[index++].Cells[1].Value = null;
            }
            dr.Close();
            if (this.listProject.SelectedItems.Count != 0)
                this.buttonCheckerSubmit.Enabled = true;
        }

        private void freshFile()
        {
            this.buttonUpload.Enabled = false;
            this.buttonChooseFile.Enabled = false;
            this.comboTaskFile.Items.Clear();
            if (this.comboTask.SelectedItem != null)
            {
                MySqlDataReader dr = this.pro.getFileInfo(this.comboTask.SelectedItem.ToString());
                while (dr.Read())
                {
                    this.comboTaskFile.Items.Add(dr["filename"].ToString());
                }
                dr.Close();
                if (this.comboTaskFile.Items.Count > 0)
                {
                    this.comboTaskFile.SelectedIndex = 0;
                }
            }
            if (this.listProject.SelectedItems.Count != 0)
            {
                this.buttonUpload.Enabled = true;
                this.buttonChooseFile.Enabled = true;
            }
        }

        private void freshLog()
        {
            this.gridCheckLog.Rows.Clear();
            MySqlDataReader dr = this.pro.getLogInfo();
            int rowIdx = 0;
            while (dr.Read())
            {
                this.gridCheckLog.Rows.Add();
                this.gridCheckLog.Rows[rowIdx].Cells["columnNumber"].Value = dr["lid"].ToString();
                int uid = Convert.ToInt32(dr["uid"]);
                this.gridCheckLog.Rows[rowIdx].Cells["columnUser"].Value = this.user.searchUser(uid);
                this.gridCheckLog.Rows[rowIdx].Cells["columnTime"].Value = dr["timestamp"].ToString();
                int tid = Convert.ToInt32(dr["tid"]);
                this.gridCheckLog.Rows[rowIdx].Cells["columnTask"].Value = this.task.searchTask(tid);
                this.gridCheckLog.Rows[rowIdx].Cells["columnIsChecked"].Value = dr["checked"].ToString();
                ++rowIdx;
            }
            dr.Close();
        }
        private void freshProcess()
        {
            this.buttonTaskProcessSubmit.Enabled = false;
            this.buttonProjectProcessSubmit.Enabled = false;
            this.buttonTaskProcessReset.Enabled = false;
            this.gridTaskProcess.Rows.Clear();
            this.radioFinish.Checked = false;
            this.radioAbort.Checked = false;
            MySqlDataReader dr = this.pro.getTaskInfo();
            int index = 0;
            while (dr.Read())
            {
                this.gridTaskProcess.Rows.Add();
                this.gridTaskProcess.Rows[index].Cells[0].Value = dr["tname"];
                if (dr["task_state"].ToString() != "")
                    this.gridTaskProcess.Rows[index].Cells[1].Value = dr["task_state"];
                else
                    this.gridTaskProcess.Rows[index].Cells[1].Value = null; //null不是空字符串
                this.gridTaskProcess.Rows[index].Cells[2].ReadOnly = true;
                String ddl = "";
                DateTime d = Convert.ToDateTime(dr["deadline"]);
                ddl = "" + d.Year + "年" + d.Month + "月" + d.Day + "日";
                if (ddl == this.defaultDDL)
                    ddl = "-"; //处理默认值
                this.gridTaskProcess.Rows[index++].Cells[2].Value = ddl;
            }
            dr.Close();
            if (this.listProject.SelectedItems.Count != 0)
            {
                this.buttonTaskProcessSubmit.Enabled = true;
                this.buttonProjectProcessSubmit.Enabled = true;
                this.buttonTaskProcessReset.Enabled = true;
            }
        }
        private void listProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listProject.SelectedItems.Count != 0)
            {
                String pname = this.listProject.SelectedItems[0].ToString();
                this.pro.identifyProject(pname);
                freshInfo();
                freshTask();
                freshPerson();
                freshChecker();
                freshFile();
                freshLog();
                freshProcess();
            }
        }

        private void buttonInfoSubmit_Click(object sender, EventArgs e)
        {
            int stateNo = 0;
            if (this.radioIng.Checked)
                stateNo = 1;
            if (this.radioPause.Checked)
                stateNo = 2;
            this.pro.modifyDetail(this.textPname.Text, stateNo);
            if (this.listProject.SelectedItem.ToString() != this.textPname.Text)
            {
                FileManager.renameProjectDirectory(this.listProject.SelectedItem.ToString(), this.textPname.Text);
            }
            freshManagedProjects();
            MessageBox.Show("项目基本信息已修改。");
        }

        private void listAllTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listAllTask.SelectedItems.Count != 0)
            {
                this.buttonTaskRight.Enabled = true;
            }
            else
            {
                this.buttonTaskRight.Enabled = false;
            }
        }

        private void listIncludedTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listIncludedTask.SelectedItems.Count != 0)
            {
                this.buttonTaskLeft.Enabled = true;
            }
            else
            {
                this.buttonTaskLeft.Enabled = false;
            }
        }

        private void buttonTaskRight_Click(object sender, EventArgs e)
        {
            this.listIncludedTask.Items.Add(this.listAllTask.SelectedItem.ToString());
        }

        private void buttonTaskLeft_Click(object sender, EventArgs e)
        {
            this.listIncludedTask.Items.RemoveAt(this.listIncludedTask.SelectedIndex);
        }

        private void buttonTaskSubmit_Click(object sender, EventArgs e)
        {
            List<string> includedTask = this.listIncludedTask.Items.Cast<string>().ToList();
            this.pro.modifyTask(includedTask);
            freshChecker();
            freshProcess();
            MessageBox.Show("子任务信息已修改。");
        }

        private void buttonPersonRight_Click(object sender, EventArgs e)
        {
            if (this.listIncludedPerson.Items.Contains(this.listAllPerson.SelectedItem.ToString()))
                MessageBox.Show("该人员已经在项目组中！");
            else
                this.listIncludedPerson.Items.Add(this.listAllPerson.SelectedItem.ToString());
        }

        private void buttonPersonLeft_Click(object sender, EventArgs e)
        {
            this.listIncludedPerson.Items.RemoveAt(this.listIncludedPerson.SelectedIndex);
        }

        private void buttonPersonSubmit_Click(object sender, EventArgs e)
        {
            List<string> includedPerson = this.listIncludedPerson.Items.Cast<string>().ToList();
            this.pro.modifyPerson(includedPerson);
            freshChecker();
            MessageBox.Show("人员信息已修改。");
        }

        private void listAllPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listAllPerson.SelectedItems.Count != 0)
            {
                this.buttonPersonRight.Enabled = true;
            }
            else
            {
                this.buttonPersonRight.Enabled = false;
            }
        }

        private void listIncludedPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listIncludedPerson.SelectedItems.Count != 0)
            {
                this.buttonPersonLeft.Enabled = true;
            }
            else
            {
                this.buttonPersonLeft.Enabled = false;
            }
        }

        private void buttonCheckerSubmit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.gridChecker.RowCount; i++)
            {
                if (this.gridChecker.Rows[i].Cells[1].Value == null)
                    this.pro.modifyChecker(this.gridChecker.Rows[i].Cells[0].Value.ToString(), true, "null");
                else
                    this.pro.modifyChecker(this.gridChecker.Rows[i].Cells[0].Value.ToString(), false, this.gridChecker.Rows[i].Cells[1].Value.ToString());
            }
            MessageBox.Show("负责人已设置。");
        }

        private void gridCheckLog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int lid = Convert.ToInt32(this.gridCheckLog.SelectedRows[0].Cells["ColumnNumber"].Value);    
            FormLog formLog = new FormLog(pro, lid, true);
            formLog.ShowDialog();
            if (formLog.DialogResult == DialogResult.OK) //已批阅时才进行刷新
            {
                freshLog();
            }
        }

        private void buttonTaskProcessSubmit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.gridTaskProcess.RowCount; i++)
            {
                String ddl = "";
                if (this.gridTaskProcess.Rows[i].Cells[2].Value == "-")
                    ddl = this.defaultDDL;
                else
                    ddl = (String)this.gridTaskProcess.Rows[i].Cells[2].Value;
                this.pro.modifyProcess(this.gridTaskProcess.Rows[i].Cells[0].Value.ToString(), this.gridTaskProcess.Rows[i].Cells[1].Value.ToString(), ddl);
            }
            MessageBox.Show("项目进度已更新。");
        }

        private void buttonCreateProject_Click(object sender, EventArgs e)
        {
            FormCreateProject formCreateProject = new FormCreateProject(user);
            formCreateProject.ShowDialog();
            if (formCreateProject.DialogResult == DialogResult.OK)
            {
                this.pro.identifyProject("");
                this.freshManagedProjects();
                this.freshInfo();
                this.freshTask();
                this.freshPerson();
                this.freshChecker();
                this.freshLog();
                this.freshProcess();
            }
        }

        private void buttonProjectProcessSubmit_Click(object sender, EventArgs e)
        {
            if (this.radioFinish.Checked)
            {
                MessageBox.Show("项目已完成。");
                this.pro.finishProject();
                this.freshManagedProjects();
                this.freshInfo();
                this.freshTask();
                this.freshPerson();
                this.freshChecker();
                this.freshLog();
                this.freshProcess();
            }
            if (this.radioAbort.Checked)
            {
                MessageBox.Show("项目已终止。");
                this.pro.abortProject();
                FileManager.deleteProjectFiles(this.listProject.SelectedItem.ToString());
                this.freshManagedProjects();
                this.freshInfo();
                this.freshTask();
                this.freshPerson();
                this.freshChecker();
                this.freshLog();
                this.freshProcess();
            }
        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.textFilename.Text = openFileDialog.FileName;
                this.taskFilename = openFileDialog.SafeFileName;
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            if (this.comboTask.SelectedItem == null)
            {
                MessageBox.Show("请选择任务名！");
                return;
            }
            if (this.textFilename.Text.Length == 0)
            {
                MessageBox.Show("文件名不能为空！");
                return;
            }
            if (FileManager.uploadTaskFile(this.textFilename.Text, this.taskFilename, this.listProject.SelectedItem.ToString(), this.comboTask.SelectedItem.ToString()))
            {
                this.pro.submitFile(this.comboTask.SelectedItem.ToString(), this.taskFilename);
                this.freshFile();
                MessageBox.Show("文件上传成功！");
            }
            else
            {
                MessageBox.Show("文件上传失败！");
            }
        }

        private void comboTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.freshFile();
        }
        private bool isDate(String s)
        {
            if (s == null)
                return false;
            return Regex.IsMatch(s, "^[0-9]+年[0-9]+月[0-9]+日$");
        }
        private void gridTaskProcess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.CalendarColumn && e.RowIndex != this.CalendarRow) // 需要使用日历功能的列，并且不是标题
            {
                String content = (String)this.gridTaskProcess.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (isDate(content))
                    this.dTimePicker.Value = Convert.ToDateTime(content);
                else
                    this.dTimePicker.Value = System.DateTime.Now;
                _Rectangle = this.gridTaskProcess.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                this.dTimePicker.Size = new Size(_Rectangle.Width, _Rectangle.Height);
                this.dTimePicker.Location = new Point(_Rectangle.X + 5, _Rectangle.Y);
                this.dTimePicker.Visible = true;
            }
            else
            {
                this.dTimePicker.Visible = false;
            }

        }
        private void gridTaskProcess_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            this.dTimePicker.Visible = false;
        }
        private void gridTaskProcess_Scroll(object sender, ScrollEventArgs e)
        {
            this.dTimePicker.Visible = false;
        }
        private void gridTaskProcess_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e) //gridView的单元格失去焦点时进行赋值
        {
            if (this.gridTaskProcess.CurrentCell != null && this.gridTaskProcess.CurrentCell.ColumnIndex == this.CalendarColumn && this.gridTaskProcess.CurrentCell.RowIndex != this.CalendarRow)
                this.gridTaskProcess.CurrentCell.Value = dTimePicker.Text.ToString();
        }

        private void buttonTaskProcessReset_Click(object sender, EventArgs e)
        {
            freshProcess();
        }
    }
}
