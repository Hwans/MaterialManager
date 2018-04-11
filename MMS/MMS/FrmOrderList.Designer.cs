namespace MMS
{
    partial class FrmOrderList
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelelte = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.sp1 = new System.Windows.Forms.Label();
            this.eDate = new System.Windows.Forms.DateTimePicker();
            this.sDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.orderGrid = new SourceGrid2.Grid();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlTop.Controls.Add(this.btnAdd);
            this.pnlTop.Controls.Add(this.btnSelect);
            this.pnlTop.Controls.Add(this.btnSave);
            this.pnlTop.Controls.Add(this.btnDelelte);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Controls.Add(this.sp1);
            this.pnlTop.Controls.Add(this.eDate);
            this.pnlTop.Controls.Add(this.sDate);
            this.pnlTop.Controls.Add(this.lblDate);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(880, 45);
            this.pnlTop.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(405, 11);
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
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(564, 11);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(74, 26);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(642, 11);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 26);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelelte
            // 
            this.btnDelelte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelelte.Location = new System.Drawing.Point(721, 11);
            this.btnDelelte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelelte.Name = "btnDelelte";
            this.btnDelelte.Size = new System.Drawing.Size(74, 26);
            this.btnDelelte.TabIndex = 4;
            this.btnDelelte.Text = "삭제";
            this.btnDelelte.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(800, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 26);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // sp1
            // 
            this.sp1.AutoSize = true;
            this.sp1.Location = new System.Drawing.Point(164, 18);
            this.sp1.Name = "sp1";
            this.sp1.Size = new System.Drawing.Size(14, 12);
            this.sp1.TabIndex = 3;
            this.sp1.Text = "~";
            // 
            // eDate
            // 
            this.eDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.eDate.Location = new System.Drawing.Point(186, 13);
            this.eDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eDate.Name = "eDate";
            this.eDate.Size = new System.Drawing.Size(110, 21);
            this.eDate.TabIndex = 2;
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
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(10, 18);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(29, 12);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "날짜";
            // 
            // orderGrid
            // 
            this.orderGrid.AutoSizeMinHeight = 10;
            this.orderGrid.AutoSizeMinWidth = 10;
            this.orderGrid.AutoStretchColumnsToFitWidth = false;
            this.orderGrid.AutoStretchRowsToFitHeight = false;
            this.orderGrid.ContextMenuStyle = SourceGrid2.ContextMenuStyle.None;
            this.orderGrid.CustomSort = false;
            this.orderGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderGrid.FocusStyle = SourceGrid2.FocusStyle.None;
            this.orderGrid.GridToolTipActive = true;
            this.orderGrid.Location = new System.Drawing.Point(0, 45);
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.Size = new System.Drawing.Size(880, 301);
            this.orderGrid.SpecialKeys = ((SourceGrid2.GridSpecialKeys)(((((((((SourceGrid2.GridSpecialKeys.Ctrl_C | SourceGrid2.GridSpecialKeys.Ctrl_V) 
            | SourceGrid2.GridSpecialKeys.Ctrl_X) 
            | SourceGrid2.GridSpecialKeys.Delete) 
            | SourceGrid2.GridSpecialKeys.Arrows) 
            | SourceGrid2.GridSpecialKeys.Tab) 
            | SourceGrid2.GridSpecialKeys.PageDownUp) 
            | SourceGrid2.GridSpecialKeys.Enter) 
            | SourceGrid2.GridSpecialKeys.Escape)));
            this.orderGrid.TabIndex = 2;
            // 
            // FrmOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 346);
            this.Controls.Add(this.orderGrid);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmOrderList";
            this.Tag = "FrmOrderList";
            this.Text = "상품발주";
            this.Load += new System.EventHandler(this.FrmOrderList_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelelte;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label sp1;
        private System.Windows.Forms.DateTimePicker eDate;
        private System.Windows.Forms.DateTimePicker sDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAdd;
        private SourceGrid2.Grid orderGrid;
    }
}