namespace MMS
{
    partial class FrmCompanyList
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtBizName = new System.Windows.Forms.TextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.cboQuery = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.companyGrid = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBizNo = new System.Windows.Forms.TextBox();
            this.lblBizName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBizNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHomepage = new System.Windows.Forms.TextBox();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtBankNumber = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.lblHomepage = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.lblBankNumber = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSEQ
            // 
            this.txtSEQ.Location = new System.Drawing.Point(48, 321);
            this.txtSEQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSEQ.Name = "txtSEQ";
            this.txtSEQ.Size = new System.Drawing.Size(58, 25);
            this.txtSEQ.TabIndex = 18;
            this.txtSEQ.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Location = new System.Drawing.Point(295, 315);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Location = new System.Drawing.Point(203, 315);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 32);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.DimGray;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(713, 56);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 570);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Location = new System.Drawing.Point(113, 315);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 32);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMobile.Location = new System.Drawing.Point(94, 142);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(325, 25);
            this.txtMobile.TabIndex = 9;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel.Location = new System.Drawing.Point(94, 111);
            this.txtTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(325, 25);
            this.txtTel.TabIndex = 9;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(13, 146);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(82, 15);
            this.lblMobile.TabIndex = 8;
            this.lblMobile.Text = "핸드폰번호";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(94, 80);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(325, 25);
            this.txtName.TabIndex = 9;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(13, 115);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 15);
            this.lblTel.TabIndex = 8;
            this.lblTel.Text = "연락처";
            // 
            // txtBizName
            // 
            this.txtBizName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBizName.Location = new System.Drawing.Point(94, 18);
            this.txtBizName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBizName.Name = "txtBizName";
            this.txtBizName.Size = new System.Drawing.Size(325, 25);
            this.txtBizName.TabIndex = 9;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlTop.Controls.Add(this.txtQuery);
            this.pnlTop.Controls.Add(this.cboQuery);
            this.pnlTop.Controls.Add(this.btnSelect);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1152, 56);
            this.pnlTop.TabIndex = 6;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(120, 18);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(244, 25);
            this.txtQuery.TabIndex = 6;
            this.txtQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuery_KeyDown);
            // 
            // cboQuery
            // 
            this.cboQuery.FormattingEnabled = true;
            this.cboQuery.Items.AddRange(new object[] {
            "상품명"});
            this.cboQuery.Location = new System.Drawing.Point(11, 18);
            this.cboQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboQuery.Name = "cboQuery";
            this.cboQuery.Size = new System.Drawing.Size(102, 23);
            this.cboQuery.TabIndex = 5;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(371, 14);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(85, 32);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(1059, 14);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // companyGrid
            // 
            this.companyGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.companyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3,
            this.Col4,
            this.Col5,
            this.Col6,
            this.Col7,
            this.Col8});
            this.companyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyGrid.Location = new System.Drawing.Point(0, 56);
            this.companyGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.companyGrid.Name = "companyGrid";
            this.companyGrid.ReadOnly = true;
            this.companyGrid.RowTemplate.Height = 23;
            this.companyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.companyGrid.Size = new System.Drawing.Size(719, 570);
            this.companyGrid.TabIndex = 7;
            this.companyGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.companyGrid_CellClick);
            // 
            // Col1
            // 
            this.Col1.HeaderText = "No";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            this.Col1.Width = 32;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "거래처명";
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            this.Col2.Width = 240;
            // 
            // Col3
            // 
            this.Col3.HeaderText = "사업자번호";
            this.Col3.Name = "Col3";
            this.Col3.ReadOnly = true;
            this.Col3.Width = 120;
            // 
            // Col4
            // 
            this.Col4.HeaderText = "담당자";
            this.Col4.Name = "Col4";
            this.Col4.ReadOnly = true;
            this.Col4.Width = 120;
            // 
            // Col5
            // 
            this.Col5.HeaderText = "연락처";
            this.Col5.Name = "Col5";
            this.Col5.ReadOnly = true;
            this.Col5.Width = 120;
            // 
            // Col6
            // 
            this.Col6.HeaderText = "핸드폰번호";
            this.Col6.Name = "Col6";
            this.Col6.ReadOnly = true;
            // 
            // Col7
            // 
            this.Col7.HeaderText = "홈페이지";
            this.Col7.Name = "Col7";
            this.Col7.ReadOnly = true;
            this.Col7.Visible = false;
            this.Col7.Width = 160;
            // 
            // Col8
            // 
            this.Col8.HeaderText = "SEQ";
            this.Col8.Name = "Col8";
            this.Col8.ReadOnly = true;
            this.Col8.Visible = false;
            // 
            // txtBizNo
            // 
            this.txtBizNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBizNo.Location = new System.Drawing.Point(94, 49);
            this.txtBizNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBizNo.Name = "txtBizNo";
            this.txtBizNo.Size = new System.Drawing.Size(325, 25);
            this.txtBizNo.TabIndex = 9;
            // 
            // lblBizName
            // 
            this.lblBizName.AutoSize = true;
            this.lblBizName.Location = new System.Drawing.Point(13, 21);
            this.lblBizName.Name = "lblBizName";
            this.lblBizName.Size = new System.Drawing.Size(67, 15);
            this.lblBizName.TabIndex = 8;
            this.lblBizName.Text = "거래처명";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 15);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "담당자";
            // 
            // lblBizNo
            // 
            this.lblBizNo.AutoSize = true;
            this.lblBizNo.Location = new System.Drawing.Point(13, 52);
            this.lblBizNo.Name = "lblBizNo";
            this.lblBizNo.Size = new System.Drawing.Size(82, 15);
            this.lblBizNo.TabIndex = 8;
            this.lblBizNo.Text = "사업자번호";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSEQ);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.lblBizNo);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblBizName);
            this.panel1.Controls.Add(this.txtBizNo);
            this.panel1.Controls.Add(this.txtHomepage);
            this.panel1.Controls.Add(this.txtBankName);
            this.panel1.Controls.Add(this.txtBankNumber);
            this.panel1.Controls.Add(this.txtBank);
            this.panel1.Controls.Add(this.lblHomepage);
            this.panel1.Controls.Add(this.txtMobile);
            this.panel1.Controls.Add(this.lblBankName);
            this.panel1.Controls.Add(this.txtBizName);
            this.panel1.Controls.Add(this.lblBankNumber);
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(this.lblBank);
            this.panel1.Controls.Add(this.lblTel);
            this.panel1.Controls.Add(this.lblMobile);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(719, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 570);
            this.panel1.TabIndex = 8;
            // 
            // txtHomepage
            // 
            this.txtHomepage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHomepage.Location = new System.Drawing.Point(94, 268);
            this.txtHomepage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHomepage.Name = "txtHomepage";
            this.txtHomepage.Size = new System.Drawing.Size(325, 25);
            this.txtHomepage.TabIndex = 9;
            // 
            // txtBankName
            // 
            this.txtBankName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankName.Location = new System.Drawing.Point(94, 236);
            this.txtBankName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(325, 25);
            this.txtBankName.TabIndex = 9;
            // 
            // txtBankNumber
            // 
            this.txtBankNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankNumber.Location = new System.Drawing.Point(94, 205);
            this.txtBankNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBankNumber.Name = "txtBankNumber";
            this.txtBankNumber.Size = new System.Drawing.Size(325, 25);
            this.txtBankNumber.TabIndex = 9;
            // 
            // txtBank
            // 
            this.txtBank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBank.Location = new System.Drawing.Point(94, 174);
            this.txtBank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(325, 25);
            this.txtBank.TabIndex = 9;
            // 
            // lblHomepage
            // 
            this.lblHomepage.AutoSize = true;
            this.lblHomepage.Location = new System.Drawing.Point(13, 271);
            this.lblHomepage.Name = "lblHomepage";
            this.lblHomepage.Size = new System.Drawing.Size(67, 15);
            this.lblHomepage.TabIndex = 8;
            this.lblHomepage.Text = "홈페이지";
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Location = new System.Drawing.Point(13, 240);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(52, 15);
            this.lblBankName.TabIndex = 8;
            this.lblBankName.Text = "예금주";
            // 
            // lblBankNumber
            // 
            this.lblBankNumber.AutoSize = true;
            this.lblBankNumber.Location = new System.Drawing.Point(13, 209);
            this.lblBankNumber.Name = "lblBankNumber";
            this.lblBankNumber.Size = new System.Drawing.Size(67, 15);
            this.lblBankNumber.TabIndex = 8;
            this.lblBankNumber.Text = "계좌번호";
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(13, 178);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(67, 15);
            this.lblBank.TabIndex = 8;
            this.lblBank.Text = "거래은행";
            // 
            // FrmCompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 626);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.companyGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCompanyList";
            this.Text = "거래처관리";
            this.Load += new System.EventHandler(this.FrmCompany_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSEQ;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtBizName;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ComboBox cboQuery;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView companyGrid;
        private System.Windows.Forms.TextBox txtBizNo;
        private System.Windows.Forms.Label lblBizName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBizNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHomepage;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.TextBox txtBankNumber;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label lblHomepage;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblBankNumber;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col8;
    }
}