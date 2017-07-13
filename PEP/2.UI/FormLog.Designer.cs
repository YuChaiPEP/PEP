namespace PEP
{
    partial class FormLog
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
            this.textBoxLog = new CCWin.SkinControl.SkinTextBox();
            this.buttonCheck = new CCWin.SkinControl.SkinButton();
            this.buttonCancel = new CCWin.SkinControl.SkinButton();
            this.buttonConfirm = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.Color.Transparent;
            this.textBoxLog.DownBack = null;
            this.textBoxLog.Icon = null;
            this.textBoxLog.IconIsButton = false;
            this.textBoxLog.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxLog.IsPasswordChat = '\0';
            this.textBoxLog.IsSystemPasswordChar = false;
            this.textBoxLog.Lines = new string[0];
            this.textBoxLog.Location = new System.Drawing.Point(22, 43);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLog.MaxLength = 32767;
            this.textBoxLog.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxLog.MouseBack = null;
            this.textBoxLog.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.NormlBack = null;
            this.textBoxLog.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(291, 367);
            // 
            // 
            // 
            this.textBoxLog.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLog.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxLog.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxLog.SkinTxt.Multiline = true;
            this.textBoxLog.SkinTxt.Name = "BaseText";
            this.textBoxLog.SkinTxt.ReadOnly = true;
            this.textBoxLog.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.SkinTxt.Size = new System.Drawing.Size(281, 357);
            this.textBoxLog.SkinTxt.TabIndex = 0;
            this.textBoxLog.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxLog.SkinTxt.WaterText = "";
            this.textBoxLog.TabIndex = 3;
            this.textBoxLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxLog.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxLog.WaterText = "";
            this.textBoxLog.WordWrap = true;
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheck.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonCheck.DownBack = null;
            this.buttonCheck.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCheck.Location = new System.Drawing.Point(334, 66);
            this.buttonCheck.MouseBack = null;
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.NormlBack = null;
            this.buttonCheck.Size = new System.Drawing.Size(91, 35);
            this.buttonCheck.TabIndex = 0;
            this.buttonCheck.Text = "批  阅";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonCancel.DownBack = null;
            this.buttonCancel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancel.Location = new System.Drawing.Point(334, 146);
            this.buttonCancel.MouseBack = null;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.NormlBack = null;
            this.buttonCancel.Size = new System.Drawing.Size(91, 35);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "取  消";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonConfirm.DownBack = null;
            this.buttonConfirm.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonConfirm.Location = new System.Drawing.Point(334, 66);
            this.buttonConfirm.MouseBack = null;
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.NormlBack = null;
            this.buttonConfirm.Size = new System.Drawing.Size(91, 35);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "确  认";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // FormLog
            // 
            this.AcceptButton = this.buttonCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = global::PEP.Properties.Resources.main_8;
            this.ClientSize = new System.Drawing.Size(446, 440);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonCheck);
            this.Name = "FormLog";
            this.ShowDrawIcon = false;
            this.Text = "批阅日志";
            this.Load += new System.EventHandler(this.FormLog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox textBoxLog;
        private CCWin.SkinControl.SkinButton buttonCheck;
        private CCWin.SkinControl.SkinButton buttonCancel;
        private CCWin.SkinControl.SkinButton buttonConfirm;
    }
}