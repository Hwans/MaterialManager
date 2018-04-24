namespace MMS
{
    partial class FrmImage
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
            this.bigImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bigImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bigImage
            // 
            this.bigImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bigImage.Location = new System.Drawing.Point(0, 0);
            this.bigImage.Name = "bigImage";
            this.bigImage.Size = new System.Drawing.Size(500, 500);
            this.bigImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bigImage.TabIndex = 0;
            this.bigImage.TabStop = false;
            this.bigImage.Click += new System.EventHandler(this.bigImage_Click);
            // 
            // FrmImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.bigImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "미리보기";
            this.Load += new System.EventHandler(this.FrmImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bigImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bigImage;
    }
}