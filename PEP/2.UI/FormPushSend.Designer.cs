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
            this.textPushEdit = new System.Windows.Forms.TextBox();
            this.buttonPushSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textPushEdit
            // 
            this.textPushEdit.Location = new System.Drawing.Point(2, 2);
            this.textPushEdit.Multiline = true;
            this.textPushEdit.Name = "textPushEdit";
            this.textPushEdit.Size = new System.Drawing.Size(280, 220);
            this.textPushEdit.TabIndex = 0;
            // 
            // buttonPushSubmit
            // 
            this.buttonPushSubmit.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPushSubmit.Location = new System.Drawing.Point(91, 229);
            this.buttonPushSubmit.Name = "buttonPushSubmit";
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPushEdit;
        private System.Windows.Forms.Button buttonPushSubmit;
    }
}