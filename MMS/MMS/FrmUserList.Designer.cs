namespace MMS
{
    partial class FrmUserList
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
            this.userGrid = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUseYn = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoUseY = new System.Windows.Forms.RadioButton();
            this.rdoUseN = new System.Windows.Forms.RadioButton();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSEQ = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoAdminN = new System.Windows.Forms.RadioButton();
            this.rdoAdminY = new System.Windows.Forms.RadioButton();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.pnlTop.Size = new System.Drawing.Size(800, 45);
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
            this.btnExit.Location = new System.Drawing.Point(719, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 26);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // userGrid
            // 
            this.userGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3,
            this.Col4,
            this.Col5,
            this.Col6,
            this.Col7,
            this.Col8});
            this.userGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userGrid.Location = new System.Drawing.Point(0, 45);
            this.userGrid.Name = "userGrid";
            this.userGrid.RowTemplate.Height = 23;
            this.userGrid.Size = new System.Drawing.Size(486, 405);
            this.userGrid.TabIndex = 3;
            this.userGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGrid_CellClick);
            // 
            // Col1
            // 
            this.Col1.HeaderText = "No";
            this.Col1.Name = "Col1";
            this.Col1.Width = 32;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "사용자ID";
            this.Col2.Name = "Col2";
            // 
            // Col3
            // 
            this.Col3.HeaderText = "사용자명";
            this.Col3.Name = "Col3";
            // 
            // Col4
            // 
            this.Col4.HeaderText = "생년월일";
            this.Col4.Name = "Col4";
            // 
            // Col5
            // 
            this.Col5.HeaderText = "핸드폰번호";
            this.Col5.Name = "Col5";
            this.Col5.Width = 120;
            // 
            // Col6
            // 
            this.Col6.HeaderText = "이메일";
            this.Col6.Name = "Col6";
            this.Col6.Width = 120;
            // 
            // Col7
            // 
            this.Col7.HeaderText = "등록일자";
            this.Col7.Name = "Col7";
            // 
            // Col8
            // 
            this.Col8.HeaderText = "SEQ";
            this.Col8.Name = "Col8";
            this.Col8.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtSEQ);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtBirthday);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.lblBirthday);
            this.panel1.Controls.Add(this.txtUserID);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblAdmin);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.lblUseYn);
            this.panel1.Controls.Add(this.lblUserID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(486, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 405);
            this.panel1.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(128, 241);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 26);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(49, 241);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 26);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(79, 16);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(223, 21);
            this.txtUserID.TabIndex = 0;
            // 
            // lblUseYn
            // 
            this.lblUseYn.AutoSize = true;
            this.lblUseYn.Location = new System.Drawing.Point(20, 174);
            this.lblUseYn.Name = "lblUseYn";
            this.lblUseYn.Size = new System.Drawing.Size(53, 12);
            this.lblUseYn.TabIndex = 11;
            this.lblUseYn.Text = "사용여부";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(20, 19);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(52, 12);
            this.lblUserID.TabIndex = 12;
            this.lblUserID.Text = "사용자ID";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(20, 44);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(53, 12);
            this.lblUserName.TabIndex = 12;
            this.lblUserName.Text = "사용자명";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(79, 41);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(223, 21);
            this.txtUserName.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 12);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "비밀번호";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(79, 66);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(223, 21);
            this.txtPassword.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoUseN);
            this.panel2.Controls.Add(this.rdoUseY);
            this.panel2.Location = new System.Drawing.Point(79, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 25);
            this.panel2.TabIndex = 20;
            // 
            // rdoUseY
            // 
            this.rdoUseY.AutoSize = true;
            this.rdoUseY.Checked = true;
            this.rdoUseY.Location = new System.Drawing.Point(14, 6);
            this.rdoUseY.Name = "rdoUseY";
            this.rdoUseY.Size = new System.Drawing.Size(47, 16);
            this.rdoUseY.TabIndex = 0;
            this.rdoUseY.TabStop = true;
            this.rdoUseY.Text = "사용";
            this.rdoUseY.UseVisualStyleBackColor = true;
            // 
            // rdoUseN
            // 
            this.rdoUseN.AutoSize = true;
            this.rdoUseN.Location = new System.Drawing.Point(67, 6);
            this.rdoUseN.Name = "rdoUseN";
            this.rdoUseN.Size = new System.Drawing.Size(59, 16);
            this.rdoUseN.TabIndex = 0;
            this.rdoUseN.Text = "미사용";
            this.rdoUseN.UseVisualStyleBackColor = true;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(20, 94);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(53, 12);
            this.lblBirthday.TabIndex = 12;
            this.lblBirthday.Text = "생년월일";
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(79, 91);
            this.txtBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(223, 21);
            this.txtBirthday.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(8, 119);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 12);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "핸드폰번호";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(79, 116);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(223, 21);
            this.txtPhone.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(32, 144);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 12);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "이메일";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(79, 141);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 21);
            this.txtEmail.TabIndex = 5;
            // 
            // txtSEQ
            // 
            this.txtSEQ.Location = new System.Drawing.Point(10, 298);
            this.txtSEQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSEQ.Name = "txtSEQ";
            this.txtSEQ.Size = new System.Drawing.Size(51, 21);
            this.txtSEQ.TabIndex = 13;
            this.txtSEQ.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(208, 241);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 26);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(8, 204);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(65, 12);
            this.lblAdmin.TabIndex = 11;
            this.lblAdmin.Text = "관리자여부";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdoAdminN);
            this.panel3.Controls.Add(this.rdoAdminY);
            this.panel3.Location = new System.Drawing.Point(79, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 25);
            this.panel3.TabIndex = 20;
            // 
            // rdoAdminN
            // 
            this.rdoAdminN.AutoSize = true;
            this.rdoAdminN.Location = new System.Drawing.Point(67, 6);
            this.rdoAdminN.Name = "rdoAdminN";
            this.rdoAdminN.Size = new System.Drawing.Size(59, 16);
            this.rdoAdminN.TabIndex = 0;
            this.rdoAdminN.Text = "미사용";
            this.rdoAdminN.UseVisualStyleBackColor = true;
            // 
            // rdoAdminY
            // 
            this.rdoAdminY.AutoSize = true;
            this.rdoAdminY.Checked = true;
            this.rdoAdminY.Location = new System.Drawing.Point(14, 6);
            this.rdoAdminY.Name = "rdoAdminY";
            this.rdoAdminY.Size = new System.Drawing.Size(47, 16);
            this.rdoAdminY.TabIndex = 0;
            this.rdoAdminY.TabStop = true;
            this.rdoAdminY.Text = "사용";
            this.rdoAdminY.UseVisualStyleBackColor = true;
            // 
            // FrmUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmUserList";
            this.Text = "사용자관리";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ComboBox cboQuery;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView userGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoUseN;
        private System.Windows.Forms.RadioButton rdoUseY;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUseYn;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.TextBox txtSEQ;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdoAdminN;
        private System.Windows.Forms.RadioButton rdoAdminY;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAdmin;
    }
}