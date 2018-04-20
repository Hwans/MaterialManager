namespace MMS
{
    partial class FrmProductList
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.cboQuery = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.itemGrid = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pImage = new System.Windows.Forms.PictureBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cboOption = new System.Windows.Forms.ComboBox();
            this.lblOption = new System.Windows.Forms.Label();
            this.txtSEQ = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Col112 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Col111 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Col102 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col103 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col104 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col105 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).BeginInit();
            this.SuspendLayout();
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
            this.pnlTop.Size = new System.Drawing.Size(1008, 45);
            this.pnlTop.TabIndex = 2;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(105, 14);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(214, 21);
            this.txtQuery.TabIndex = 6;
            // 
            // cboQuery
            // 
            this.cboQuery.FormattingEnabled = true;
            this.cboQuery.Items.AddRange(new object[] {
            "상품명"});
            this.cboQuery.Location = new System.Drawing.Point(10, 14);
            this.cboQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboQuery.Name = "cboQuery";
            this.cboQuery.Size = new System.Drawing.Size(90, 20);
            this.cboQuery.TabIndex = 5;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(325, 11);
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
            this.btnExit.Location = new System.Drawing.Point(927, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 26);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // itemGrid
            // 
            this.itemGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.itemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3,
            this.Col4,
            this.Col5,
            this.Col6,
            this.Col7,
            this.Col8});
            this.itemGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemGrid.Location = new System.Drawing.Point(0, 45);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.RowTemplate.Height = 23;
            this.itemGrid.Size = new System.Drawing.Size(629, 577);
            this.itemGrid.TabIndex = 3;
            this.itemGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGrid_CellClick);
            // 
            // Col1
            // 
            this.Col1.HeaderText = "No";
            this.Col1.Name = "Col1";
            this.Col1.Width = 32;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "상품코드";
            this.Col2.Name = "Col2";
            // 
            // Col3
            // 
            this.Col3.HeaderText = "상품명";
            this.Col3.Name = "Col3";
            this.Col3.Width = 240;
            // 
            // Col4
            // 
            this.Col4.HeaderText = "상품명2";
            this.Col4.Name = "Col4";
            this.Col4.Width = 240;
            // 
            // Col5
            // 
            this.Col5.HeaderText = "규격";
            this.Col5.Name = "Col5";
            this.Col5.Width = 120;
            // 
            // Col6
            // 
            this.Col6.HeaderText = "등록일자";
            this.Col6.Name = "Col6";
            // 
            // Col7
            // 
            this.Col7.HeaderText = "거래처";
            this.Col7.Name = "Col7";
            this.Col7.Visible = false;
            // 
            // Col8
            // 
            this.Col8.HeaderText = "SEQ";
            this.Col8.Name = "Col8";
            this.Col8.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(629, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 577);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSEQ);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cboOption);
            this.groupBox1.Controls.Add(this.lblOption);
            this.groupBox1.Controls.Add(this.pImage);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상품정보";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 216);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "옵션정보";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col112,
            this.Col111,
            this.Col102,
            this.Col103,
            this.Col104,
            this.Col105});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(373, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // pImage
            // 
            this.pImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pImage.Location = new System.Drawing.Point(16, 29);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(351, 156);
            this.pImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImage.TabIndex = 10;
            this.pImage.TabStop = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(65, 190);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(302, 21);
            this.txtTitle.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(14, 193);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 12);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "상품명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "상품명2";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(65, 215);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 21);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "규격";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(65, 240);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(302, 21);
            this.textBox2.TabIndex = 9;
            // 
            // cboOption
            // 
            this.cboOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOption.FormattingEnabled = true;
            this.cboOption.Location = new System.Drawing.Point(65, 291);
            this.cboOption.Name = "cboOption";
            this.cboOption.Size = new System.Drawing.Size(302, 20);
            this.cboOption.TabIndex = 12;
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Location = new System.Drawing.Point(14, 293);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(41, 12);
            this.lblOption.TabIndex = 11;
            this.lblOption.Text = "거래처";
            // 
            // txtSEQ
            // 
            this.txtSEQ.Location = new System.Drawing.Point(33, 324);
            this.txtSEQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSEQ.Name = "txtSEQ";
            this.txtSEQ.Size = new System.Drawing.Size(51, 21);
            this.txtSEQ.TabIndex = 18;
            this.txtSEQ.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Location = new System.Drawing.Point(249, 319);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 26);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Location = new System.Drawing.Point(169, 319);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 26);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Location = new System.Drawing.Point(90, 319);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 26);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Col112
            // 
            this.Col112.HeaderText = "저장";
            this.Col112.Name = "Col112";
            this.Col112.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col112.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Col112.Width = 36;
            // 
            // Col111
            // 
            this.Col111.HeaderText = "삭제";
            this.Col111.Name = "Col111";
            this.Col111.Text = "삭제";
            this.Col111.Width = 36;
            // 
            // Col102
            // 
            this.Col102.HeaderText = "옵션명";
            this.Col102.Name = "Col102";
            this.Col102.Width = 200;
            // 
            // Col103
            // 
            this.Col103.HeaderText = "규격";
            this.Col103.Name = "Col103";
            // 
            // Col104
            // 
            this.Col104.HeaderText = "비고";
            this.Col104.Name = "Col104";
            // 
            // Col105
            // 
            this.Col105.HeaderText = "SEQ";
            this.Col105.Name = "Col105";
            this.Col105.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(65, 265);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(302, 21);
            this.textBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "이미지";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.DimGray;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(624, 45);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 577);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // FrmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 622);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.itemGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmProductList";
            this.Text = "상품내역";
            this.Load += new System.EventHandler(this.FrmProductList_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ComboBox cboQuery;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView itemGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pImage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboOption;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.TextBox txtSEQ;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewButtonColumn Col112;
        private System.Windows.Forms.DataGridViewButtonColumn Col111;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col102;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col103;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col104;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col105;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Splitter splitter1;
    }
}