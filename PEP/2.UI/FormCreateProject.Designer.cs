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
            this.button2 = new System.Windows.Forms.Button();
            this.tabPageSetUsers = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPageSetAllocation = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.tabCreateProject.SuspendLayout();
            this.tabPageSetName.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.tabPageSetTasks.SuspendLayout();
            this.tabPageSetUsers.SuspendLayout();
            this.tabPageSetAllocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCreateProject
            // 
            this.tabCreateProject.Controls.Add(this.tabPageSetName);
            this.tabCreateProject.Controls.Add(this.tabPageSetTasks);
            this.tabCreateProject.Controls.Add(this.tabPageSetUsers);
            this.tabCreateProject.Controls.Add(this.tabPageSetAllocation);
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
            this.tabPageSetTasks.Controls.Add(this.button2);
            this.tabPageSetTasks.Location = new System.Drawing.Point(4, 22);
            this.tabPageSetTasks.Name = "tabPageSetTasks";
            this.tabPageSetTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetTasks.Size = new System.Drawing.Size(506, 349);
            this.tabPageSetTasks.TabIndex = 1;
            this.tabPageSetTasks.Text = "子任务";
            this.tabPageSetTasks.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPageSetUsers
            // 
            this.tabPageSetUsers.Controls.Add(this.button3);
            this.tabPageSetUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageSetUsers.Name = "tabPageSetUsers";
            this.tabPageSetUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetUsers.Size = new System.Drawing.Size(506, 349);
            this.tabPageSetUsers.TabIndex = 2;
            this.tabPageSetUsers.Text = "人员分配";
            this.tabPageSetUsers.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(245, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tabPageSetAllocation
            // 
            this.tabPageSetAllocation.Controls.Add(this.button4);
            this.tabPageSetAllocation.Location = new System.Drawing.Point(4, 22);
            this.tabPageSetAllocation.Name = "tabPageSetAllocation";
            this.tabPageSetAllocation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetAllocation.Size = new System.Drawing.Size(506, 349);
            this.tabPageSetAllocation.TabIndex = 3;
            this.tabPageSetAllocation.Text = "负责人委任";
            this.tabPageSetAllocation.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(217, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
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
            this.tabPageSetAllocation.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPageSetAllocation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.TextBox textPname;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelPname;
        private System.Windows.Forms.Label labelNumber;
    }
}