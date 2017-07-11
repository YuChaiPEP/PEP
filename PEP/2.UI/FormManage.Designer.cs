namespace PEP
{
    partial class FormManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelProject = new System.Windows.Forms.Label();
            this.listProject = new System.Windows.Forms.ListBox();
            this.panelProject = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.buttonInfoSubmit = new System.Windows.Forms.Button();
            this.textTime = new System.Windows.Forms.TextBox();
            this.textPname = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPname = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.tabPageTask = new System.Windows.Forms.TabPage();
            this.buttonTaskSubmit = new System.Windows.Forms.Button();
            this.buttonTaskLeft = new System.Windows.Forms.Button();
            this.buttonTaskRight = new System.Windows.Forms.Button();
            this.listIncludedTask = new System.Windows.Forms.ListBox();
            this.listAllTask = new System.Windows.Forms.ListBox();
            this.tabPagePerson = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPersonLeft = new System.Windows.Forms.Button();
            this.buttonPersonRight = new System.Windows.Forms.Button();
            this.listIncludedPerson = new System.Windows.Forms.ListBox();
            this.listAllPerson = new System.Windows.Forms.ListBox();
            this.tabPageChecker = new System.Windows.Forms.TabPage();
            this.buttonCheckerSubmit = new System.Windows.Forms.Button();
            this.gridChecker = new System.Windows.Forms.DataGridView();
            this.c0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.tabPageProcess = new System.Windows.Forms.TabPage();
            this.gridCheckLog = new CCWin.SkinControl.SkinDataGridView();
            this.ColumnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsChecked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelWelcome.SuspendLayout();
            this.panelProject.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.tabPageTask.SuspendLayout();
            this.tabPagePerson.SuspendLayout();
            this.tabPageChecker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChecker)).BeginInit();
            this.tabPageLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCheckLog)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWelcome
            // 
            this.panelWelcome.Controls.Add(this.labelWelcome);
            this.panelWelcome.Location = new System.Drawing.Point(180, 12);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(462, 55);
            this.panelWelcome.TabIndex = 0;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWelcome.Location = new System.Drawing.Point(139, 18);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(208, 21);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "欢迎进入管理者界面";
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProject.Location = new System.Drawing.Point(37, 7);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(74, 21);
            this.labelProject.TabIndex = 1;
            this.labelProject.Text = "管理项目";
            // 
            // listProject
            // 
            this.listProject.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listProject.FormattingEnabled = true;
            this.listProject.ItemHeight = 20;
            this.listProject.Location = new System.Drawing.Point(15, 44);
            this.listProject.Name = "listProject";
            this.listProject.Size = new System.Drawing.Size(116, 264);
            this.listProject.TabIndex = 2;
            this.listProject.SelectedIndexChanged += new System.EventHandler(this.listProject_SelectedIndexChanged);
            // 
            // panelProject
            // 
            this.panelProject.Controls.Add(this.labelProject);
            this.panelProject.Controls.Add(this.listProject);
            this.panelProject.Location = new System.Drawing.Point(29, 86);
            this.panelProject.Name = "panelProject";
            this.panelProject.Size = new System.Drawing.Size(144, 330);
            this.panelProject.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageInfo);
            this.tabControl.Controls.Add(this.tabPageTask);
            this.tabControl.Controls.Add(this.tabPagePerson);
            this.tabControl.Controls.Add(this.tabPageChecker);
            this.tabControl.Controls.Add(this.tabPageLog);
            this.tabControl.Controls.Add(this.tabPageProcess);
            this.tabControl.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl.Location = new System.Drawing.Point(239, 86);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(496, 406);
            this.tabControl.TabIndex = 4;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.panelInfo);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 30);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(488, 372);
            this.tabPageInfo.TabIndex = 0;
            this.tabPageInfo.Text = "信息修改";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.buttonInfoSubmit);
            this.panelInfo.Controls.Add(this.textTime);
            this.panelInfo.Controls.Add(this.textPname);
            this.panelInfo.Controls.Add(this.textNumber);
            this.panelInfo.Controls.Add(this.labelTime);
            this.panelInfo.Controls.Add(this.labelPname);
            this.panelInfo.Controls.Add(this.labelNumber);
            this.panelInfo.Location = new System.Drawing.Point(19, 14);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(447, 203);
            this.panelInfo.TabIndex = 0;
            // 
            // buttonInfoSubmit
            // 
            this.buttonInfoSubmit.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonInfoSubmit.Location = new System.Drawing.Point(190, 160);
            this.buttonInfoSubmit.Name = "buttonInfoSubmit";
            this.buttonInfoSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonInfoSubmit.TabIndex = 6;
            this.buttonInfoSubmit.Text = "修改";
            this.buttonInfoSubmit.UseVisualStyleBackColor = true;
            this.buttonInfoSubmit.Click += new System.EventHandler(this.buttonInfoSubmit_Click);
            // 
            // textTime
            // 
            this.textTime.Enabled = false;
            this.textTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.textTime.Location = new System.Drawing.Point(244, 104);
            this.textTime.Name = "textTime";
            this.textTime.ReadOnly = true;
            this.textTime.Size = new System.Drawing.Size(123, 23);
            this.textTime.TabIndex = 5;
            // 
            // textPname
            // 
            this.textPname.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.textPname.Location = new System.Drawing.Point(244, 66);
            this.textPname.Name = "textPname";
            this.textPname.Size = new System.Drawing.Size(123, 23);
            this.textPname.TabIndex = 4;
            // 
            // textNumber
            // 
            this.textNumber.Enabled = false;
            this.textNumber.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.textNumber.Location = new System.Drawing.Point(244, 27);
            this.textNumber.Name = "textNumber";
            this.textNumber.ReadOnly = true;
            this.textNumber.Size = new System.Drawing.Size(123, 23);
            this.textNumber.TabIndex = 3;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(112, 105);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(74, 21);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "创建时间";
            // 
            // labelPname
            // 
            this.labelPname.AutoSize = true;
            this.labelPname.Location = new System.Drawing.Point(112, 67);
            this.labelPname.Name = "labelPname";
            this.labelPname.Size = new System.Drawing.Size(58, 21);
            this.labelPname.TabIndex = 1;
            this.labelPname.Text = "项目名";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(112, 28);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(74, 21);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "项目编号";
            // 
            // tabPageTask
            // 
            this.tabPageTask.Controls.Add(this.buttonTaskSubmit);
            this.tabPageTask.Controls.Add(this.buttonTaskLeft);
            this.tabPageTask.Controls.Add(this.buttonTaskRight);
            this.tabPageTask.Controls.Add(this.listIncludedTask);
            this.tabPageTask.Controls.Add(this.listAllTask);
            this.tabPageTask.Location = new System.Drawing.Point(4, 30);
            this.tabPageTask.Name = "tabPageTask";
            this.tabPageTask.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTask.Size = new System.Drawing.Size(488, 372);
            this.tabPageTask.TabIndex = 1;
            this.tabPageTask.Text = "子任务调整";
            this.tabPageTask.UseVisualStyleBackColor = true;
            // 
            // buttonTaskSubmit
            // 
            this.buttonTaskSubmit.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTaskSubmit.Location = new System.Drawing.Point(204, 276);
            this.buttonTaskSubmit.Name = "buttonTaskSubmit";
            this.buttonTaskSubmit.Size = new System.Drawing.Size(75, 36);
            this.buttonTaskSubmit.TabIndex = 4;
            this.buttonTaskSubmit.Text = "提交";
            this.buttonTaskSubmit.UseVisualStyleBackColor = true;
            this.buttonTaskSubmit.Click += new System.EventHandler(this.buttonTaskSubmit_Click);
            // 
            // buttonTaskLeft
            // 
            this.buttonTaskLeft.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTaskLeft.Location = new System.Drawing.Point(204, 175);
            this.buttonTaskLeft.Name = "buttonTaskLeft";
            this.buttonTaskLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonTaskLeft.TabIndex = 3;
            this.buttonTaskLeft.Text = "<<";
            this.buttonTaskLeft.UseVisualStyleBackColor = true;
            this.buttonTaskLeft.Click += new System.EventHandler(this.buttonTaskLeft_Click);
            // 
            // buttonTaskRight
            // 
            this.buttonTaskRight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTaskRight.Location = new System.Drawing.Point(204, 146);
            this.buttonTaskRight.Name = "buttonTaskRight";
            this.buttonTaskRight.Size = new System.Drawing.Size(75, 23);
            this.buttonTaskRight.TabIndex = 2;
            this.buttonTaskRight.Text = ">>";
            this.buttonTaskRight.UseVisualStyleBackColor = true;
            this.buttonTaskRight.Click += new System.EventHandler(this.buttonTaskRight_Click);
            // 
            // listIncludedTask
            // 
            this.listIncludedTask.FormattingEnabled = true;
            this.listIncludedTask.ItemHeight = 21;
            this.listIncludedTask.Location = new System.Drawing.Point(297, 38);
            this.listIncludedTask.Name = "listIncludedTask";
            this.listIncludedTask.Size = new System.Drawing.Size(136, 298);
            this.listIncludedTask.TabIndex = 1;
            this.listIncludedTask.SelectedIndexChanged += new System.EventHandler(this.listIncludedTask_SelectedIndexChanged);
            // 
            // listAllTask
            // 
            this.listAllTask.FormattingEnabled = true;
            this.listAllTask.ItemHeight = 21;
            this.listAllTask.Location = new System.Drawing.Point(49, 38);
            this.listAllTask.Name = "listAllTask";
            this.listAllTask.Size = new System.Drawing.Size(136, 298);
            this.listAllTask.TabIndex = 0;
            this.listAllTask.SelectedIndexChanged += new System.EventHandler(this.listAllTask_SelectedIndexChanged);
            // 
            // tabPagePerson
            // 
            this.tabPagePerson.Controls.Add(this.button1);
            this.tabPagePerson.Controls.Add(this.buttonPersonLeft);
            this.tabPagePerson.Controls.Add(this.buttonPersonRight);
            this.tabPagePerson.Controls.Add(this.listIncludedPerson);
            this.tabPagePerson.Controls.Add(this.listAllPerson);
            this.tabPagePerson.Location = new System.Drawing.Point(4, 30);
            this.tabPagePerson.Name = "tabPagePerson";
            this.tabPagePerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePerson.Size = new System.Drawing.Size(488, 372);
            this.tabPagePerson.TabIndex = 2;
            this.tabPagePerson.Text = "人员分配";
            this.tabPagePerson.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(204, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPersonLeft
            // 
            this.buttonPersonLeft.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPersonLeft.Location = new System.Drawing.Point(204, 175);
            this.buttonPersonLeft.Name = "buttonPersonLeft";
            this.buttonPersonLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonPersonLeft.TabIndex = 3;
            this.buttonPersonLeft.Text = "<<";
            this.buttonPersonLeft.UseVisualStyleBackColor = true;
            this.buttonPersonLeft.Click += new System.EventHandler(this.buttonPersonLeft_Click);
            // 
            // buttonPersonRight
            // 
            this.buttonPersonRight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPersonRight.Location = new System.Drawing.Point(204, 146);
            this.buttonPersonRight.Name = "buttonPersonRight";
            this.buttonPersonRight.Size = new System.Drawing.Size(75, 23);
            this.buttonPersonRight.TabIndex = 2;
            this.buttonPersonRight.Text = ">>";
            this.buttonPersonRight.UseVisualStyleBackColor = true;
            this.buttonPersonRight.Click += new System.EventHandler(this.buttonPersonRight_Click);
            // 
            // listIncludedPerson
            // 
            this.listIncludedPerson.FormattingEnabled = true;
            this.listIncludedPerson.ItemHeight = 21;
            this.listIncludedPerson.Location = new System.Drawing.Point(297, 38);
            this.listIncludedPerson.Name = "listIncludedPerson";
            this.listIncludedPerson.Size = new System.Drawing.Size(136, 298);
            this.listIncludedPerson.TabIndex = 1;
            this.listIncludedPerson.SelectedIndexChanged += new System.EventHandler(this.listIncludedPerson_SelectedIndexChanged);
            // 
            // listAllPerson
            // 
            this.listAllPerson.FormattingEnabled = true;
            this.listAllPerson.ItemHeight = 21;
            this.listAllPerson.Location = new System.Drawing.Point(49, 38);
            this.listAllPerson.Name = "listAllPerson";
            this.listAllPerson.Size = new System.Drawing.Size(136, 298);
            this.listAllPerson.TabIndex = 0;
            this.listAllPerson.SelectedIndexChanged += new System.EventHandler(this.listAllPerson_SelectedIndexChanged);
            // 
            // tabPageChecker
            // 
            this.tabPageChecker.Controls.Add(this.buttonCheckerSubmit);
            this.tabPageChecker.Controls.Add(this.gridChecker);
            this.tabPageChecker.Location = new System.Drawing.Point(4, 30);
            this.tabPageChecker.Name = "tabPageChecker";
            this.tabPageChecker.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChecker.Size = new System.Drawing.Size(488, 372);
            this.tabPageChecker.TabIndex = 3;
            this.tabPageChecker.Text = "负责人委任";
            this.tabPageChecker.UseVisualStyleBackColor = true;
            // 
            // buttonCheckerSubmit
            // 
            this.buttonCheckerSubmit.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCheckerSubmit.Location = new System.Drawing.Point(209, 343);
            this.buttonCheckerSubmit.Name = "buttonCheckerSubmit";
            this.buttonCheckerSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckerSubmit.TabIndex = 1;
            this.buttonCheckerSubmit.Text = "提交";
            this.buttonCheckerSubmit.UseVisualStyleBackColor = true;
            this.buttonCheckerSubmit.Click += new System.EventHandler(this.buttonCheckerSubmit_Click);
            // 
            // gridChecker
            // 
            this.gridChecker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridChecker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridChecker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChecker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c0});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridChecker.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridChecker.Location = new System.Drawing.Point(0, 0);
            this.gridChecker.Name = "gridChecker";
            this.gridChecker.RowTemplate.Height = 23;
            this.gridChecker.Size = new System.Drawing.Size(485, 336);
            this.gridChecker.TabIndex = 0;
            // 
            // c0
            // 
            this.c0.HeaderText = "任务名称";
            this.c0.Name = "c0";
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.gridCheckLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 30);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(488, 372);
            this.tabPageLog.TabIndex = 4;
            this.tabPageLog.Text = "日志批阅";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // tabPageProcess
            // 
            this.tabPageProcess.Location = new System.Drawing.Point(4, 30);
            this.tabPageProcess.Name = "tabPageProcess";
            this.tabPageProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcess.Size = new System.Drawing.Size(488, 372);
            this.tabPageProcess.TabIndex = 5;
            this.tabPageProcess.Text = "项目进度";
            this.tabPageProcess.UseVisualStyleBackColor = true;
            // 
            // gridCheckLog
            // 
            this.gridCheckLog.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.gridCheckLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCheckLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCheckLog.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridCheckLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCheckLog.ColumnFont = null;
            this.gridCheckLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCheckLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCheckLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCheckLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUser,
            this.ColumnTime,
            this.ColumnTask,
            this.ColumnIsChecked});
            this.gridCheckLog.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCheckLog.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridCheckLog.EnableHeadersVisualStyles = false;
            this.gridCheckLog.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridCheckLog.HeadFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridCheckLog.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridCheckLog.Location = new System.Drawing.Point(-4, 0);
            this.gridCheckLog.Name = "gridCheckLog";
            this.gridCheckLog.ReadOnly = true;
            this.gridCheckLog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridCheckLog.RowHeadersVisible = false;
            this.gridCheckLog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridCheckLog.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridCheckLog.RowTemplate.Height = 23;
            this.gridCheckLog.Size = new System.Drawing.Size(492, 376);
            this.gridCheckLog.TabIndex = 0;
            this.gridCheckLog.TitleBack = null;
            this.gridCheckLog.TitleBackColorBegin = System.Drawing.Color.White;
            this.gridCheckLog.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // ColumnUser
            // 
            this.ColumnUser.FillWeight = 85.95601F;
            this.ColumnUser.HeaderText = "用户名";
            this.ColumnUser.Name = "ColumnUser";
            this.ColumnUser.ReadOnly = true;
            // 
            // ColumnTime
            // 
            this.ColumnTime.FillWeight = 142.132F;
            this.ColumnTime.HeaderText = "创建时间";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            // 
            // ColumnTask
            // 
            this.ColumnTask.FillWeight = 85.95601F;
            this.ColumnTask.HeaderText = "任务名";
            this.ColumnTask.Name = "ColumnTask";
            this.ColumnTask.ReadOnly = true;
            // 
            // ColumnIsChecked
            // 
            this.ColumnIsChecked.FillWeight = 85.95601F;
            this.ColumnIsChecked.HeaderText = "是否批阅";
            this.ColumnIsChecked.Name = "ColumnIsChecked";
            this.ColumnIsChecked.ReadOnly = true;
            // 
            // FormManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 582);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelProject);
            this.Controls.Add(this.panelWelcome);
            this.Name = "FormManage";
            this.Text = "管理者界面";
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.panelProject.ResumeLayout(false);
            this.panelProject.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.tabPageTask.ResumeLayout(false);
            this.tabPagePerson.ResumeLayout(false);
            this.tabPageChecker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridChecker)).EndInit();
            this.tabPageLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCheckLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.ListBox listProject;
        private System.Windows.Forms.Panel panelProject;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.TabPage tabPageTask;
        private System.Windows.Forms.TabPage tabPagePerson;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelPname;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textPname;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.Button buttonInfoSubmit;
        private System.Windows.Forms.Button buttonTaskRight;
        private System.Windows.Forms.ListBox listIncludedTask;
        private System.Windows.Forms.ListBox listAllTask;
        private System.Windows.Forms.Button buttonTaskLeft;
        private System.Windows.Forms.Button buttonTaskSubmit;
        private System.Windows.Forms.TabPage tabPageChecker;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.TabPage tabPageProcess;
        private System.Windows.Forms.ListBox listIncludedPerson;
        private System.Windows.Forms.ListBox listAllPerson;
        private System.Windows.Forms.Button buttonPersonLeft;
        private System.Windows.Forms.Button buttonPersonRight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridChecker;
        private System.Windows.Forms.DataGridViewTextBoxColumn c0;
        private System.Windows.Forms.Button buttonCheckerSubmit;
        private CCWin.SkinControl.SkinDataGridView gridCheckLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIsChecked;
    }
}