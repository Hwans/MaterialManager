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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductList));
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optionGrid = new System.Windows.Forms.DataGridView();
            this.Col111 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Col102 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col103 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col104 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col105 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelOption = new System.Windows.Forms.Button();
            this.btnSaveOption = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBigImage = new System.Windows.Forms.PictureBox();
            this.txtSEQ = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pImage = new System.Windows.Forms.PictureBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.txtTitle2 = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.lblCompany2 = new System.Windows.Forms.Label();
            this.cboCompany2 = new System.Windows.Forms.ComboBox();
            this.lblCompany3 = new System.Windows.Forms.Label();
            this.cboCompany3 = new System.Windows.Forms.ComboBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBigImage)).BeginInit();
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
            this.txtQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuery_KeyDown);
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
            this.itemGrid.ReadOnly = true;
            this.itemGrid.RowTemplate.Height = 23;
            this.itemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemGrid.Size = new System.Drawing.Size(546, 577);
            this.itemGrid.TabIndex = 3;
            this.itemGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGrid_CellClick);
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
            this.Col2.HeaderText = "상품코드";
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            // 
            // Col3
            // 
            this.Col3.HeaderText = "상품명";
            this.Col3.Name = "Col3";
            this.Col3.ReadOnly = true;
            this.Col3.Width = 240;
            // 
            // Col4
            // 
            this.Col4.HeaderText = "상품명2";
            this.Col4.Name = "Col4";
            this.Col4.ReadOnly = true;
            this.Col4.Width = 240;
            // 
            // Col5
            // 
            this.Col5.HeaderText = "규격";
            this.Col5.Name = "Col5";
            this.Col5.ReadOnly = true;
            this.Col5.Width = 120;
            // 
            // Col6
            // 
            this.Col6.HeaderText = "등록일자";
            this.Col6.Name = "Col6";
            this.Col6.ReadOnly = true;
            // 
            // Col7
            // 
            this.Col7.HeaderText = "거래처";
            this.Col7.Name = "Col7";
            this.Col7.ReadOnly = true;
            this.Col7.Visible = false;
            // 
            // Col8
            // 
            this.Col8.HeaderText = "SEQ";
            this.Col8.Name = "Col8";
            this.Col8.ReadOnly = true;
            this.Col8.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(546, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 577);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optionGrid);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 169);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "옵션정보";
            // 
            // optionGrid
            // 
            this.optionGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.optionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.optionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col111,
            this.Col102,
            this.Col103,
            this.Col104,
            this.Col105});
            this.optionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionGrid.Location = new System.Drawing.Point(3, 17);
            this.optionGrid.Name = "optionGrid";
            this.optionGrid.RowTemplate.Height = 23;
            this.optionGrid.Size = new System.Drawing.Size(456, 91);
            this.optionGrid.TabIndex = 0;
            this.optionGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.optionGrid_CellContentClick);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelOption);
            this.panel2.Controls.Add(this.btnSaveOption);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 58);
            this.panel2.TabIndex = 1;
            // 
            // btnCancelOption
            // 
            this.btnCancelOption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelOption.Location = new System.Drawing.Point(238, 16);
            this.btnCancelOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelOption.Name = "btnCancelOption";
            this.btnCancelOption.Size = new System.Drawing.Size(74, 26);
            this.btnCancelOption.TabIndex = 19;
            this.btnCancelOption.Text = "취소";
            this.btnCancelOption.UseVisualStyleBackColor = true;
            this.btnCancelOption.Click += new System.EventHandler(this.btnCancelOption_Click);
            // 
            // btnSaveOption
            // 
            this.btnSaveOption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveOption.Location = new System.Drawing.Point(158, 16);
            this.btnSaveOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveOption.Name = "btnSaveOption";
            this.btnSaveOption.Size = new System.Drawing.Size(74, 26);
            this.btnSaveOption.TabIndex = 18;
            this.btnSaveOption.Text = "저장";
            this.btnSaveOption.UseVisualStyleBackColor = true;
            this.btnSaveOption.Click += new System.EventHandler(this.btnSaveOption_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBigImage);
            this.groupBox1.Controls.Add(this.txtSEQ);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cboCompany3);
            this.groupBox1.Controls.Add(this.lblCompany3);
            this.groupBox1.Controls.Add(this.cboCompany2);
            this.groupBox1.Controls.Add(this.lblCompany2);
            this.groupBox1.Controls.Add(this.cboCompany);
            this.groupBox1.Controls.Add(this.lblCompany);
            this.groupBox1.Controls.Add(this.pImage);
            this.groupBox1.Controls.Add(this.txtImage);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Controls.Add(this.lblImage);
            this.groupBox1.Controls.Add(this.txtTitle2);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Controls.Add(this.lblTitle2);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상품정보";
            // 
            // btnBigImage
            // 
            this.btnBigImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBigImage.Image = ((System.Drawing.Image)(resources.GetObject("btnBigImage.Image")));
            this.btnBigImage.Location = new System.Drawing.Point(333, 140);
            this.btnBigImage.Name = "btnBigImage";
            this.btnBigImage.Size = new System.Drawing.Size(20, 20);
            this.btnBigImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBigImage.TabIndex = 19;
            this.btnBigImage.TabStop = false;
            this.btnBigImage.Click += new System.EventHandler(this.btnBigImage_Click);
            // 
            // txtSEQ
            // 
            this.txtSEQ.Location = new System.Drawing.Point(33, 377);
            this.txtSEQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSEQ.Name = "txtSEQ";
            this.txtSEQ.Size = new System.Drawing.Size(51, 21);
            this.txtSEQ.TabIndex = 18;
            this.txtSEQ.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Location = new System.Drawing.Point(291, 372);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 26);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Location = new System.Drawing.Point(211, 372);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 26);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Location = new System.Drawing.Point(132, 372);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 26);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pImage
            // 
            this.pImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pImage.Location = new System.Drawing.Point(146, 19);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(181, 141);
            this.pImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImage.TabIndex = 10;
            this.pImage.TabStop = false;
            // 
            // txtImage
            // 
            this.txtImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImage.Location = new System.Drawing.Point(65, 265);
            this.txtImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(385, 21);
            this.txtImage.TabIndex = 9;
            // 
            // txtSize
            // 
            this.txtSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSize.Location = new System.Drawing.Point(65, 240);
            this.txtSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(385, 21);
            this.txtSize.TabIndex = 9;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(11, 268);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(41, 12);
            this.lblImage.TabIndex = 8;
            this.lblImage.Text = "이미지";
            // 
            // txtTitle2
            // 
            this.txtTitle2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle2.Location = new System.Drawing.Point(65, 215);
            this.txtTitle2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle2.Name = "txtTitle2";
            this.txtTitle2.Size = new System.Drawing.Size(385, 21);
            this.txtTitle2.TabIndex = 9;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(11, 243);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(29, 12);
            this.lblSize.TabIndex = 8;
            this.lblSize.Text = "규격";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Location = new System.Drawing.Point(65, 165);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(385, 21);
            this.txtCode.TabIndex = 9;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(65, 190);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(385, 21);
            this.txtTitle.TabIndex = 9;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(11, 168);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(53, 12);
            this.lblCode.TabIndex = 8;
            this.lblCode.Text = "상품코드";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Location = new System.Drawing.Point(11, 218);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(47, 12);
            this.lblTitle2.TabIndex = 8;
            this.lblTitle2.Text = "상품명2";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(11, 193);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 12);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "상품명";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.DimGray;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(541, 45);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 577);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(11, 293);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(41, 12);
            this.lblCompany.TabIndex = 11;
            this.lblCompany.Text = "거래처";
            // 
            // cboCompany
            // 
            this.cboCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(65, 291);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(385, 20);
            this.cboCompany.TabIndex = 12;
            // 
            // lblCompany2
            // 
            this.lblCompany2.AutoSize = true;
            this.lblCompany2.Location = new System.Drawing.Point(11, 319);
            this.lblCompany2.Name = "lblCompany2";
            this.lblCompany2.Size = new System.Drawing.Size(47, 12);
            this.lblCompany2.TabIndex = 11;
            this.lblCompany2.Text = "거래처2";
            // 
            // cboCompany2
            // 
            this.cboCompany2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCompany2.FormattingEnabled = true;
            this.cboCompany2.Location = new System.Drawing.Point(65, 317);
            this.cboCompany2.Name = "cboCompany2";
            this.cboCompany2.Size = new System.Drawing.Size(385, 20);
            this.cboCompany2.TabIndex = 12;
            // 
            // lblCompany3
            // 
            this.lblCompany3.AutoSize = true;
            this.lblCompany3.Location = new System.Drawing.Point(11, 345);
            this.lblCompany3.Name = "lblCompany3";
            this.lblCompany3.Size = new System.Drawing.Size(47, 12);
            this.lblCompany3.TabIndex = 11;
            this.lblCompany3.Text = "거래처3";
            // 
            // cboCompany3
            // 
            this.cboCompany3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCompany3.FormattingEnabled = true;
            this.cboCompany3.Location = new System.Drawing.Point(65, 343);
            this.cboCompany3.Name = "cboCompany3";
            this.cboCompany3.Size = new System.Drawing.Size(385, 20);
            this.cboCompany3.TabIndex = 12;
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
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBigImage)).EndInit();
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
        private System.Windows.Forms.DataGridView optionGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pImage;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtTitle2;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSEQ;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelOption;
        private System.Windows.Forms.Button btnSaveOption;
        private System.Windows.Forms.DataGridViewButtonColumn Col111;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col102;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col103;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col104;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col105;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.PictureBox btnBigImage;
        private System.Windows.Forms.ComboBox cboCompany3;
        private System.Windows.Forms.Label lblCompany3;
        private System.Windows.Forms.ComboBox cboCompany2;
        private System.Windows.Forms.Label lblCompany2;
        private System.Windows.Forms.ComboBox cboCompany;
        private System.Windows.Forms.Label lblCompany;
    }
}