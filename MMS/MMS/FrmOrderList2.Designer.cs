namespace MMS
{
    partial class FrmOrderList2
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
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.eDate = new System.Windows.Forms.DateTimePicker();
            this.sDate = new System.Windows.Forms.DateTimePicker();
            this.lblSepa = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.cboQuery = new System.Windows.Forms.ComboBox();
            this.chkView = new System.Windows.Forms.CheckBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chkSoldOut = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderGrid
            // 
            this.orderGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col12,
            this.Column2,
            this.Col3,
            this.Col4,
            this.Col5,
            this.Col6,
            this.Col14,
            this.Col7,
            this.Col8,
            this.Col9,
            this.Col10,
            this.Col11,
            this.Col13});
            this.orderGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderGrid.Location = new System.Drawing.Point(0, 64);
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.ReadOnly = true;
            this.orderGrid.RowTemplate.Height = 23;
            this.orderGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderGrid.Size = new System.Drawing.Size(1254, 282);
            this.orderGrid.TabIndex = 3;
            this.orderGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGrid_CellDoubleClick);
            this.orderGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.orderGrid_KeyDown);
            // 
            // Col1
            // 
            this.Col1.HeaderText = "No";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            this.Col1.Width = 32;
            // 
            // Col12
            // 
            this.Col12.HeaderText = "업체명";
            this.Col12.Name = "Col12";
            this.Col12.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "상품명";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 320;
            // 
            // Col3
            // 
            this.Col3.HeaderText = "옵션명";
            this.Col3.Name = "Col3";
            this.Col3.ReadOnly = true;
            this.Col3.Width = 200;
            // 
            // Col4
            // 
            this.Col4.HeaderText = "발주상태";
            this.Col4.Name = "Col4";
            this.Col4.ReadOnly = true;
            // 
            // Col5
            // 
            this.Col5.HeaderText = "중요도";
            this.Col5.Name = "Col5";
            this.Col5.ReadOnly = true;
            // 
            // Col6
            // 
            this.Col6.HeaderText = "비고";
            this.Col6.Name = "Col6";
            this.Col6.ReadOnly = true;
            this.Col6.Width = 240;
            // 
            // Col14
            // 
            this.Col14.HeaderText = "발주수량";
            this.Col14.Name = "Col14";
            this.Col14.ReadOnly = true;
            // 
            // Col7
            // 
            this.Col7.HeaderText = "발주요청일";
            this.Col7.Name = "Col7";
            this.Col7.ReadOnly = true;
            // 
            // Col8
            // 
            this.Col8.HeaderText = "발주요청자";
            this.Col8.Name = "Col8";
            this.Col8.ReadOnly = true;
            // 
            // Col9
            // 
            this.Col9.HeaderText = "발주ID";
            this.Col9.Name = "Col9";
            this.Col9.ReadOnly = true;
            this.Col9.Visible = false;
            // 
            // Col10
            // 
            this.Col10.HeaderText = "상품ID";
            this.Col10.Name = "Col10";
            this.Col10.ReadOnly = true;
            this.Col10.Visible = false;
            // 
            // Col11
            // 
            this.Col11.HeaderText = "옵션ID";
            this.Col11.Name = "Col11";
            this.Col11.ReadOnly = true;
            this.Col11.Visible = false;
            // 
            // Col13
            // 
            this.Col13.HeaderText = "업체ID";
            this.Col13.Name = "Col13";
            this.Col13.ReadOnly = true;
            this.Col13.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(787, 11);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 26);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "신규등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(610, 11);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(74, 26);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(1174, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 26);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // eDate
            // 
            this.eDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.eDate.Location = new System.Drawing.Point(173, 13);
            this.eDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eDate.Name = "eDate";
            this.eDate.Size = new System.Drawing.Size(110, 21);
            this.eDate.TabIndex = 1;
            // 
            // sDate
            // 
            this.sDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sDate.Location = new System.Drawing.Point(48, 13);
            this.sDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sDate.Name = "sDate";
            this.sDate.Size = new System.Drawing.Size(110, 21);
            this.sDate.TabIndex = 1;
            // 
            // lblSepa
            // 
            this.lblSepa.AutoSize = true;
            this.lblSepa.Location = new System.Drawing.Point(158, 18);
            this.lblSepa.Name = "lblSepa";
            this.lblSepa.Size = new System.Drawing.Size(14, 12);
            this.lblSepa.TabIndex = 0;
            this.lblSepa.Text = "~";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(10, 18);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(29, 12);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "날짜";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlTop.Controls.Add(this.txtQuery);
            this.pnlTop.Controls.Add(this.cboQuery);
            this.pnlTop.Controls.Add(this.chkSoldOut);
            this.pnlTop.Controls.Add(this.chkView);
            this.pnlTop.Controls.Add(this.btnExcel);
            this.pnlTop.Controls.Add(this.btnAdd);
            this.pnlTop.Controls.Add(this.btnSelect);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Controls.Add(this.eDate);
            this.pnlTop.Controls.Add(this.sDate);
            this.pnlTop.Controls.Add(this.lblSepa);
            this.pnlTop.Controls.Add(this.lblDate);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1254, 64);
            this.pnlTop.TabIndex = 2;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(390, 13);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(214, 21);
            this.txtQuery.TabIndex = 10;
            // 
            // cboQuery
            // 
            this.cboQuery.FormattingEnabled = true;
            this.cboQuery.Items.AddRange(new object[] {
            "상품명"});
            this.cboQuery.Location = new System.Drawing.Point(298, 13);
            this.cboQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboQuery.Name = "cboQuery";
            this.cboQuery.Size = new System.Drawing.Size(90, 20);
            this.cboQuery.TabIndex = 9;
            // 
            // chkView
            // 
            this.chkView.AutoSize = true;
            this.chkView.Checked = true;
            this.chkView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkView.Location = new System.Drawing.Point(48, 42);
            this.chkView.Name = "chkView";
            this.chkView.Size = new System.Drawing.Size(88, 16);
            this.chkView.TabIndex = 6;
            this.chkView.Text = "발주건 제외";
            this.chkView.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Location = new System.Drawing.Point(1087, 11);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(81, 26);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // chkSoldOut
            // 
            this.chkSoldOut.AutoSize = true;
            this.chkSoldOut.Checked = true;
            this.chkSoldOut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSoldOut.Location = new System.Drawing.Point(173, 42);
            this.chkSoldOut.Name = "chkSoldOut";
            this.chkSoldOut.Size = new System.Drawing.Size(88, 16);
            this.chkSoldOut.TabIndex = 6;
            this.chkSoldOut.Text = "품절건 제외";
            this.chkSoldOut.UseVisualStyleBackColor = true;
            // 
            // FrmOrderList2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 346);
            this.Controls.Add(this.orderGrid);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmOrderList2";
            this.Text = "상품발주::관리자";
            this.Load += new System.EventHandler(this.FrmOrderList2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmOrderList2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView orderGrid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker eDate;
        private System.Windows.Forms.DateTimePicker sDate;
        private System.Windows.Forms.Label lblSepa;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col13;
        private System.Windows.Forms.CheckBox chkView;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ComboBox cboQuery;
        private System.Windows.Forms.CheckBox chkSoldOut;
    }
}