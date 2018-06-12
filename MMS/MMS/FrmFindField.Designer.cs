namespace MMS
{
    partial class FrmFindField
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
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.btnSearh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(5, 13);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(284, 21);
            this.txtSearchText.TabIndex = 0;
            this.txtSearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchText_KeyDown);
            // 
            // btnSearh
            // 
            this.btnSearh.Location = new System.Drawing.Point(293, 13);
            this.btnSearh.Name = "btnSearh";
            this.btnSearh.Size = new System.Drawing.Size(57, 23);
            this.btnSearh.TabIndex = 1;
            this.btnSearh.Text = "검색";
            this.btnSearh.UseVisualStyleBackColor = true;
            this.btnSearh.Click += new System.EventHandler(this.btnSearh_Click);
            // 
            // FrmFindField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 46);
            this.ControlBox = false;
            this.Controls.Add(this.btnSearh);
            this.Controls.Add(this.txtSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmFindField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "찾기";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFindField_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Button btnSearh;
    }
}