namespace MMS
{
    partial class FrmOrderDetail
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
            this.cboOption = new System.Windows.Forms.ComboBox();
            this.txtPSEQ = new System.Windows.Forms.TextBox();
            this.pImage = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboStep = new System.Windows.Forms.ComboBox();
            this.txtETC = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblEtc = new System.Windows.Forms.Label();
            this.lblEmergency = new System.Windows.Forms.Label();
            this.lblOption = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSEQ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cboOption
            // 
            this.cboOption.FormattingEnabled = true;
            this.cboOption.Location = new System.Drawing.Point(374, 35);
            this.cboOption.Name = "cboOption";
            this.cboOption.Size = new System.Drawing.Size(240, 20);
            this.cboOption.TabIndex = 8;
            // 
            // txtPSEQ
            // 
            this.txtPSEQ.Location = new System.Drawing.Point(7, 205);
            this.txtPSEQ.Name = "txtPSEQ";
            this.txtPSEQ.Size = new System.Drawing.Size(43, 21);
            this.txtPSEQ.TabIndex = 7;
            this.txtPSEQ.Visible = false;
            // 
            // pImage
            // 
            this.pImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pImage.Location = new System.Drawing.Point(56, 12);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(245, 214);
            this.pImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImage.TabIndex = 6;
            this.pImage.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(374, 242);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 26);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(214, 242);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 26);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboStep
            // 
            this.cboStep.FormattingEnabled = true;
            this.cboStep.Location = new System.Drawing.Point(374, 59);
            this.cboStep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboStep.Name = "cboStep";
            this.cboStep.Size = new System.Drawing.Size(106, 20);
            this.cboStep.TabIndex = 4;
            // 
            // txtETC
            // 
            this.txtETC.Location = new System.Drawing.Point(374, 82);
            this.txtETC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtETC.Multiline = true;
            this.txtETC.Name = "txtETC";
            this.txtETC.Size = new System.Drawing.Size(240, 144);
            this.txtETC.TabIndex = 3;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(374, 9);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(240, 21);
            this.txtTitle.TabIndex = 1;
            // 
            // lblEtc
            // 
            this.lblEtc.AutoSize = true;
            this.lblEtc.Location = new System.Drawing.Point(339, 85);
            this.lblEtc.Name = "lblEtc";
            this.lblEtc.Size = new System.Drawing.Size(29, 12);
            this.lblEtc.TabIndex = 0;
            this.lblEtc.Text = "비고";
            // 
            // lblEmergency
            // 
            this.lblEmergency.AutoSize = true;
            this.lblEmergency.Location = new System.Drawing.Point(323, 61);
            this.lblEmergency.Name = "lblEmergency";
            this.lblEmergency.Size = new System.Drawing.Size(41, 12);
            this.lblEmergency.TabIndex = 0;
            this.lblEmergency.Text = "긴급도";
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Location = new System.Drawing.Point(323, 37);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(41, 12);
            this.lblOption.TabIndex = 0;
            this.lblOption.Text = "옵션명";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(5, 12);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(41, 12);
            this.lblImage.TabIndex = 0;
            this.lblImage.Text = "상품명";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(323, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 12);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "상품명";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(294, 242);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 26);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSEQ
            // 
            this.txtSEQ.Location = new System.Drawing.Point(7, 178);
            this.txtSEQ.Name = "txtSEQ";
            this.txtSEQ.Size = new System.Drawing.Size(43, 21);
            this.txtSEQ.TabIndex = 9;
            this.txtSEQ.Visible = false;
            // 
            // FrmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 279);
            this.Controls.Add(this.txtSEQ);
            this.Controls.Add(this.lblEtc);
            this.Controls.Add(this.cboOption);
            this.Controls.Add(this.pImage);
            this.Controls.Add(this.txtPSEQ);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblOption);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEmergency);
            this.Controls.Add(this.cboStep);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtETC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "상품상세정보";
            this.Load += new System.EventHandler(this.FrmItemDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboOption;
        private System.Windows.Forms.TextBox txtPSEQ;
        private System.Windows.Forms.PictureBox pImage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboStep;
        private System.Windows.Forms.TextBox txtETC;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblEtc;
        private System.Windows.Forms.Label lblEmergency;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSEQ;
    }
}