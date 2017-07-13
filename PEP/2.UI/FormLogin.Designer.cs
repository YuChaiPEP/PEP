﻿namespace PEP
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
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textUser = new CCWin.SkinControl.SkinTextBox();
            this.textPwd = new CCWin.SkinControl.SkinTextBox();
            this.buttonLogin = new CCWin.SkinControl.SkinButton();
            this.buttonCancel = new CCWin.SkinControl.SkinButton();
            this.checkBoxSavePwd = new CCWin.SkinControl.SkinCheckBox();
            this.checkBoxAutoLogin = new CCWin.SkinControl.SkinCheckBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("华文楷体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(121, 44);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(204, 53);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "PEP登录";
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.Color.Transparent;
            this.textUser.DownBack = null;
            this.textUser.Icon = null;
            this.textUser.IconIsButton = false;
            this.textUser.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textUser.IsPasswordChat = '\0';
            this.textUser.IsSystemPasswordChar = false;
            this.textUser.Lines = new string[0];
            this.textUser.Location = new System.Drawing.Point(121, 122);
            this.textUser.Margin = new System.Windows.Forms.Padding(0);
            this.textUser.MaxLength = 32767;
            this.textUser.MinimumSize = new System.Drawing.Size(28, 28);
            this.textUser.MouseBack = null;
            this.textUser.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textUser.Multiline = false;
            this.textUser.Name = "textUser";
            this.textUser.NormlBack = null;
            this.textUser.Padding = new System.Windows.Forms.Padding(5);
            this.textUser.ReadOnly = false;
            this.textUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textUser.Size = new System.Drawing.Size(204, 28);
            // 
            // 
            // 
            this.textUser.SkinTxt.Font = new System.Drawing.Font("宋体", 12F);
            this.textUser.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.textUser.SkinTxt.Name = "BaseText";
            this.textUser.SkinTxt.TabIndex = 0;
            this.textUser.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textUser.SkinTxt.WaterText = "用户名";
            this.textUser.TabIndex = 9;
            this.textUser.TabStop = true;
            this.textUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textUser.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textUser.WaterText = "用户名";
            this.textUser.WordWrap = true;
            // 
            // textPwd
            // 
            this.textPwd.BackColor = System.Drawing.Color.Transparent;
            this.textPwd.DownBack = null;
            this.textPwd.Icon = null;
            this.textPwd.IconIsButton = false;
            this.textPwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textPwd.IsPasswordChat = '\0';
            this.textPwd.IsSystemPasswordChar = false;
            this.textPwd.Lines = new string[0];
            this.textPwd.Location = new System.Drawing.Point(121, 150);
            this.textPwd.Margin = new System.Windows.Forms.Padding(0);
            this.textPwd.MaxLength = 32767;
            this.textPwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.textPwd.MouseBack = null;
            this.textPwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textPwd.Multiline = false;
            this.textPwd.Name = "textPwd";
            this.textPwd.NormlBack = null;
            this.textPwd.Padding = new System.Windows.Forms.Padding(5);
            this.textPwd.ReadOnly = false;
            this.textPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textPwd.Size = new System.Drawing.Size(204, 28);
            // 
            // 
            // 
            this.textPwd.SkinTxt.Font = new System.Drawing.Font("宋体", 12F);
            this.textPwd.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.textPwd.SkinTxt.Name = "BaseText";
            this.textPwd.SkinTxt.TabIndex = 0;
            this.textPwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textPwd.SkinTxt.WaterText = "密码";
            this.textPwd.TabIndex = 10;
            this.textPwd.TabStop = true;
            this.textPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textPwd.WaterText = "密码";
            this.textPwd.WordWrap = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonLogin.DownBack = null;
            this.buttonLogin.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLogin.Location = new System.Drawing.Point(121, 230);
            this.buttonLogin.MouseBack = null;
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.NormlBack = null;
            this.buttonLogin.Size = new System.Drawing.Size(90, 30);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "登  录";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonCancel.DownBack = null;
            this.buttonCancel.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancel.Location = new System.Drawing.Point(235, 230);
            this.buttonCancel.MouseBack = null;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.NormlBack = null;
            this.buttonCancel.Size = new System.Drawing.Size(90, 30);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "取  消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxSavePwd
            // 
            this.checkBoxSavePwd.AutoSize = true;
            this.checkBoxSavePwd.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSavePwd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.checkBoxSavePwd.DownBack = null;
            this.checkBoxSavePwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxSavePwd.Location = new System.Drawing.Point(121, 190);
            this.checkBoxSavePwd.MouseBack = null;
            this.checkBoxSavePwd.Name = "checkBoxSavePwd";
            this.checkBoxSavePwd.NormlBack = null;
            this.checkBoxSavePwd.SelectedDownBack = null;
            this.checkBoxSavePwd.SelectedMouseBack = null;
            this.checkBoxSavePwd.SelectedNormlBack = null;
            this.checkBoxSavePwd.Size = new System.Drawing.Size(75, 21);
            this.checkBoxSavePwd.TabIndex = 11;
            this.checkBoxSavePwd.Text = "记住密码";
            this.checkBoxSavePwd.UseVisualStyleBackColor = false;
            // 
            // checkBoxAutoLogin
            // 
            this.checkBoxAutoLogin.AutoSize = true;
            this.checkBoxAutoLogin.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAutoLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.checkBoxAutoLogin.DownBack = null;
            this.checkBoxAutoLogin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxAutoLogin.Location = new System.Drawing.Point(250, 190);
            this.checkBoxAutoLogin.MouseBack = null;
            this.checkBoxAutoLogin.Name = "checkBoxAutoLogin";
            this.checkBoxAutoLogin.NormlBack = null;
            this.checkBoxAutoLogin.SelectedDownBack = null;
            this.checkBoxAutoLogin.SelectedMouseBack = null;
            this.checkBoxAutoLogin.SelectedNormlBack = null;
            this.checkBoxAutoLogin.Size = new System.Drawing.Size(75, 21);
            this.checkBoxAutoLogin.TabIndex = 12;
            this.checkBoxAutoLogin.Text = "自动登录";
            this.checkBoxAutoLogin.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::PEP.Properties.Resources.main_8;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(459, 318);
            this.Controls.Add(this.checkBoxAutoLogin);
            this.Controls.Add(this.checkBoxSavePwd);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.textPwd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelTitle);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private CCWin.SkinControl.SkinTextBox textUser;
        private CCWin.SkinControl.SkinTextBox textPwd;
        private CCWin.SkinControl.SkinButton buttonLogin;
        private CCWin.SkinControl.SkinButton buttonCancel;
        private CCWin.SkinControl.SkinCheckBox checkBoxSavePwd;
        private CCWin.SkinControl.SkinCheckBox checkBoxAutoLogin;
    }
}

