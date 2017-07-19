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
            this.components = new System.ComponentModel.Container();
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.labelPushValue = new System.Windows.Forms.Label();
            this.labelLogValue = new System.Windows.Forms.Label();
            this.labelProjectValue = new System.Windows.Forms.Label();
            this.labelUnameValue = new System.Windows.Forms.Label();
            this.buttonClose = new CCWin.SkinControl.SkinButton();
            this.labelPushCount = new System.Windows.Forms.Label();
            this.labelLogCount = new System.Windows.Forms.Label();
            this.labelProjectCount = new System.Windows.Forms.Label();
            this.labelUname = new System.Windows.Forms.Label();
            this.labelProjectEDCount = new System.Windows.Forms.Label();
            this.labelProjectEDValue = new System.Windows.Forms.Label();
            this.labelLogMonthCount = new System.Windows.Forms.Label();
            this.labelLogMonthValue = new System.Windows.Forms.Label();
            this.labelPushMonthCount = new System.Windows.Forms.Label();
            this.labelPushMonthValue = new System.Windows.Forms.Label();
            this.panelStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStatistics
            // 
            this.panelStatistics.BackColor = System.Drawing.Color.Transparent;
            this.panelStatistics.Controls.Add(this.labelPushMonthValue);
            this.panelStatistics.Controls.Add(this.labelPushMonthCount);
            this.panelStatistics.Controls.Add(this.labelLogMonthValue);
            this.panelStatistics.Controls.Add(this.labelLogMonthCount);
            this.panelStatistics.Controls.Add(this.labelProjectEDValue);
            this.panelStatistics.Controls.Add(this.labelProjectEDCount);
            this.panelStatistics.Controls.Add(this.labelPushValue);
            this.panelStatistics.Controls.Add(this.labelLogValue);
            this.panelStatistics.Controls.Add(this.labelProjectValue);
            this.panelStatistics.Controls.Add(this.labelUnameValue);
            this.panelStatistics.Controls.Add(this.buttonClose);
            this.panelStatistics.Controls.Add(this.labelPushCount);
            this.panelStatistics.Controls.Add(this.labelLogCount);
            this.panelStatistics.Controls.Add(this.labelProjectCount);
            this.panelStatistics.Controls.Add(this.labelUname);
            this.panelStatistics.Location = new System.Drawing.Point(22, 29);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(260, 285);
            this.panelStatistics.TabIndex = 0;
            // 
            // labelPushValue
            // 
            this.labelPushValue.AutoSize = true;
            this.labelPushValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPushValue.Location = new System.Drawing.Point(153, 174);
            this.labelPushValue.Name = "labelPushValue";
            this.labelPushValue.Size = new System.Drawing.Size(111, 21);
            this.labelPushValue.TabIndex = 6;
            this.labelPushValue.Text = "pushs-TOTAL";
            // 
            // labelLogValue
            // 
            this.labelLogValue.AutoSize = true;
            this.labelLogValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLogValue.Location = new System.Drawing.Point(153, 114);
            this.labelLogValue.Name = "labelLogValue";
            this.labelLogValue.Size = new System.Drawing.Size(98, 21);
            this.labelLogValue.TabIndex = 1;
            this.labelLogValue.Text = "logs-TOTAL";
            // 
            // labelProjectValue
            // 
            this.labelProjectValue.AutoSize = true;
            this.labelProjectValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProjectValue.Location = new System.Drawing.Point(152, 54);
            this.labelProjectValue.Name = "labelProjectValue";
            this.labelProjectValue.Size = new System.Drawing.Size(107, 21);
            this.labelProjectValue.TabIndex = 5;
            this.labelProjectValue.Text = "projects-ING";
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
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonClose.DownBack = null;
            this.buttonClose.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClose.Location = new System.Drawing.Point(96, 244);
            this.buttonClose.MouseBack = null;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.NormlBack = null;
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
            this.labelPushCount.Location = new System.Drawing.Point(15, 174);
            this.labelPushCount.Name = "labelPushCount";
            this.labelPushCount.Size = new System.Drawing.Size(74, 21);
            this.labelPushCount.TabIndex = 2;
            this.labelPushCount.Text = "总推送数";
            // 
            // labelLogCount
            // 
            this.labelLogCount.AutoSize = true;
            this.labelLogCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLogCount.Location = new System.Drawing.Point(15, 114);
            this.labelLogCount.Name = "labelLogCount";
            this.labelLogCount.Size = new System.Drawing.Size(74, 21);
            this.labelLogCount.TabIndex = 1;
            this.labelLogCount.Text = "总日志数";
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
            // labelProjectEDCount
            // 
            this.labelProjectEDCount.AutoSize = true;
            this.labelProjectEDCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProjectEDCount.Location = new System.Drawing.Point(14, 84);
            this.labelProjectEDCount.Name = "labelProjectEDCount";
            this.labelProjectEDCount.Size = new System.Drawing.Size(106, 21);
            this.labelProjectEDCount.TabIndex = 7;
            this.labelProjectEDCount.Text = "已完成项目数";
            // 
            // labelProjectEDValue
            // 
            this.labelProjectEDValue.AutoSize = true;
            this.labelProjectEDValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProjectEDValue.Location = new System.Drawing.Point(153, 84);
            this.labelProjectEDValue.Name = "labelProjectEDValue";
            this.labelProjectEDValue.Size = new System.Drawing.Size(98, 21);
            this.labelProjectEDValue.TabIndex = 8;
            this.labelProjectEDValue.Text = "projects-ED";
            // 
            // labelLogMonthCount
            // 
            this.labelLogMonthCount.AutoSize = true;
            this.labelLogMonthCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLogMonthCount.Location = new System.Drawing.Point(14, 144);
            this.labelLogMonthCount.Name = "labelLogMonthCount";
            this.labelLogMonthCount.Size = new System.Drawing.Size(90, 21);
            this.labelLogMonthCount.TabIndex = 9;
            this.labelLogMonthCount.Text = "月内日志数";
            // 
            // labelLogMonthValue
            // 
            this.labelLogMonthValue.AutoSize = true;
            this.labelLogMonthValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLogMonthValue.Location = new System.Drawing.Point(152, 144);
            this.labelLogMonthValue.Name = "labelLogMonthValue";
            this.labelLogMonthValue.Size = new System.Drawing.Size(111, 21);
            this.labelLogMonthValue.TabIndex = 10;
            this.labelLogMonthValue.Text = "logs-MONTH";
            // 
            // labelPushMonthCount
            // 
            this.labelPushMonthCount.AutoSize = true;
            this.labelPushMonthCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPushMonthCount.Location = new System.Drawing.Point(15, 204);
            this.labelPushMonthCount.Name = "labelPushMonthCount";
            this.labelPushMonthCount.Size = new System.Drawing.Size(90, 21);
            this.labelPushMonthCount.TabIndex = 11;
            this.labelPushMonthCount.Text = "月内推送数";
            // 
            // labelPushMonthValue
            // 
            this.labelPushMonthValue.AutoSize = true;
            this.labelPushMonthValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPushMonthValue.Location = new System.Drawing.Point(153, 204);
            this.labelPushMonthValue.Name = "labelPushMonthValue";
            this.labelPushMonthValue.Size = new System.Drawing.Size(124, 21);
            this.labelPushMonthValue.TabIndex = 12;
            this.labelPushMonthValue.Text = "pushs-MONTH";
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = global::PEP.Properties.Resources.main_8;
            this.BackgroundImage = global::PEP.Properties.Resources.main_8;
            this.ClientSize = new System.Drawing.Size(303, 330);
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
        private CCWin.SkinControl.SkinButton buttonClose;
        private System.Windows.Forms.Label labelPushCount;
        private System.Windows.Forms.Label labelLogCount;
        private System.Windows.Forms.Label labelProjectCount;
        private System.Windows.Forms.Label labelUnameValue;
        private System.Windows.Forms.Label labelProjectValue;
        private System.Windows.Forms.Label labelLogValue;
        private System.Windows.Forms.Label labelPushValue;
        private System.Windows.Forms.Label labelProjectEDValue;
        private System.Windows.Forms.Label labelProjectEDCount;
        private System.Windows.Forms.Label labelLogMonthCount;
        private System.Windows.Forms.Label labelLogMonthValue;
        private System.Windows.Forms.Label labelPushMonthCount;
        private System.Windows.Forms.Label labelPushMonthValue;
    }
}