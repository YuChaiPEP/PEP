namespace PEP
{
    partial class FormPushSend
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
            this.textPushEdit = new CCWin.SkinControl.SkinTextBox();
            this.buttonPushSubmit = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // textPushEdit
            // 
            this.textPushEdit.BackColor = System.Drawing.Color.Transparent;
            this.textPushEdit.DownBack = null;
            this.textPushEdit.Icon = null;
            this.textPushEdit.IconIsButton = false;
            this.textPushEdit.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textPushEdit.IsPasswordChat = '\0';
            this.textPushEdit.IsSystemPasswordChar = false;
            this.textPushEdit.Lines = new string[0];
            this.textPushEdit.Location = new System.Drawing.Point(4, 28);
            this.textPushEdit.Margin = new System.Windows.Forms.Padding(0);
            this.textPushEdit.MaxLength = 32767;
            this.textPushEdit.MinimumSize = new System.Drawing.Size(28, 28);
            this.textPushEdit.MouseBack = null;
            this.textPushEdit.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textPushEdit.Multiline = true;
            this.textPushEdit.Name = "textPushEdit";
            this.textPushEdit.NormlBack = null;
            this.textPushEdit.Padding = new System.Windows.Forms.Padding(5);
            this.textPushEdit.ReadOnly = false;
            this.textPushEdit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textPushEdit.Size = new System.Drawing.Size(276, 194);
            // 
            // 
            // 
            this.textPushEdit.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.textPushEdit.SkinTxt.Multiline = true;
            this.textPushEdit.SkinTxt.Name = "BaseText";
            this.textPushEdit.SkinTxt.Size = new System.Drawing.Size(100, 18);
            this.textPushEdit.SkinTxt.TabIndex = 0;
            this.textPushEdit.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textPushEdit.SkinTxt.WaterText = "";
            this.textPushEdit.TabIndex = 0;
            this.textPushEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textPushEdit.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textPushEdit.WaterText = "";
            this.textPushEdit.WordWrap = true;
            // 
            // buttonPushSubmit
            // 
            this.buttonPushSubmit.BackColor = System.Drawing.Color.Transparent;
            this.buttonPushSubmit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonPushSubmit.DownBack = null;
            this.buttonPushSubmit.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPushSubmit.Location = new System.Drawing.Point(91, 229);
            this.buttonPushSubmit.MouseBack = null;
            this.buttonPushSubmit.Name = "buttonPushSubmit";
            this.buttonPushSubmit.NormlBack = null;
            this.buttonPushSubmit.Size = new System.Drawing.Size(103, 23);
            this.buttonPushSubmit.TabIndex = 1;
            this.buttonPushSubmit.Text = "提交";
            this.buttonPushSubmit.UseVisualStyleBackColor = true;
            this.buttonPushSubmit.Click += new System.EventHandler(this.buttonPushSubmit_Click);
            // 
            // FormPushSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonPushSubmit);
            this.Controls.Add(this.textPushEdit);
            this.Name = "FormPushSend";
            this.Text = "我要推送";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox textPushEdit;
        private CCWin.SkinControl.SkinButton buttonPushSubmit;
    }
}