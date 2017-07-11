namespace PEP
{
    partial class FormUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.listProject = new System.Windows.Forms.ListBox();
            this.labelProject = new System.Windows.Forms.Label();
            this.gridProjectOverview = new System.Windows.Forms.DataGridView();
            this.c00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageOverview = new System.Windows.Forms.TabPage();
            this.tabPageTask = new System.Windows.Forms.TabPage();
            this.gridProjectTask = new System.Windows.Forms.DataGridView();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.panelLog = new System.Windows.Forms.Panel();
            this.buttonLogClear = new System.Windows.Forms.Button();
            this.buttonLogSubmit = new System.Windows.Forms.Button();
            this.textLogContent = new System.Windows.Forms.TextBox();
            this.comboLogTask = new System.Windows.Forms.ComboBox();
            this.labelLogPerson = new System.Windows.Forms.Label();
            this.textLogTime = new System.Windows.Forms.TextBox();
            this.labelLogTime = new System.Windows.Forms.Label();
            this.textLogPerson = new System.Windows.Forms.TextBox();
            this.labelLogTask = new System.Windows.Forms.Label();
            this.labelLogContent = new System.Windows.Forms.Label();
            this.panelPush = new System.Windows.Forms.Panel();
            this.buttonPushLast = new System.Windows.Forms.Button();
            this.buttonPushNext = new System.Windows.Forms.Button();
            this.textPush = new System.Windows.Forms.TextBox();
            this.buttonPush = new System.Windows.Forms.Button();
            this.buttonManage = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.panelProject = new System.Windows.Forms.Panel();
            this.c10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjectOverview)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageOverview.SuspendLayout();
            this.tabPageTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjectTask)).BeginInit();
            this.tabPageLog.SuspendLayout();
            this.panelLog.SuspendLayout();
            this.panelPush.SuspendLayout();
            this.panelProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWelcome.Location = new System.Drawing.Point(145, 18);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(175, 21);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "欢迎使用PEP系统";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWelcome
            // 
            this.panelWelcome.Controls.Add(this.labelWelcome);
            this.panelWelcome.Location = new System.Drawing.Point(180, 12);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(446, 55);
            this.panelWelcome.TabIndex = 1;
            // 
            // listProject
            // 
            this.listProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listProject.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listProject.FormattingEnabled = true;
            this.listProject.ItemHeight = 20;
            this.listProject.Location = new System.Drawing.Point(15, 44);
            this.listProject.Name = "listProject";
            this.listProject.Size = new System.Drawing.Size(116, 264);
            this.listProject.TabIndex = 2;
            this.listProject.SelectedIndexChanged += new System.EventHandler(this.listProject_SelectedIndexChanged);
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProject.Location = new System.Drawing.Point(37, 7);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(74, 21);
            this.labelProject.TabIndex = 3;
            this.labelProject.Text = "参与项目";
            // 
            // gridProjectOverview
            // 
            this.gridProjectOverview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProjectOverview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProjectOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProjectOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c00,
            this.c01});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProjectOverview.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridProjectOverview.Location = new System.Drawing.Point(0, 0);
            this.gridProjectOverview.Name = "gridProjectOverview";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProjectOverview.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridProjectOverview.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridProjectOverview.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridProjectOverview.RowTemplate.Height = 23;
            this.gridProjectOverview.Size = new System.Drawing.Size(531, 341);
            this.gridProjectOverview.TabIndex = 4;
            // 
            // c00
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.c00.DefaultCellStyle = dataGridViewCellStyle2;
            this.c00.HeaderText = "项";
            this.c00.Name = "c00";
            // 
            // c01
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.c01.DefaultCellStyle = dataGridViewCellStyle3;
            this.c01.HeaderText = "相关信息";
            this.c01.Name = "c01";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageOverview);
            this.tabControl.Controls.Add(this.tabPageTask);
            this.tabControl.Controls.Add(this.tabPageLog);
            this.tabControl.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl.Location = new System.Drawing.Point(222, 85);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(539, 375);
            this.tabControl.TabIndex = 5;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageOverview
            // 
            this.tabPageOverview.Controls.Add(this.gridProjectOverview);
            this.tabPageOverview.Location = new System.Drawing.Point(4, 30);
            this.tabPageOverview.Name = "tabPageOverview";
            this.tabPageOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOverview.Size = new System.Drawing.Size(531, 341);
            this.tabPageOverview.TabIndex = 0;
            this.tabPageOverview.Text = "项目概要";
            this.tabPageOverview.UseVisualStyleBackColor = true;
            // 
            // tabPageTask
            // 
            this.tabPageTask.Controls.Add(this.gridProjectTask);
            this.tabPageTask.Location = new System.Drawing.Point(4, 30);
            this.tabPageTask.Name = "tabPageTask";
            this.tabPageTask.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTask.Size = new System.Drawing.Size(531, 341);
            this.tabPageTask.TabIndex = 1;
            this.tabPageTask.Text = "任务管理";
            this.tabPageTask.UseVisualStyleBackColor = true;
            // 
            // gridProjectTask
            // 
            this.gridProjectTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProjectTask.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridProjectTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProjectTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c10,
            this.c11,
            this.c12,
            this.c13});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProjectTask.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridProjectTask.Location = new System.Drawing.Point(0, 0);
            this.gridProjectTask.Name = "gridProjectTask";
            this.gridProjectTask.RowHeadersVisible = false;
            this.gridProjectTask.RowTemplate.Height = 23;
            this.gridProjectTask.Size = new System.Drawing.Size(531, 341);
            this.gridProjectTask.TabIndex = 0;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.panelLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 30);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Size = new System.Drawing.Size(531, 341);
            this.tabPageLog.TabIndex = 2;
            this.tabPageLog.Text = "日志提交";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // panelLog
            // 
            this.panelLog.Controls.Add(this.buttonLogClear);
            this.panelLog.Controls.Add(this.buttonLogSubmit);
            this.panelLog.Controls.Add(this.textLogContent);
            this.panelLog.Controls.Add(this.comboLogTask);
            this.panelLog.Controls.Add(this.labelLogPerson);
            this.panelLog.Controls.Add(this.textLogTime);
            this.panelLog.Controls.Add(this.labelLogTime);
            this.panelLog.Controls.Add(this.textLogPerson);
            this.panelLog.Controls.Add(this.labelLogTask);
            this.panelLog.Controls.Add(this.labelLogContent);
            this.panelLog.Location = new System.Drawing.Point(15, 5);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(499, 325);
            this.panelLog.TabIndex = 8;
            // 
            // buttonLogClear
            // 
            this.buttonLogClear.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLogClear.Location = new System.Drawing.Point(342, 292);
            this.buttonLogClear.Name = "buttonLogClear";
            this.buttonLogClear.Size = new System.Drawing.Size(90, 23);
            this.buttonLogClear.TabIndex = 9;
            this.buttonLogClear.Text = "清空";
            this.buttonLogClear.UseVisualStyleBackColor = true;
            this.buttonLogClear.Click += new System.EventHandler(this.buttonLogClear_Click);
            // 
            // buttonLogSubmit
            // 
            this.buttonLogSubmit.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLogSubmit.Location = new System.Drawing.Point(201, 292);
            this.buttonLogSubmit.Name = "buttonLogSubmit";
            this.buttonLogSubmit.Size = new System.Drawing.Size(90, 23);
            this.buttonLogSubmit.TabIndex = 8;
            this.buttonLogSubmit.Text = "提交";
            this.buttonLogSubmit.UseVisualStyleBackColor = true;
            this.buttonLogSubmit.Click += new System.EventHandler(this.buttonLogSubmit_Click);
            // 
            // textLogContent
            // 
            this.textLogContent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textLogContent.Location = new System.Drawing.Point(169, 130);
            this.textLogContent.Multiline = true;
            this.textLogContent.Name = "textLogContent";
            this.textLogContent.Size = new System.Drawing.Size(293, 150);
            this.textLogContent.TabIndex = 7;
            // 
            // comboLogTask
            // 
            this.comboLogTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLogTask.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboLogTask.FormattingEnabled = true;
            this.comboLogTask.Location = new System.Drawing.Point(169, 91);
            this.comboLogTask.Name = "comboLogTask";
            this.comboLogTask.Size = new System.Drawing.Size(203, 25);
            this.comboLogTask.TabIndex = 6;
            // 
            // labelLogPerson
            // 
            this.labelLogPerson.AutoSize = true;
            this.labelLogPerson.Location = new System.Drawing.Point(36, 17);
            this.labelLogPerson.Name = "labelLogPerson";
            this.labelLogPerson.Size = new System.Drawing.Size(58, 21);
            this.labelLogPerson.TabIndex = 0;
            this.labelLogPerson.Text = "提交人";
            // 
            // textLogTime
            // 
            this.textLogTime.Enabled = false;
            this.textLogTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textLogTime.Location = new System.Drawing.Point(169, 54);
            this.textLogTime.Name = "textLogTime";
            this.textLogTime.ReadOnly = true;
            this.textLogTime.Size = new System.Drawing.Size(203, 23);
            this.textLogTime.TabIndex = 5;
            // 
            // labelLogTime
            // 
            this.labelLogTime.AutoSize = true;
            this.labelLogTime.Location = new System.Drawing.Point(36, 53);
            this.labelLogTime.Name = "labelLogTime";
            this.labelLogTime.Size = new System.Drawing.Size(74, 21);
            this.labelLogTime.TabIndex = 1;
            this.labelLogTime.Text = "提交时间";
            // 
            // textLogPerson
            // 
            this.textLogPerson.Enabled = false;
            this.textLogPerson.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textLogPerson.Location = new System.Drawing.Point(169, 15);
            this.textLogPerson.Name = "textLogPerson";
            this.textLogPerson.ReadOnly = true;
            this.textLogPerson.Size = new System.Drawing.Size(203, 23);
            this.textLogPerson.TabIndex = 4;
            // 
            // labelLogTask
            // 
            this.labelLogTask.AutoSize = true;
            this.labelLogTask.Location = new System.Drawing.Point(36, 90);
            this.labelLogTask.Name = "labelLogTask";
            this.labelLogTask.Size = new System.Drawing.Size(74, 21);
            this.labelLogTask.TabIndex = 2;
            this.labelLogTask.Text = "所属任务";
            // 
            // labelLogContent
            // 
            this.labelLogContent.AutoSize = true;
            this.labelLogContent.Location = new System.Drawing.Point(36, 126);
            this.labelLogContent.Name = "labelLogContent";
            this.labelLogContent.Size = new System.Drawing.Size(74, 21);
            this.labelLogContent.TabIndex = 3;
            this.labelLogContent.Text = "日志内容";
            // 
            // panelPush
            // 
            this.panelPush.Controls.Add(this.buttonPushLast);
            this.panelPush.Controls.Add(this.buttonPushNext);
            this.panelPush.Controls.Add(this.textPush);
            this.panelPush.Location = new System.Drawing.Point(222, 473);
            this.panelPush.Name = "panelPush";
            this.panelPush.Size = new System.Drawing.Size(539, 91);
            this.panelPush.TabIndex = 6;
            // 
            // buttonPushLast
            // 
            this.buttonPushLast.Location = new System.Drawing.Point(483, 46);
            this.buttonPushLast.Name = "buttonPushLast";
            this.buttonPushLast.Size = new System.Drawing.Size(50, 42);
            this.buttonPushLast.TabIndex = 2;
            this.buttonPushLast.Text = "<<";
            this.buttonPushLast.UseVisualStyleBackColor = true;
            this.buttonPushLast.Click += new System.EventHandler(this.buttonPushLast_Click);
            // 
            // buttonPushNext
            // 
            this.buttonPushNext.Location = new System.Drawing.Point(483, 5);
            this.buttonPushNext.Name = "buttonPushNext";
            this.buttonPushNext.Size = new System.Drawing.Size(50, 42);
            this.buttonPushNext.TabIndex = 1;
            this.buttonPushNext.Text = ">>";
            this.buttonPushNext.UseVisualStyleBackColor = true;
            this.buttonPushNext.Click += new System.EventHandler(this.buttonPushNext_Click);
            // 
            // textPush
            // 
            this.textPush.BackColor = System.Drawing.SystemColors.Window;
            this.textPush.Enabled = false;
            this.textPush.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPush.Location = new System.Drawing.Point(4, 3);
            this.textPush.Multiline = true;
            this.textPush.Name = "textPush";
            this.textPush.Size = new System.Drawing.Size(477, 85);
            this.textPush.TabIndex = 0;
            // 
            // buttonPush
            // 
            this.buttonPush.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPush.Location = new System.Drawing.Point(42, 535);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(116, 25);
            this.buttonPush.TabIndex = 7;
            this.buttonPush.Text = "我要推送";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // buttonManage
            // 
            this.buttonManage.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonManage.Location = new System.Drawing.Point(42, 500);
            this.buttonManage.Name = "buttonManage";
            this.buttonManage.Size = new System.Drawing.Size(116, 25);
            this.buttonManage.TabIndex = 8;
            this.buttonManage.Text = "项目管理";
            this.buttonManage.UseVisualStyleBackColor = true;
            this.buttonManage.Click += new System.EventHandler(this.buttonManage_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStatistics.Location = new System.Drawing.Point(42, 465);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(116, 25);
            this.buttonStatistics.TabIndex = 9;
            this.buttonStatistics.Text = "个人统计";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // panelProject
            // 
            this.panelProject.Controls.Add(this.labelProject);
            this.panelProject.Controls.Add(this.listProject);
            this.panelProject.Location = new System.Drawing.Point(31, 85);
            this.panelProject.Name = "panelProject";
            this.panelProject.Size = new System.Drawing.Size(144, 330);
            this.panelProject.TabIndex = 10;
            // 
            // c10
            // 
            this.c10.HeaderText = "任务编号";
            this.c10.Name = "c10";
            // 
            // c11
            // 
            this.c11.HeaderText = "任务名称";
            this.c11.Name = "c11";
            // 
            // c12
            // 
            this.c12.HeaderText = "任务状态";
            this.c12.Name = "c12";
            // 
            // c13
            // 
            this.c13.HeaderText = "负责人";
            this.c13.Name = "c13";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 582);
            this.Controls.Add(this.buttonStatistics);
            this.Controls.Add(this.buttonManage);
            this.Controls.Add(this.buttonPush);
            this.Controls.Add(this.panelPush);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.panelProject);
            this.Name = "FormUser";
            this.Text = "PEP";
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProjectOverview)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageOverview.ResumeLayout(false);
            this.tabPageTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProjectTask)).EndInit();
            this.tabPageLog.ResumeLayout(false);
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            this.panelPush.ResumeLayout(false);
            this.panelPush.PerformLayout();
            this.panelProject.ResumeLayout(false);
            this.panelProject.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.ListBox listProject;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.DataGridView gridProjectOverview;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageOverview;
        private System.Windows.Forms.TabPage tabPageTask;
        private System.Windows.Forms.DataGridView gridProjectTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn c00;
        private System.Windows.Forms.DataGridViewTextBoxColumn c01;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.Label labelLogContent;
        private System.Windows.Forms.Label labelLogTask;
        private System.Windows.Forms.Label labelLogTime;
        private System.Windows.Forms.Label labelLogPerson;
        private System.Windows.Forms.TextBox textLogTime;
        private System.Windows.Forms.TextBox textLogPerson;
        private System.Windows.Forms.TextBox textLogContent;
        private System.Windows.Forms.ComboBox comboLogTask;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.Button buttonLogSubmit;
        private System.Windows.Forms.Button buttonLogClear;
        private System.Windows.Forms.Panel panelPush;
        private System.Windows.Forms.TextBox textPush;
        private System.Windows.Forms.Button buttonPushLast;
        private System.Windows.Forms.Button buttonPushNext;
        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.Button buttonManage;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Panel panelProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn c10;
        private System.Windows.Forms.DataGridViewTextBoxColumn c11;
        private System.Windows.Forms.DataGridViewTextBoxColumn c12;
        private System.Windows.Forms.DataGridViewTextBoxColumn c13;
    }
}