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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelProject = new System.Windows.Forms.Label();
            this.listProject = new CCWin.SkinControl.SkinListBox();
            this.panelProject = new System.Windows.Forms.Panel();
            this.tabControl = new CCWin.SkinControl.SkinTabControl();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.buttonInfoSubmit = new CCWin.SkinControl.SkinButton();
            this.textTime = new CCWin.SkinControl.SkinTextBox();
            this.textPname = new CCWin.SkinControl.SkinTextBox();
            this.textNumber = new CCWin.SkinControl.SkinTextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPname = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.tabPageTask = new System.Windows.Forms.TabPage();
            this.buttonTaskSubmit = new CCWin.SkinControl.SkinButton();
            this.buttonTaskLeft = new CCWin.SkinControl.SkinButton();
            this.buttonTaskRight = new CCWin.SkinControl.SkinButton();
            this.listIncludedTask = new CCWin.SkinControl.SkinListBox();
            this.listAllTask = new CCWin.SkinControl.SkinListBox();
            this.tabPagePerson = new System.Windows.Forms.TabPage();
            this.buttonPersonSubmit = new CCWin.SkinControl.SkinButton();
            this.buttonPersonLeft = new CCWin.SkinControl.SkinButton();
            this.buttonPersonRight = new CCWin.SkinControl.SkinButton();
            this.listIncludedPerson = new CCWin.SkinControl.SkinListBox();
            this.listAllPerson = new CCWin.SkinControl.SkinListBox();
            this.tabPageChecker = new System.Windows.Forms.TabPage();
            this.buttonCheckerSubmit = new CCWin.SkinControl.SkinButton();
            this.gridChecker = new CCWin.SkinControl.SkinDataGridView();
            this.c00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.gridCheckLog = new CCWin.SkinControl.SkinDataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsChecked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageProcess = new System.Windows.Forms.TabPage();
            this.buttonProcessSubmit = new CCWin.SkinControl.SkinButton();
            this.gridProcess = new CCWin.SkinControl.SkinDataGridView();
            this.c10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCreateProject = new CCWin.SkinControl.SkinButton();
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
            this.tabPageProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.Transparent;
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
            this.listProject.Back = null;
            this.listProject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listProject.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listProject.FormattingEnabled = true;
            this.listProject.HorizontalScrollbar = true;
            this.listProject.ItemHeight = 20;
            this.listProject.Location = new System.Drawing.Point(15, 44);
            this.listProject.Name = "listProject";
            this.listProject.Size = new System.Drawing.Size(116, 264);
            this.listProject.TabIndex = 2;
            this.listProject.SelectedIndexChanged += new System.EventHandler(this.listProject_SelectedIndexChanged);
            // 
            // panelProject
            // 
            this.panelProject.BackColor = System.Drawing.Color.Transparent;
            this.panelProject.Controls.Add(this.labelProject);
            this.panelProject.Controls.Add(this.listProject);
            this.panelProject.Location = new System.Drawing.Point(29, 86);
            this.panelProject.Name = "panelProject";
            this.panelProject.Size = new System.Drawing.Size(144, 330);
            this.panelProject.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tabControl.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tabControl.Controls.Add(this.tabPageInfo);
            this.tabControl.Controls.Add(this.tabPageTask);
            this.tabControl.Controls.Add(this.tabPagePerson);
            this.tabControl.Controls.Add(this.tabPageChecker);
            this.tabControl.Controls.Add(this.tabPageLog);
            this.tabControl.Controls.Add(this.tabPageProcess);
            this.tabControl.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl.HeadBack = null;
            this.tabControl.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tabControl.ItemSize = new System.Drawing.Size(82, 36);
            this.tabControl.Location = new System.Drawing.Point(239, 86);
            this.tabControl.Name = "tabControl";
            this.tabControl.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tabControl.PageArrowDown")));
            this.tabControl.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tabControl.PageArrowHover")));
            this.tabControl.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tabControl.PageCloseHover")));
            this.tabControl.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tabControl.PageCloseNormal")));
            this.tabControl.PageDown = ((System.Drawing.Image)(resources.GetObject("tabControl.PageDown")));
            this.tabControl.PageHover = ((System.Drawing.Image)(resources.GetObject("tabControl.PageHover")));
            this.tabControl.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tabControl.PageNorml = null;
            this.tabControl.SelectedIndex = 5;
            this.tabControl.Size = new System.Drawing.Size(496, 406);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 4;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.panelInfo);
            this.tabPageInfo.Location = new System.Drawing.Point(0, 36);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(496, 370);
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
            this.buttonInfoSubmit.BackColor = System.Drawing.Color.Transparent;
            this.buttonInfoSubmit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonInfoSubmit.DownBack = null;
            this.buttonInfoSubmit.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonInfoSubmit.Location = new System.Drawing.Point(190, 160);
            this.buttonInfoSubmit.MouseBack = null;
            this.buttonInfoSubmit.Name = "buttonInfoSubmit";
            this.buttonInfoSubmit.NormlBack = null;
            this.buttonInfoSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonInfoSubmit.TabIndex = 6;
            this.buttonInfoSubmit.Text = "修改";
            this.buttonInfoSubmit.UseVisualStyleBackColor = true;
            this.buttonInfoSubmit.Click += new System.EventHandler(this.buttonInfoSubmit_Click);
            // 
            // textTime
            // 
            this.textTime.BackColor = System.Drawing.Color.Transparent;
            this.textTime.DownBack = null;
            this.textTime.Enabled = false;
            this.textTime.Icon = null;
            this.textTime.IconIsButton = false;
            this.textTime.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textTime.IsPasswordChat = '\0';
            this.textTime.IsSystemPasswordChar = false;
            this.textTime.Lines = new string[0];
            this.textTime.Location = new System.Drawing.Point(244, 104);
            this.textTime.Margin = new System.Windows.Forms.Padding(0);
            this.textTime.MaxLength = 32767;
            this.textTime.MinimumSize = new System.Drawing.Size(28, 28);
            this.textTime.MouseBack = null;
            this.textTime.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textTime.Multiline = false;
            this.textTime.Name = "textTime";
            this.textTime.NormlBack = null;
            this.textTime.Padding = new System.Windows.Forms.Padding(5);
            this.textTime.ReadOnly = true;
            this.textTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textTime.Size = new System.Drawing.Size(123, 28);
            // 
            // 
            // 
            this.textTime.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.textTime.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.textTime.SkinTxt.Name = "BaseText";
            this.textTime.SkinTxt.ReadOnly = true;
            this.textTime.SkinTxt.TabIndex = 0;
            this.textTime.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textTime.SkinTxt.WaterText = "";
            this.textTime.TabIndex = 5;
            this.textTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textTime.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textTime.WaterText = "";
            this.textTime.WordWrap = true;
            // 
            // textPname
            // 
            this.textPname.BackColor = System.Drawing.Color.Transparent;
            this.textPname.DownBack = null;
            this.textPname.Icon = null;
            this.textPname.IconIsButton = false;
            this.textPname.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textPname.IsPasswordChat = '\0';
            this.textPname.IsSystemPasswordChar = false;
            this.textPname.Lines = new string[0];
            this.textPname.Location = new System.Drawing.Point(244, 66);
            this.textPname.Margin = new System.Windows.Forms.Padding(0);
            this.textPname.MaxLength = 32767;
            this.textPname.MinimumSize = new System.Drawing.Size(28, 28);
            this.textPname.MouseBack = null;
            this.textPname.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textPname.Multiline = false;
            this.textPname.Name = "textPname";
            this.textPname.NormlBack = null;
            this.textPname.Padding = new System.Windows.Forms.Padding(5);
            this.textPname.ReadOnly = false;
            this.textPname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textPname.Size = new System.Drawing.Size(123, 28);
            // 
            // 
            // 
            this.textPname.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.textPname.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.textPname.SkinTxt.Name = "BaseText";
            this.textPname.SkinTxt.TabIndex = 0;
            this.textPname.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textPname.SkinTxt.WaterText = "";
            this.textPname.TabIndex = 4;
            this.textPname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textPname.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textPname.WaterText = "";
            this.textPname.WordWrap = true;
            // 
            // textNumber
            // 
            this.textNumber.BackColor = System.Drawing.Color.Transparent;
            this.textNumber.DownBack = null;
            this.textNumber.Enabled = false;
            this.textNumber.Icon = null;
            this.textNumber.IconIsButton = false;
            this.textNumber.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textNumber.IsPasswordChat = '\0';
            this.textNumber.IsSystemPasswordChar = false;
            this.textNumber.Lines = new string[0];
            this.textNumber.Location = new System.Drawing.Point(244, 27);
            this.textNumber.Margin = new System.Windows.Forms.Padding(0);
            this.textNumber.MaxLength = 32767;
            this.textNumber.MinimumSize = new System.Drawing.Size(28, 28);
            this.textNumber.MouseBack = null;
            this.textNumber.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textNumber.Multiline = false;
            this.textNumber.Name = "textNumber";
            this.textNumber.NormlBack = null;
            this.textNumber.Padding = new System.Windows.Forms.Padding(5);
            this.textNumber.ReadOnly = true;
            this.textNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textNumber.Size = new System.Drawing.Size(123, 28);
            // 
            // 
            // 
            this.textNumber.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.textNumber.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.textNumber.SkinTxt.Name = "BaseText";
            this.textNumber.SkinTxt.ReadOnly = true;
            this.textNumber.SkinTxt.TabIndex = 0;
            this.textNumber.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textNumber.SkinTxt.WaterText = "";
            this.textNumber.TabIndex = 3;
            this.textNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textNumber.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textNumber.WaterText = "";
            this.textNumber.WordWrap = true;
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
            this.tabPageTask.Location = new System.Drawing.Point(0, 36);
            this.tabPageTask.Name = "tabPageTask";
            this.tabPageTask.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTask.Size = new System.Drawing.Size(496, 370);
            this.tabPageTask.TabIndex = 1;
            this.tabPageTask.Text = "子任务调整";
            this.tabPageTask.UseVisualStyleBackColor = true;
            // 
            // buttonTaskSubmit
            // 
            this.buttonTaskSubmit.BackColor = System.Drawing.Color.Transparent;
            this.buttonTaskSubmit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonTaskSubmit.DownBack = null;
            this.buttonTaskSubmit.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTaskSubmit.Location = new System.Drawing.Point(204, 276);
            this.buttonTaskSubmit.MouseBack = null;
            this.buttonTaskSubmit.Name = "buttonTaskSubmit";
            this.buttonTaskSubmit.NormlBack = null;
            this.buttonTaskSubmit.Size = new System.Drawing.Size(75, 36);
            this.buttonTaskSubmit.TabIndex = 4;
            this.buttonTaskSubmit.Text = "提交";
            this.buttonTaskSubmit.UseVisualStyleBackColor = true;
            this.buttonTaskSubmit.Click += new System.EventHandler(this.buttonTaskSubmit_Click);
            // 
            // buttonTaskLeft
            // 
            this.buttonTaskLeft.BackColor = System.Drawing.Color.Transparent;
            this.buttonTaskLeft.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonTaskLeft.DownBack = null;
            this.buttonTaskLeft.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTaskLeft.Location = new System.Drawing.Point(204, 175);
            this.buttonTaskLeft.MouseBack = null;
            this.buttonTaskLeft.Name = "buttonTaskLeft";
            this.buttonTaskLeft.NormlBack = null;
            this.buttonTaskLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonTaskLeft.TabIndex = 3;
            this.buttonTaskLeft.Text = "<<";
            this.buttonTaskLeft.UseVisualStyleBackColor = true;
            this.buttonTaskLeft.Click += new System.EventHandler(this.buttonTaskLeft_Click);
            // 
            // buttonTaskRight
            // 
            this.buttonTaskRight.BackColor = System.Drawing.Color.Transparent;
            this.buttonTaskRight.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonTaskRight.DownBack = null;
            this.buttonTaskRight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTaskRight.Location = new System.Drawing.Point(204, 146);
            this.buttonTaskRight.MouseBack = null;
            this.buttonTaskRight.Name = "buttonTaskRight";
            this.buttonTaskRight.NormlBack = null;
            this.buttonTaskRight.Size = new System.Drawing.Size(75, 23);
            this.buttonTaskRight.TabIndex = 2;
            this.buttonTaskRight.Text = ">>";
            this.buttonTaskRight.UseVisualStyleBackColor = true;
            this.buttonTaskRight.Click += new System.EventHandler(this.buttonTaskRight_Click);
            // 
            // listIncludedTask
            // 
            this.listIncludedTask.Back = null;
            this.listIncludedTask.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
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
            this.listAllTask.Back = null;
            this.listAllTask.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
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
            this.tabPagePerson.Controls.Add(this.buttonPersonSubmit);
            this.tabPagePerson.Controls.Add(this.buttonPersonLeft);
            this.tabPagePerson.Controls.Add(this.buttonPersonRight);
            this.tabPagePerson.Controls.Add(this.listIncludedPerson);
            this.tabPagePerson.Controls.Add(this.listAllPerson);
            this.tabPagePerson.Location = new System.Drawing.Point(0, 36);
            this.tabPagePerson.Name = "tabPagePerson";
            this.tabPagePerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePerson.Size = new System.Drawing.Size(496, 370);
            this.tabPagePerson.TabIndex = 2;
            this.tabPagePerson.Text = "人员分配";
            this.tabPagePerson.UseVisualStyleBackColor = true;
            // 
            // buttonPersonSubmit
            // 
            this.buttonPersonSubmit.BackColor = System.Drawing.Color.Transparent;
            this.buttonPersonSubmit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonPersonSubmit.DownBack = null;
            this.buttonPersonSubmit.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPersonSubmit.Location = new System.Drawing.Point(204, 276);
            this.buttonPersonSubmit.MouseBack = null;
            this.buttonPersonSubmit.Name = "buttonPersonSubmit";
            this.buttonPersonSubmit.NormlBack = null;
            this.buttonPersonSubmit.Size = new System.Drawing.Size(75, 36);
            this.buttonPersonSubmit.TabIndex = 4;
            this.buttonPersonSubmit.Text = "提交";
            this.buttonPersonSubmit.UseVisualStyleBackColor = true;
            this.buttonPersonSubmit.Click += new System.EventHandler(this.buttonPersonSubmit_Click);
            // 
            // buttonPersonLeft
            // 
            this.buttonPersonLeft.BackColor = System.Drawing.Color.Transparent;
            this.buttonPersonLeft.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonPersonLeft.DownBack = null;
            this.buttonPersonLeft.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPersonLeft.Location = new System.Drawing.Point(204, 175);
            this.buttonPersonLeft.MouseBack = null;
            this.buttonPersonLeft.Name = "buttonPersonLeft";
            this.buttonPersonLeft.NormlBack = null;
            this.buttonPersonLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonPersonLeft.TabIndex = 3;
            this.buttonPersonLeft.Text = "<<";
            this.buttonPersonLeft.UseVisualStyleBackColor = true;
            this.buttonPersonLeft.Click += new System.EventHandler(this.buttonPersonLeft_Click);
            // 
            // buttonPersonRight
            // 
            this.buttonPersonRight.BackColor = System.Drawing.Color.Transparent;
            this.buttonPersonRight.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonPersonRight.DownBack = null;
            this.buttonPersonRight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPersonRight.Location = new System.Drawing.Point(204, 146);
            this.buttonPersonRight.MouseBack = null;
            this.buttonPersonRight.Name = "buttonPersonRight";
            this.buttonPersonRight.NormlBack = null;
            this.buttonPersonRight.Size = new System.Drawing.Size(75, 23);
            this.buttonPersonRight.TabIndex = 2;
            this.buttonPersonRight.Text = ">>";
            this.buttonPersonRight.UseVisualStyleBackColor = true;
            this.buttonPersonRight.Click += new System.EventHandler(this.buttonPersonRight_Click);
            // 
            // listIncludedPerson
            // 
            this.listIncludedPerson.Back = null;
            this.listIncludedPerson.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
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
            this.listAllPerson.Back = null;
            this.listAllPerson.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
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
            this.tabPageChecker.Location = new System.Drawing.Point(0, 36);
            this.tabPageChecker.Name = "tabPageChecker";
            this.tabPageChecker.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChecker.Size = new System.Drawing.Size(496, 370);
            this.tabPageChecker.TabIndex = 3;
            this.tabPageChecker.Text = "负责人委任";
            this.tabPageChecker.UseVisualStyleBackColor = true;
            // 
            // buttonCheckerSubmit
            // 
            this.buttonCheckerSubmit.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheckerSubmit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonCheckerSubmit.DownBack = null;
            this.buttonCheckerSubmit.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCheckerSubmit.Location = new System.Drawing.Point(209, 343);
            this.buttonCheckerSubmit.MouseBack = null;
            this.buttonCheckerSubmit.Name = "buttonCheckerSubmit";
            this.buttonCheckerSubmit.NormlBack = null;
            this.buttonCheckerSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckerSubmit.TabIndex = 1;
            this.buttonCheckerSubmit.Text = "提交";
            this.buttonCheckerSubmit.UseVisualStyleBackColor = true;
            this.buttonCheckerSubmit.Click += new System.EventHandler(this.buttonCheckerSubmit_Click);
            // 
            // gridChecker
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.gridChecker.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridChecker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridChecker.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridChecker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridChecker.ColumnFont = null;
            this.gridChecker.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridChecker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridChecker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChecker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c00});
            this.gridChecker.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridChecker.DefaultCellBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridChecker.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridChecker.EnableHeadersVisualStyles = false;
            this.gridChecker.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridChecker.HeadFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridChecker.HeadForeColor = System.Drawing.SystemColors.ControlText;
            this.gridChecker.HeadSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.gridChecker.HeadSelectForeColor = System.Drawing.Color.White;
            this.gridChecker.Location = new System.Drawing.Point(0, 0);
            this.gridChecker.Name = "gridChecker";
            this.gridChecker.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridChecker.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridChecker.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridChecker.RowTemplate.Height = 23;
            this.gridChecker.Size = new System.Drawing.Size(485, 336);
            this.gridChecker.TabIndex = 0;
            this.gridChecker.TitleBack = null;
            this.gridChecker.TitleBackColorBegin = System.Drawing.Color.White;
            this.gridChecker.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // c00
            // 
            this.c00.HeaderText = "任务名称";
            this.c00.Name = "c00";
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.gridCheckLog);
            this.tabPageLog.Location = new System.Drawing.Point(0, 36);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(496, 370);
            this.tabPageLog.TabIndex = 4;
            this.tabPageLog.Text = "日志批阅";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // gridCheckLog
            // 
            this.gridCheckLog.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.gridCheckLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridCheckLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCheckLog.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridCheckLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCheckLog.ColumnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridCheckLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCheckLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridCheckLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCheckLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnUser,
            this.ColumnTime,
            this.ColumnTask,
            this.ColumnIsChecked});
            this.gridCheckLog.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridCheckLog.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.gridCheckLog.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridCheckLog.RowTemplate.Height = 23;
            this.gridCheckLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCheckLog.Size = new System.Drawing.Size(500, 376);
            this.gridCheckLog.TabIndex = 0;
            this.gridCheckLog.TitleBack = null;
            this.gridCheckLog.TitleBackColorBegin = System.Drawing.Color.White;
            this.gridCheckLog.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.gridCheckLog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCheckLog_CellClick);
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.FillWeight = 76.14214F;
            this.ColumnNumber.HeaderText = "ID";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            // 
            // ColumnUser
            // 
            this.ColumnUser.FillWeight = 86.37647F;
            this.ColumnUser.HeaderText = "用户名";
            this.ColumnUser.Name = "ColumnUser";
            this.ColumnUser.ReadOnly = true;
            // 
            // ColumnTime
            // 
            this.ColumnTime.FillWeight = 147.2513F;
            this.ColumnTime.HeaderText = "创建时间";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            // 
            // ColumnTask
            // 
            this.ColumnTask.FillWeight = 89.05198F;
            this.ColumnTask.HeaderText = "任务名";
            this.ColumnTask.Name = "ColumnTask";
            this.ColumnTask.ReadOnly = true;
            // 
            // ColumnIsChecked
            // 
            this.ColumnIsChecked.FillWeight = 101.1782F;
            this.ColumnIsChecked.HeaderText = "是否批阅";
            this.ColumnIsChecked.Name = "ColumnIsChecked";
            this.ColumnIsChecked.ReadOnly = true;
            // 
            // tabPageProcess
            // 
            this.tabPageProcess.Controls.Add(this.buttonProcessSubmit);
            this.tabPageProcess.Controls.Add(this.gridProcess);
            this.tabPageProcess.Location = new System.Drawing.Point(0, 36);
            this.tabPageProcess.Name = "tabPageProcess";
            this.tabPageProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcess.Size = new System.Drawing.Size(496, 370);
            this.tabPageProcess.TabIndex = 5;
            this.tabPageProcess.Text = "项目进度";
            this.tabPageProcess.UseVisualStyleBackColor = true;
            // 
            // buttonProcessSubmit
            // 
            this.buttonProcessSubmit.BackColor = System.Drawing.Color.Transparent;
            this.buttonProcessSubmit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonProcessSubmit.DownBack = null;
            this.buttonProcessSubmit.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonProcessSubmit.Location = new System.Drawing.Point(209, 343);
            this.buttonProcessSubmit.MouseBack = null;
            this.buttonProcessSubmit.Name = "buttonProcessSubmit";
            this.buttonProcessSubmit.NormlBack = null;
            this.buttonProcessSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonProcessSubmit.TabIndex = 1;
            this.buttonProcessSubmit.Text = "提交";
            this.buttonProcessSubmit.UseVisualStyleBackColor = true;
            this.buttonProcessSubmit.Click += new System.EventHandler(this.buttonProcessSubmit_Click);
            // 
            // gridProcess
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.gridProcess.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProcess.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridProcess.ColumnFont = null;
            this.gridProcess.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProcess.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c10});
            this.gridProcess.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridProcess.DefaultCellBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProcess.DefaultCellStyle = dataGridViewCellStyle9;
            this.gridProcess.EnableHeadersVisualStyles = false;
            this.gridProcess.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridProcess.HeadFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridProcess.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridProcess.Location = new System.Drawing.Point(0, 0);
            this.gridProcess.Name = "gridProcess";
            this.gridProcess.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridProcess.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridProcess.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridProcess.RowTemplate.Height = 23;
            this.gridProcess.Size = new System.Drawing.Size(488, 336);
            this.gridProcess.TabIndex = 0;
            this.gridProcess.TitleBack = null;
            this.gridProcess.TitleBackColorBegin = System.Drawing.Color.White;
            this.gridProcess.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // c10
            // 
            this.c10.HeaderText = "任务名称";
            this.c10.Name = "c10";
            // 
            // buttonCreateProject
            // 
            this.buttonCreateProject.BackColor = System.Drawing.Color.Transparent;
            this.buttonCreateProject.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonCreateProject.DownBack = null;
            this.buttonCreateProject.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCreateProject.Location = new System.Drawing.Point(55, 455);
            this.buttonCreateProject.MouseBack = null;
            this.buttonCreateProject.Name = "buttonCreateProject";
            this.buttonCreateProject.NormlBack = null;
            this.buttonCreateProject.Size = new System.Drawing.Size(96, 37);
            this.buttonCreateProject.TabIndex = 5;
            this.buttonCreateProject.Text = "新建项目";
            this.buttonCreateProject.UseVisualStyleBackColor = true;
            this.buttonCreateProject.Click += new System.EventHandler(this.buttonCreateProject_Click);
            // 
            // FormManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = global::PEP.Properties.Resources.main_8;
            this.ClientSize = new System.Drawing.Size(804, 582);
            this.Controls.Add(this.buttonCreateProject);
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
            this.tabPageProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelProject;
        private CCWin.SkinControl.SkinListBox listProject;
        private System.Windows.Forms.Panel panelProject;
        private CCWin.SkinControl.SkinTabControl tabControl;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.TabPage tabPageTask;
        private System.Windows.Forms.TabPage tabPagePerson;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelPname;
        private System.Windows.Forms.Label labelTime;
        private CCWin.SkinControl.SkinTextBox textNumber;
        private CCWin.SkinControl.SkinTextBox textPname;
        private CCWin.SkinControl.SkinTextBox textTime;
        private CCWin.SkinControl.SkinButton buttonInfoSubmit;
        private CCWin.SkinControl.SkinButton buttonTaskRight;
        private CCWin.SkinControl.SkinListBox listIncludedTask;
        private CCWin.SkinControl.SkinListBox listAllTask;
        private CCWin.SkinControl.SkinButton buttonTaskLeft;
        private CCWin.SkinControl.SkinButton buttonTaskSubmit;
        private System.Windows.Forms.TabPage tabPageChecker;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.TabPage tabPageProcess;
        private CCWin.SkinControl.SkinListBox listIncludedPerson;
        private CCWin.SkinControl.SkinListBox listAllPerson;
        private CCWin.SkinControl.SkinButton buttonPersonLeft;
        private CCWin.SkinControl.SkinButton buttonPersonRight;
        private CCWin.SkinControl.SkinButton buttonPersonSubmit;
        private CCWin.SkinControl.SkinDataGridView gridChecker;
        private CCWin.SkinControl.SkinButton buttonCheckerSubmit;
        private CCWin.SkinControl.SkinDataGridView gridCheckLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn c00;
        private CCWin.SkinControl.SkinDataGridView gridProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn c10;
        private CCWin.SkinControl.SkinButton buttonProcessSubmit;
        private CCWin.SkinControl.SkinButton buttonCreateProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIsChecked;
    }
}