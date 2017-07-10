namespace PEP
{
    partial class FormLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.labelPwd = new System.Windows.Forms.Label();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.panelInput = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("华文楷体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(262, 63);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(204, 53);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "PEP登录";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.labelUser.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUser.Location = new System.Drawing.Point(14, 23);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(58, 21);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "用户名";
            // 
            // textUser
            // 
            this.textUser.Font = new System.Drawing.Font("宋体", 12F);
            this.textUser.Location = new System.Drawing.Point(107, 23);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(115, 26);
            this.textUser.TabIndex = 8;
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPwd.Location = new System.Drawing.Point(18, 67);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(42, 21);
            this.labelPwd.TabIndex = 9;
            this.labelPwd.Text = "密码";
            // 
            // textPwd
            // 
            this.textPwd.Font = new System.Drawing.Font("宋体", 12F);
            this.textPwd.Location = new System.Drawing.Point(107, 66);
            this.textPwd.Name = "textPwd";
            this.textPwd.Size = new System.Drawing.Size(115, 26);
            this.textPwd.TabIndex = 10;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.textPwd);
            this.panelInput.Controls.Add(this.labelUser);
            this.panelInput.Controls.Add(this.labelPwd);
            this.panelInput.Controls.Add(this.textUser);
            this.panelInput.Location = new System.Drawing.Point(239, 147);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(240, 121);
            this.panelInput.TabIndex = 11;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLogin.Location = new System.Drawing.Point(239, 296);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(90, 23);
            this.buttonLogin.TabIndex = 12;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancel.Location = new System.Drawing.Point(393, 296);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(86, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 442);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormLogin";
            this.Text = "登录";
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCancel;
    }
}

