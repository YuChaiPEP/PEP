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
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelProject = new System.Windows.Forms.Label();
            this.listProject = new System.Windows.Forms.ListBox();
            this.panelProject = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.textPname = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPname = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textTime = new System.Windows.Forms.TextBox();
            this.buttonInfoSubmit = new System.Windows.Forms.Button();
            this.panelWelcome.SuspendLayout();
            this.panelProject.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            this.panelInfo.SuspendLayout();
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
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
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
            this.tabPageInfo.Text = "修改项目信息";
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(488, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(488, 372);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelPname;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textPname;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.Button buttonInfoSubmit;
    }
}