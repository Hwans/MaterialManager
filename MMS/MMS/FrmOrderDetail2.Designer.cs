namespace MMS
{
    partial class FrmOrderDetail2
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
            this.txtSEQ = new System.Windows.Forms.TextBox();
            this.lblEtc = new System.Windows.Forms.Label();
            this.cboOption = new System.Windows.Forms.ComboBox();
            this.pImage = new System.Windows.Forms.PictureBox();
            this.txtPSEQ = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblOption = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEmergency = new System.Windows.Forms.Label();
            this.cboStep = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtETC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEtc2 = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtEtc2 = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSEQ
            // 
            this.txtSEQ.Location = new System.Drawing.Point(7, 178);
            this.txtSEQ.Name = "txtSEQ";
            this.txtSEQ.Size = new System.Drawing.Size(43, 21);
            this.txtSEQ.TabIndex = 24;
            this.txtSEQ.Visible = false;
            // 
            // lblEtc
            // 
            this.lblEtc.AutoSize = true;
            this.lblEtc.Location = new System.Drawing.Point(339, 85);
            this.lblEtc.Name = "lblEtc";
            this.lblEtc.Size = new System.Drawing.Size(29, 12);
            this.lblEtc.TabIndex = 10;
            this.lblEtc.Text = "비고";
            // 
            // cboOption
            // 
            this.cboOption.FormattingEnabled = true;
            this.cboOption.Location = new System.Drawing.Point(374, 35);
            this.cboOption.Name = "cboOption";
            this.cboOption.Size = new System.Drawing.Size(240, 20);
            this.cboOption.TabIndex = 23;
            // 
            // pImage
            // 
            this.pImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pImage.Location = new System.Drawing.Point(56, 12);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(245, 214);
            this.pImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImage.TabIndex = 21;
            this.pImage.TabStop = false;
            // 
            // txtPSEQ
            // 
            this.txtPSEQ.Location = new System.Drawing.Point(7, 205);
            this.txtPSEQ.Name = "txtPSEQ";
            this.txtPSEQ.Size = new System.Drawing.Size(43, 21);
            this.txtPSEQ.TabIndex = 22;
            this.txtPSEQ.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(323, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 12);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "상품명";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(5, 12);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(41, 12);
            this.lblImage.TabIndex = 12;
            this.lblImage.Text = "상품명";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(314, 355);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 26);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Location = new System.Drawing.Point(323, 37);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(41, 12);
            this.lblOption.TabIndex = 13;
            this.lblOption.Text = "옵션명";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(234, 355);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 26);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblEmergency
            // 
            this.lblEmergency.AutoSize = true;
            this.lblEmergency.Location = new System.Drawing.Point(323, 61);
            this.lblEmergency.Name = "lblEmergency";
            this.lblEmergency.Size = new System.Drawing.Size(41, 12);
            this.lblEmergency.TabIndex = 14;
            this.lblEmergency.Text = "긴급도";
            // 
            // cboStep
            // 
            this.cboStep.FormattingEnabled = true;
            this.cboStep.Location = new System.Drawing.Point(374, 59);
            this.cboStep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboStep.Name = "cboStep";
            this.cboStep.Size = new System.Drawing.Size(106, 20);
            this.cboStep.TabIndex = 17;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(374, 9);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(240, 21);
            this.txtTitle.TabIndex = 15;
            // 
            // txtETC
            // 
            this.txtETC.Location = new System.Drawing.Point(374, 82);
            this.txtETC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtETC.Multiline = true;
            this.txtETC.Name = "txtETC";
            this.txtETC.Size = new System.Drawing.Size(240, 144);
            this.txtETC.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEtc2);
            this.groupBox1.Controls.Add(this.lblQty);
            this.groupBox1.Controls.Add(this.txtEtc2);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Location = new System.Drawing.Point(7, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 100);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "발주정보";
            // 
            // lblEtc2
            // 
            this.lblEtc2.AutoSize = true;
            this.lblEtc2.Location = new System.Drawing.Point(307, 22);
            this.lblEtc2.Name = "lblEtc2";
            this.lblEtc2.Size = new System.Drawing.Size(53, 12);
            this.lblEtc2.TabIndex = 16;
            this.lblEtc2.Text = "특이사항";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(3, 22);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(53, 12);
            this.lblQty.TabIndex = 17;
            this.lblQty.Text = "주문수량";
            // 
            // txtEtc2
            // 
            this.txtEtc2.Location = new System.Drawing.Point(366, 19);
            this.txtEtc2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEtc2.Multiline = true;
            this.txtEtc2.Name = "txtEtc2";
            this.txtEtc2.Size = new System.Drawing.Size(240, 70);
            this.txtEtc2.TabIndex = 18;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(62, 19);
            this.txtQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(232, 21);
            this.txtQty.TabIndex = 19;
            // 
            // FrmOrderDetail2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSEQ);
            this.Controls.Add(this.lblEtc);
            this.Controls.Add(this.cboOption);
            this.Controls.Add(this.pImage);
            this.Controls.Add(this.txtPSEQ);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblOption);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEmergency);
            this.Controls.Add(this.cboStep);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtETC);
            this.Name = "FrmOrderDetail2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "상품상세정보::관리자";
            this.Load += new System.EventHandler(this.FrmOrderDetail2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSEQ;
        private System.Windows.Forms.Label lblEtc;
        private System.Windows.Forms.ComboBox cboOption;
        private System.Windows.Forms.PictureBox pImage;
        private System.Windows.Forms.TextBox txtPSEQ;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEmergency;
        private System.Windows.Forms.ComboBox cboStep;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtETC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEtc2;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtEtc2;
        private System.Windows.Forms.TextBox txtQty;
    }
}