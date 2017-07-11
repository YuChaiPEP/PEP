namespace PEP
{
    partial class bu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.tabPageProcess = new System.Windows.Forms.TabPage();
            this.gridChecker = new System.Windows.Forms.DataGridView();
            this.c0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCheckerSubmit = new System.Windows.Forms.Button();
            this.panelWelcome.SuspendLayout();
            this.panelProject.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.tabPageTask.SuspendLayout();
            this.tabPagePerson.SuspendLayout();
            this.tabPageChecker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChecker)).BeginInit();
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
            // tabPageLog
            // 
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
            // gridChecker
            // 
            this.gridChecker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridChecker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridChecker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChecker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c0});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridChecker.DefaultCellStyle = dataGridViewCellStyle6;
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
            // bu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 582);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelProject);
            this.Controls.Add(this.panelWelcome);
            this.Name = "bu";
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
    }
}