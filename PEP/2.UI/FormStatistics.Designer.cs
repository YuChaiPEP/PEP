namespace PEP
{
    partial class FormStatistics
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
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.labelProjectValue = new System.Windows.Forms.Label();
            this.labelUnameValue = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelPushCount = new System.Windows.Forms.Label();
            this.labelLogCount = new System.Windows.Forms.Label();
            this.labelProjectCount = new System.Windows.Forms.Label();
            this.labelUname = new System.Windows.Forms.Label();
            this.labelLogValue = new System.Windows.Forms.Label();
            this.labelPushValue = new System.Windows.Forms.Label();
            this.panelStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStatistics
            // 
            this.panelStatistics.Controls.Add(this.labelPushValue);
            this.panelStatistics.Controls.Add(this.labelLogValue);
            this.panelStatistics.Controls.Add(this.labelProjectValue);
            this.panelStatistics.Controls.Add(this.labelUnameValue);
            this.panelStatistics.Controls.Add(this.buttonClose);
            this.panelStatistics.Controls.Add(this.labelPushCount);
            this.panelStatistics.Controls.Add(this.labelLogCount);
            this.panelStatistics.Controls.Add(this.labelProjectCount);
            this.panelStatistics.Controls.Add(this.labelUname);
            this.panelStatistics.Location = new System.Drawing.Point(12, 12);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(260, 205);
            this.panelStatistics.TabIndex = 0;
            // 
            // labelProjectValue
            // 
            this.labelProjectValue.AutoSize = true;
            this.labelProjectValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProjectValue.Location = new System.Drawing.Point(152, 54);
            this.labelProjectValue.Name = "labelProjectValue";
            this.labelProjectValue.Size = new System.Drawing.Size(70, 21);
            this.labelProjectValue.TabIndex = 5;
            this.labelProjectValue.Text = "projects";
            // 
            // labelUnameValue
            // 
            this.labelUnameValue.AutoSize = true;
            this.labelUnameValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUnameValue.Location = new System.Drawing.Point(152, 24);
            this.labelUnameValue.Name = "labelUnameValue";
            this.labelUnameValue.Size = new System.Drawing.Size(63, 21);
            this.labelUnameValue.TabIndex = 4;
            this.labelUnameValue.Text = "uname";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClose.Location = new System.Drawing.Point(95, 160);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "关闭";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelPushCount
            // 
            this.labelPushCount.AutoSize = true;
            this.labelPushCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPushCount.Location = new System.Drawing.Point(14, 116);
            this.labelPushCount.Name = "labelPushCount";
            this.labelPushCount.Size = new System.Drawing.Size(58, 21);
            this.labelPushCount.TabIndex = 2;
            this.labelPushCount.Text = "推送数";
            // 
            // labelLogCount
            // 
            this.labelLogCount.AutoSize = true;
            this.labelLogCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLogCount.Location = new System.Drawing.Point(14, 84);
            this.labelLogCount.Name = "labelLogCount";
            this.labelLogCount.Size = new System.Drawing.Size(90, 21);
            this.labelLogCount.TabIndex = 1;
            this.labelLogCount.Text = "提交日志数";
            // 
            // labelProjectCount
            // 
            this.labelProjectCount.AutoSize = true;
            this.labelProjectCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProjectCount.Location = new System.Drawing.Point(14, 54);
            this.labelProjectCount.Name = "labelProjectCount";
            this.labelProjectCount.Size = new System.Drawing.Size(122, 21);
            this.labelProjectCount.TabIndex = 1;
            this.labelProjectCount.Text = "当前参与项目数";
            // 
            // labelUname
            // 
            this.labelUname.AutoSize = true;
            this.labelUname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUname.Location = new System.Drawing.Point(14, 24);
            this.labelUname.Name = "labelUname";
            this.labelUname.Size = new System.Drawing.Size(58, 21);
            this.labelUname.TabIndex = 0;
            this.labelUname.Text = "用户名";
            // 
            // labelLogValue
            // 
            this.labelLogValue.AutoSize = true;
            this.labelLogValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLogValue.Location = new System.Drawing.Point(152, 84);
            this.labelLogValue.Name = "labelLogValue";
            this.labelLogValue.Size = new System.Drawing.Size(41, 21);
            this.labelLogValue.TabIndex = 1;
            this.labelLogValue.Text = "logs";
            // 
            // labelPushValue
            // 
            this.labelPushValue.AutoSize = true;
            this.labelPushValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPushValue.Location = new System.Drawing.Point(152, 116);
            this.labelPushValue.Name = "labelPushValue";
            this.labelPushValue.Size = new System.Drawing.Size(54, 21);
            this.labelPushValue.TabIndex = 6;
            this.labelPushValue.Text = "pushs";
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 225);
            this.Controls.Add(this.panelStatistics);
            this.Name = "FormStatistics";
            this.Text = "个人统计";
            this.panelStatistics.ResumeLayout(false);
            this.panelStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStatistics;
        private System.Windows.Forms.Label labelUname;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelPushCount;
        private System.Windows.Forms.Label labelLogCount;
        private System.Windows.Forms.Label labelProjectCount;
        private System.Windows.Forms.Label labelUnameValue;
        private System.Windows.Forms.Label labelProjectValue;
        private System.Windows.Forms.Label labelLogValue;
        private System.Windows.Forms.Label labelPushValue;
    }
}