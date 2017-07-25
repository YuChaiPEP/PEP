namespace PEP
{
    partial class FormShowImage
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
            this.pictureBox = new CCWin.SkinControl.SkinPictureBox();
            this.buttonSaveImage = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(7, 31);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 500);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.BackColor = System.Drawing.Color.Transparent;
            this.buttonSaveImage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.buttonSaveImage.DownBack = null;
            this.buttonSaveImage.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSaveImage.Location = new System.Drawing.Point(514, 106);
            this.buttonSaveImage.MouseBack = null;
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.NormlBack = null;
            this.buttonSaveImage.Size = new System.Drawing.Size(91, 35);
            this.buttonSaveImage.TabIndex = 1;
            this.buttonSaveImage.Text = "保存图片";
            this.buttonSaveImage.UseVisualStyleBackColor = false;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // FormShowImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = global::PEP.Properties.Resources.main_8;
            this.ClientSize = new System.Drawing.Size(612, 539);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.pictureBox);
            this.Name = "FormShowImage";
            this.Text = "任务流程图";
            this.Load += new System.EventHandler(this.FormShowImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPictureBox pictureBox;
        private CCWin.SkinControl.SkinButton buttonSaveImage;
    }
}