namespace PEP
{
    partial class FormCreateProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateProject));
            this.tabCreateProject = new CCWin.SkinControl.SkinTabControl();
            this.tabPageSetName = new CCWin.SkinControl.SkinTabPage();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.textTime = new CCWin.SkinControl.SkinTextBox();
            this.textPname = new CCWin.SkinControl.SkinTextBox();
            this.textNumber = new CCWin.SkinControl.SkinTextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPname = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.tabPageSetTasks = new CCWin.SkinControl.SkinTabPage();
            this.buttonTaskLeft = new CCWin.SkinControl.SkinButton();
            this.buttonTaskRight = new CCWin.SkinControl.SkinButton();
            this.listIncludedTask = new System.Windows.Forms.ListBox();
            this.listAllTask = new System.Windows.Forms.ListBox();
            this.tabPageSetUsers = new CCWin.SkinControl.SkinTabPage();
            this.buttonPersonLeft = new CCWin.SkinControl.SkinButton();
            this.buttonPersonRight = new CCWin.SkinControl.SkinButton();
            this.listIncludedPerson = new System.Windows.Forms.ListBox();
            this.listAllPerson = new System.Windows.Forms.ListBox();
            this.buttonLast = new CCWin.SkinControl.SkinButton();
            this.buttonCancel = new CCWin.SkinControl.SkinButton();
            this.buttonNext = new CCWin.SkinControl.SkinButton();
            this.tabCreateProject.SuspendLayout();
            this.tabPageSetName.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.tabPageSetTasks.SuspendLayout();
            this.tabPageSetUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCreateProject
            // 
            this.tabCreateProject.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tabCreateProject.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tabCreateProject.Controls.Add(this.tabPageSetName);
            this.tabCreateProject.Controls.Add(this.tabPageSetTasks);
            this.tabCreateProject.Controls.Add(this.tabPageSetUsers);
            this.tabCreateProject.HeadBack = null;
            this.tabCreateProject.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tabCreateProject.ItemSize = new System.Drawing.Size(70, 36);
            this.tabCreateProject.Location = new System.Drawing.Point(7, 39);
            this.tabCreateProject.Name = "tabCreateProject";
            this.tabCreateProject.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tabCreateProject.PageArrowDown")));
            this.tabCreateProject.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tabCreateProject.PageArrowHover")));
            this.tabCreateProject.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tabCreateProject.PageCloseHover")));
            this.tabCreateProject.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tabCreateProject.PageCloseNormal")));
            this.tabCreateProject.PageDown = ((System.Drawing.Image)(resources.GetObject("tabCreateProject.PageDown")));
            this.tabCreateProject.PageHover = ((System.Drawing.Image)(resources.GetObject("tabCreateProject.PageHover")));
            this.tabCreateProject.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tabCreateProject.PageNorml = null;
            this.tabCreateProject.SelectedIndex = 0;
            this.tabCreateProject.Size = new System.Drawing.Size(514, 375);
            this.tabCreateProject.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCreateProject.TabIndex = 0;
            this.tabCreateProject.SelectedIndexChanged += new System.EventHandler(this.tabCreateProject_SelectedIndexChanged);
            // 
            // tabPageSetName
            // 
            this.tabPageSetName.BackColor = System.Drawing.Color.White;
            this.tabPageSetName.Controls.Add(this.panelInfo);
            this.tabPageSetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageSetName.Location = new System.Drawing.Point(0, 36);
            this.tabPageSetName.Name = "tabPageSetName";
            this.tabPageSetName.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetName.Size = new System.Drawing.Size(514, 339);
            this.tabPageSetName.TabIndex = 0;
            this.tabPageSetName.TabItemImage = null;
            this.tabPageSetName.Text = "项目名";
            this.tabPageSetName.UseVisualStyleBackColor = true;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.textTime);
            this.panelInfo.Controls.Add(this.textPname);
            this.panelInfo.Controls.Add(this.textNumber);
            this.panelInfo.Controls.Add(this.labelTime);
            this.panelInfo.Controls.Add(this.labelPname);
            this.panelInfo.Controls.Add(this.labelNumber);
            this.panelInfo.Location = new System.Drawing.Point(17, 59);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(447, 203);
            this.panelInfo.TabIndex = 1;
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
            this.labelTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTime.Location = new System.Drawing.Point(112, 105);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(74, 21);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "创建时间";
            // 
            // labelPname
            // 
            this.labelPname.AutoSize = true;
            this.labelPname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPname.Location = new System.Drawing.Point(112, 67);
            this.labelPname.Name = "labelPname";
            this.labelPname.Size = new System.Drawing.Size(58, 21);
            this.labelPname.TabIndex = 1;
            this.labelPname.Text = "项目名";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNumber.Location = new System.Drawing.Point(112, 28);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(74, 21);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "项目编号";
            // 
            // tabPageSetTasks
            // 
            this.tabPageSetTasks.BackColor = System.Drawing.Color.White;
            this.tabPageSetTasks.Controls.Add(this.buttonTaskLeft);
            this.tabPageSetTasks.Controls.Add(this.buttonTaskRight);
            this.tabPageSetTasks.Controls.Add(this.listIncludedTask);
            this.tabPageSetTasks.Controls.Add(this.listAllTask);
            this.tabPageSetTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageSetTasks.Location = new System.Drawing.Point(0, 36);
            this.tabPageSetTasks.Name = "tabPageSetTasks";
            this.tabPageSetTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetTasks.Size = new System.Drawing.Size(514, 339);
            this.tabPageSetTasks.TabIndex = 1;
            this.tabPageSetTasks.TabItemImage = null;
            this.tabPageSetTasks.Text = "子任务";
            this.tabPageSetTasks.UseVisualStyleBackColor = true;
            // 
            // buttonTaskLeft
            // 
            this.buttonTaskLeft.BackColor = System.Drawing.Color.Transparent;
            this.buttonTaskLeft.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonTaskLeft.DownBack = null;
            this.buttonTaskLeft.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTaskLeft.Location = new System.Drawing.Point(216, 165);
            this.buttonTaskLeft.MouseBack = null;
            this.buttonTaskLeft.Name = "buttonTaskLeft";
            this.buttonTaskLeft.NormlBack = null;
            this.buttonTaskLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonTaskLeft.TabIndex = 8;
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
            this.buttonTaskRight.Location = new System.Drawing.Point(216, 136);
            this.buttonTaskRight.MouseBack = null;
            this.buttonTaskRight.Name = "buttonTaskRight";
            this.buttonTaskRight.NormlBack = null;
            this.buttonTaskRight.Size = new System.Drawing.Size(75, 23);
            this.buttonTaskRight.TabIndex = 7;
            this.buttonTaskRight.Text = ">>";
            this.buttonTaskRight.UseVisualStyleBackColor = true;
            this.buttonTaskRight.Click += new System.EventHandler(this.buttonTaskRight_Click);
            // 
            // listIncludedTask
            // 
            this.listIncludedTask.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listIncludedTask.FormattingEnabled = true;
            this.listIncludedTask.ItemHeight = 20;
            this.listIncludedTask.Location = new System.Drawing.Point(309, 28);
            this.listIncludedTask.Name = "listIncludedTask";
            this.listIncludedTask.Size = new System.Drawing.Size(136, 284);
            this.listIncludedTask.TabIndex = 6;
            this.listIncludedTask.SelectedIndexChanged += new System.EventHandler(this.listIncludedTask_SelectedIndexChanged);
            // 
            // listAllTask
            // 
            this.listAllTask.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listAllTask.FormattingEnabled = true;
            this.listAllTask.ItemHeight = 20;
            this.listAllTask.Location = new System.Drawing.Point(61, 28);
            this.listAllTask.Name = "listAllTask";
            this.listAllTask.Size = new System.Drawing.Size(136, 284);
            this.listAllTask.TabIndex = 5;
            this.listAllTask.SelectedIndexChanged += new System.EventHandler(this.listAllTask_SelectedIndexChanged);
            // 
            // tabPageSetUsers
            // 
            this.tabPageSetUsers.BackColor = System.Drawing.Color.White;
            this.tabPageSetUsers.Controls.Add(this.buttonPersonLeft);
            this.tabPageSetUsers.Controls.Add(this.buttonPersonRight);
            this.tabPageSetUsers.Controls.Add(this.listIncludedPerson);
            this.tabPageSetUsers.Controls.Add(this.listAllPerson);
            this.tabPageSetUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageSetUsers.Location = new System.Drawing.Point(0, 36);
            this.tabPageSetUsers.Name = "tabPageSetUsers";
            this.tabPageSetUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetUsers.Size = new System.Drawing.Size(514, 339);
            this.tabPageSetUsers.TabIndex = 2;
            this.tabPageSetUsers.TabItemImage = null;
            this.tabPageSetUsers.Text = "人员分配";
            this.tabPageSetUsers.UseVisualStyleBackColor = true;
            // 
            // buttonPersonLeft
            // 
            this.buttonPersonLeft.BackColor = System.Drawing.Color.Transparent;
            this.buttonPersonLeft.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonPersonLeft.DownBack = null;
            this.buttonPersonLeft.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPersonLeft.Location = new System.Drawing.Point(216, 165);
            this.buttonPersonLeft.MouseBack = null;
            this.buttonPersonLeft.Name = "buttonPersonLeft";
            this.buttonPersonLeft.NormlBack = null;
            this.buttonPersonLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonPersonLeft.TabIndex = 12;
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
            this.buttonPersonRight.Location = new System.Drawing.Point(216, 136);
            this.buttonPersonRight.MouseBack = null;
            this.buttonPersonRight.Name = "buttonPersonRight";
            this.buttonPersonRight.NormlBack = null;
            this.buttonPersonRight.Size = new System.Drawing.Size(75, 23);
            this.buttonPersonRight.TabIndex = 11;
            this.buttonPersonRight.Text = ">>";
            this.buttonPersonRight.UseVisualStyleBackColor = true;
            this.buttonPersonRight.Click += new System.EventHandler(this.buttonPersonRight_Click);
            // 
            // listIncludedPerson
            // 
            this.listIncludedPerson.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listIncludedPerson.FormattingEnabled = true;
            this.listIncludedPerson.ItemHeight = 20;
            this.listIncludedPerson.Location = new System.Drawing.Point(309, 28);
            this.listIncludedPerson.Name = "listIncludedPerson";
            this.listIncludedPerson.Size = new System.Drawing.Size(136, 284);
            this.listIncludedPerson.TabIndex = 10;
            this.listIncludedPerson.SelectedIndexChanged += new System.EventHandler(this.listIncludedPerson_SelectedIndexChanged);
            // 
            // listAllPerson
            // 
            this.listAllPerson.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listAllPerson.FormattingEnabled = true;
            this.listAllPerson.ItemHeight = 20;
            this.listAllPerson.Location = new System.Drawing.Point(61, 28);
            this.listAllPerson.Name = "listAllPerson";
            this.listAllPerson.Size = new System.Drawing.Size(136, 284);
            this.listAllPerson.TabIndex = 9;
            this.listAllPerson.SelectedIndexChanged += new System.EventHandler(this.listAllPerson_SelectedIndexChanged);
            // 
            // buttonLast
            // 
            this.buttonLast.BackColor = System.Drawing.Color.Transparent;
            this.buttonLast.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonLast.DownBack = null;
            this.buttonLast.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLast.Location = new System.Drawing.Point(271, 420);
            this.buttonLast.MouseBack = null;
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.NormlBack = null;
            this.buttonLast.Size = new System.Drawing.Size(75, 30);
            this.buttonLast.TabIndex = 10;
            this.buttonLast.Text = "上一步";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonCancel.DownBack = null;
            this.buttonCancel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancel.Location = new System.Drawing.Point(433, 420);
            this.buttonCancel.MouseBack = null;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.NormlBack = null;
            this.buttonCancel.Size = new System.Drawing.Size(75, 30);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonNext.DownBack = null;
            this.buttonNext.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonNext.Location = new System.Drawing.Point(352, 420);
            this.buttonNext.MouseBack = null;
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.NormlBack = null;
            this.buttonNext.Size = new System.Drawing.Size(75, 30);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "下一步";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // FormCreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = global::PEP.Properties.Resources.main_8;
            this.ClientSize = new System.Drawing.Size(535, 466);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.tabCreateProject);
            this.Name = "FormCreateProject";
            this.Text = "新建项目";
            this.Load += new System.EventHandler(this.FormCreateProject_Load);
            this.tabCreateProject.ResumeLayout(false);
            this.tabPageSetName.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.tabPageSetTasks.ResumeLayout(false);
            this.tabPageSetUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl tabCreateProject;
        private CCWin.SkinControl.SkinTabPage tabPageSetName;
        private CCWin.SkinControl.SkinTabPage tabPageSetTasks;
        private CCWin.SkinControl.SkinTabPage tabPageSetUsers;
        private CCWin.SkinControl.SkinButton buttonLast;
        private CCWin.SkinControl.SkinButton buttonCancel;
        private CCWin.SkinControl.SkinButton buttonNext;
        private System.Windows.Forms.Panel panelInfo;
        private CCWin.SkinControl.SkinTextBox textTime;
        private CCWin.SkinControl.SkinTextBox textPname;
        private CCWin.SkinControl.SkinTextBox textNumber;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelPname;
        private System.Windows.Forms.Label labelNumber;
        private CCWin.SkinControl.SkinButton buttonTaskLeft;
        private CCWin.SkinControl.SkinButton buttonTaskRight;
        private System.Windows.Forms.ListBox listIncludedTask;
        private System.Windows.Forms.ListBox listAllTask;
        private CCWin.SkinControl.SkinButton buttonPersonLeft;
        private CCWin.SkinControl.SkinButton buttonPersonRight;
        private System.Windows.Forms.ListBox listIncludedPerson;
        private System.Windows.Forms.ListBox listAllPerson;
    }
}