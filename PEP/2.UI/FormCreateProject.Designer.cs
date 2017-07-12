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
            this.tabCreateProject = new System.Windows.Forms.TabControl();
            this.tabPageSetName = new System.Windows.Forms.TabPage();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.textTime = new System.Windows.Forms.TextBox();
            this.textPname = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPname = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.tabPageSetTasks = new System.Windows.Forms.TabPage();
            this.buttonTaskLeft = new System.Windows.Forms.Button();
            this.buttonTaskRight = new System.Windows.Forms.Button();
            this.listIncludedTask = new System.Windows.Forms.ListBox();
            this.listAllTask = new System.Windows.Forms.ListBox();
            this.tabPageSetUsers = new System.Windows.Forms.TabPage();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPersonLeft = new System.Windows.Forms.Button();
            this.buttonPersonRight = new System.Windows.Forms.Button();
            this.listIncludedPerson = new System.Windows.Forms.ListBox();
            this.listAllPerson = new System.Windows.Forms.ListBox();
            this.tabCreateProject.SuspendLayout();
            this.tabPageSetName.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.tabPageSetTasks.SuspendLayout();
            this.tabPageSetUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCreateProject
            // 
            this.tabCreateProject.Controls.Add(this.tabPageSetName);
            this.tabCreateProject.Controls.Add(this.tabPageSetTasks);
            this.tabCreateProject.Controls.Add(this.tabPageSetUsers);
            this.tabCreateProject.Location = new System.Drawing.Point(0, -3);
            this.tabCreateProject.Name = "tabCreateProject";
            this.tabCreateProject.SelectedIndex = 0;
            this.tabCreateProject.Size = new System.Drawing.Size(514, 375);
            this.tabCreateProject.TabIndex = 0;
            this.tabCreateProject.SelectedIndexChanged += new System.EventHandler(this.tabCreateProject_SelectedIndexChanged);
            // 
            // tabPageSetName
            // 
            this.tabPageSetName.Controls.Add(this.panelInfo);
            this.tabPageSetName.Location = new System.Drawing.Point(4, 22);
            this.tabPageSetName.Name = "tabPageSetName";
            this.tabPageSetName.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetName.Size = new System.Drawing.Size(506, 349);
            this.tabPageSetName.TabIndex = 0;
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
            this.tabPageSetTasks.Controls.Add(this.buttonTaskLeft);
            this.tabPageSetTasks.Controls.Add(this.buttonTaskRight);
            this.tabPageSetTasks.Controls.Add(this.listIncludedTask);
            this.tabPageSetTasks.Controls.Add(this.listAllTask);
            this.tabPageSetTasks.Location = new System.Drawing.Point(4, 22);
            this.tabPageSetTasks.Name = "tabPageSetTasks";
            this.tabPageSetTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetTasks.Size = new System.Drawing.Size(506, 349);
            this.tabPageSetTasks.TabIndex = 1;
            this.tabPageSetTasks.Text = "子任务";
            this.tabPageSetTasks.UseVisualStyleBackColor = true;
            // 
            // buttonTaskLeft
            // 
            this.buttonTaskLeft.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTaskLeft.Location = new System.Drawing.Point(216, 165);
            this.buttonTaskLeft.Name = "buttonTaskLeft";
            this.buttonTaskLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonTaskLeft.TabIndex = 8;
            this.buttonTaskLeft.Text = "<<";
            this.buttonTaskLeft.UseVisualStyleBackColor = true;
            this.buttonTaskLeft.Click += new System.EventHandler(this.buttonTaskLeft_Click);
            // 
            // buttonTaskRight
            // 
            this.buttonTaskRight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTaskRight.Location = new System.Drawing.Point(216, 136);
            this.buttonTaskRight.Name = "buttonTaskRight";
            this.buttonTaskRight.Size = new System.Drawing.Size(75, 23);
            this.buttonTaskRight.TabIndex = 7;
            this.buttonTaskRight.Text = ">>";
            this.buttonTaskRight.UseVisualStyleBackColor = true;
            this.buttonTaskRight.Click += new System.EventHandler(this.buttonTaskRight_Click);
            // 
            // listIncludedTask
            // 
            this.listIncludedTask.FormattingEnabled = true;
            this.listIncludedTask.ItemHeight = 12;
            this.listIncludedTask.Location = new System.Drawing.Point(309, 28);
            this.listIncludedTask.Name = "listIncludedTask";
            this.listIncludedTask.Size = new System.Drawing.Size(136, 292);
            this.listIncludedTask.TabIndex = 6;
            this.listIncludedTask.SelectedIndexChanged += new System.EventHandler(this.listIncludedTask_SelectedIndexChanged);
            // 
            // listAllTask
            // 
            this.listAllTask.FormattingEnabled = true;
            this.listAllTask.ItemHeight = 12;
            this.listAllTask.Location = new System.Drawing.Point(61, 28);
            this.listAllTask.Name = "listAllTask";
            this.listAllTask.Size = new System.Drawing.Size(136, 292);
            this.listAllTask.TabIndex = 5;
            this.listAllTask.SelectedIndexChanged += new System.EventHandler(this.listAllTask_SelectedIndexChanged);
            // 
            // tabPageSetUsers
            // 
            this.tabPageSetUsers.Controls.Add(this.buttonPersonLeft);
            this.tabPageSetUsers.Controls.Add(this.buttonPersonRight);
            this.tabPageSetUsers.Controls.Add(this.listIncludedPerson);
            this.tabPageSetUsers.Controls.Add(this.listAllPerson);
            this.tabPageSetUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageSetUsers.Name = "tabPageSetUsers";
            this.tabPageSetUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetUsers.Size = new System.Drawing.Size(506, 349);
            this.tabPageSetUsers.TabIndex = 2;
            this.tabPageSetUsers.Text = "人员分配";
            this.tabPageSetUsers.UseVisualStyleBackColor = true;
            // 
            // buttonLast
            // 
            this.buttonLast.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLast.Location = new System.Drawing.Point(262, 388);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 30);
            this.buttonLast.TabIndex = 10;
            this.buttonLast.Text = "上一步";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancel.Location = new System.Drawing.Point(424, 388);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 30);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonNext.Location = new System.Drawing.Point(343, 388);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 30);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "下一步";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPersonLeft
            // 
            this.buttonPersonLeft.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPersonLeft.Location = new System.Drawing.Point(216, 165);
            this.buttonPersonLeft.Name = "buttonPersonLeft";
            this.buttonPersonLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonPersonLeft.TabIndex = 12;
            this.buttonPersonLeft.Text = "<<";
            this.buttonPersonLeft.UseVisualStyleBackColor = true;
            this.buttonPersonLeft.Click += new System.EventHandler(this.buttonPersonLeft_Click);
            // 
            // buttonPersonRight
            // 
            this.buttonPersonRight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPersonRight.Location = new System.Drawing.Point(216, 136);
            this.buttonPersonRight.Name = "buttonPersonRight";
            this.buttonPersonRight.Size = new System.Drawing.Size(75, 23);
            this.buttonPersonRight.TabIndex = 11;
            this.buttonPersonRight.Text = ">>";
            this.buttonPersonRight.UseVisualStyleBackColor = true;
            this.buttonPersonRight.Click += new System.EventHandler(this.buttonPersonRight_Click);
            // 
            // listIncludedPerson
            // 
            this.listIncludedPerson.FormattingEnabled = true;
            this.listIncludedPerson.ItemHeight = 12;
            this.listIncludedPerson.Location = new System.Drawing.Point(309, 28);
            this.listIncludedPerson.Name = "listIncludedPerson";
            this.listIncludedPerson.Size = new System.Drawing.Size(136, 292);
            this.listIncludedPerson.TabIndex = 10;
            this.listIncludedPerson.SelectedIndexChanged += new System.EventHandler(this.listIncludedPerson_SelectedIndexChanged);
            // 
            // listAllPerson
            // 
            this.listAllPerson.FormattingEnabled = true;
            this.listAllPerson.ItemHeight = 12;
            this.listAllPerson.Location = new System.Drawing.Point(61, 28);
            this.listAllPerson.Name = "listAllPerson";
            this.listAllPerson.Size = new System.Drawing.Size(136, 292);
            this.listAllPerson.TabIndex = 9;
            this.listAllPerson.SelectedIndexChanged += new System.EventHandler(this.listAllPerson_SelectedIndexChanged);
            // 
            // FormCreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 429);
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

        private System.Windows.Forms.TabControl tabCreateProject;
        private System.Windows.Forms.TabPage tabPageSetName;
        private System.Windows.Forms.TabPage tabPageSetTasks;
        private System.Windows.Forms.TabPage tabPageSetUsers;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.TextBox textPname;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelPname;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button buttonTaskLeft;
        private System.Windows.Forms.Button buttonTaskRight;
        private System.Windows.Forms.ListBox listIncludedTask;
        private System.Windows.Forms.ListBox listAllTask;
        private System.Windows.Forms.Button buttonPersonLeft;
        private System.Windows.Forms.Button buttonPersonRight;
        private System.Windows.Forms.ListBox listIncludedPerson;
        private System.Windows.Forms.ListBox listAllPerson;
    }
}