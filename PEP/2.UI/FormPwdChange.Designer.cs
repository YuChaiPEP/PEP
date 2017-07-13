namespace PEP
{
    partial class FormPwdChange
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
            this.panelPwdChange = new System.Windows.Forms.Panel();
            this.labelUname = new System.Windows.Forms.Label();
            this.labelOldPwd = new System.Windows.Forms.Label();
            this.labelNewPwd = new System.Windows.Forms.Label();
            this.labelRepeatedPwd = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textUname = new System.Windows.Forms.TextBox();
            this.textOldPwd = new System.Windows.Forms.TextBox();
            this.textNewPwd = new System.Windows.Forms.TextBox();
            this.textRepeatedPwd = new System.Windows.Forms.TextBox();
            this.panelPwdChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPwdChange
            // 
            this.panelPwdChange.Controls.Add(this.textRepeatedPwd);
            this.panelPwdChange.Controls.Add(this.textNewPwd);
            this.panelPwdChange.Controls.Add(this.textOldPwd);
            this.panelPwdChange.Controls.Add(this.textUname);
            this.panelPwdChange.Controls.Add(this.buttonCancel);
            this.panelPwdChange.Controls.Add(this.buttonSubmit);
            this.panelPwdChange.Controls.Add(this.labelRepeatedPwd);
            this.panelPwdChange.Controls.Add(this.labelNewPwd);
            this.panelPwdChange.Controls.Add(this.labelOldPwd);
            this.panelPwdChange.Controls.Add(this.labelUname);
            this.panelPwdChange.Location = new System.Drawing.Point(13, 13);
            this.panelPwdChange.Name = "panelPwdChange";
            this.panelPwdChange.Size = new System.Drawing.Size(248, 199);
            this.panelPwdChange.TabIndex = 0;
            // 
            // labelUname
            // 
            this.labelUname.AutoSize = true;
            this.labelUname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUname.Location = new System.Drawing.Point(16, 16);
            this.labelUname.Name = "labelUname";
            this.labelUname.Size = new System.Drawing.Size(58, 21);
            this.labelUname.TabIndex = 0;
            this.labelUname.Text = "用户名";
            // 
            // labelOldPwd
            // 
            this.labelOldPwd.AutoSize = true;
            this.labelOldPwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelOldPwd.Location = new System.Drawing.Point(16, 50);
            this.labelOldPwd.Name = "labelOldPwd";
            this.labelOldPwd.Size = new System.Drawing.Size(58, 21);
            this.labelOldPwd.TabIndex = 1;
            this.labelOldPwd.Text = "旧密码";
            // 
            // labelNewPwd
            // 
            this.labelNewPwd.AutoSize = true;
            this.labelNewPwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNewPwd.Location = new System.Drawing.Point(16, 84);
            this.labelNewPwd.Name = "labelNewPwd";
            this.labelNewPwd.Size = new System.Drawing.Size(58, 21);
            this.labelNewPwd.TabIndex = 2;
            this.labelNewPwd.Text = "新密码";
            // 
            // labelRepeatedPwd
            // 
            this.labelRepeatedPwd.AutoSize = true;
            this.labelRepeatedPwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRepeatedPwd.Location = new System.Drawing.Point(16, 118);
            this.labelRepeatedPwd.Name = "labelRepeatedPwd";
            this.labelRepeatedPwd.Size = new System.Drawing.Size(74, 21);
            this.labelRepeatedPwd.TabIndex = 3;
            this.labelRepeatedPwd.Text = "重复密码";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSubmit.Location = new System.Drawing.Point(20, 162);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "修改";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancel.Location = new System.Drawing.Point(137, 162);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textUname
            // 
            this.textUname.Enabled = false;
            this.textUname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textUname.Location = new System.Drawing.Point(124, 16);
            this.textUname.Name = "textUname";
            this.textUname.ReadOnly = true;
            this.textUname.Size = new System.Drawing.Size(87, 23);
            this.textUname.TabIndex = 6;
            // 
            // textOldPwd
            // 
            this.textOldPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textOldPwd.Location = new System.Drawing.Point(124, 51);
            this.textOldPwd.Name = "textOldPwd";
            this.textOldPwd.Size = new System.Drawing.Size(87, 23);
            this.textOldPwd.TabIndex = 7;
            // 
            // textNewPwd
            // 
            this.textNewPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textNewPwd.Location = new System.Drawing.Point(124, 85);
            this.textNewPwd.Name = "textNewPwd";
            this.textNewPwd.Size = new System.Drawing.Size(87, 23);
            this.textNewPwd.TabIndex = 8;
            // 
            // textRepeatedPwd
            // 
            this.textRepeatedPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textRepeatedPwd.Location = new System.Drawing.Point(124, 118);
            this.textRepeatedPwd.Name = "textRepeatedPwd";
            this.textRepeatedPwd.Size = new System.Drawing.Size(87, 23);
            this.textRepeatedPwd.TabIndex = 9;
            // 
            // FormPwdChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 221);
            this.Controls.Add(this.panelPwdChange);
            this.Name = "FormPwdChange";
            this.Text = "修改密码";
            this.panelPwdChange.ResumeLayout(false);
            this.panelPwdChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPwdChange;
        private System.Windows.Forms.Label labelUname;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelRepeatedPwd;
        private System.Windows.Forms.Label labelNewPwd;
        private System.Windows.Forms.Label labelOldPwd;
        private System.Windows.Forms.TextBox textUname;
        private System.Windows.Forms.TextBox textRepeatedPwd;
        private System.Windows.Forms.TextBox textNewPwd;
        private System.Windows.Forms.TextBox textOldPwd;
    }
}