namespace MMS
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProductMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductAddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductAddFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InputMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompanyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderItemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductMenuItem,
            this.OrderMenuItem,
            this.InputMenuItem,
            this.CompanyMenuItem,
            this.SystemMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(914, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ProductMenuItem
            // 
            this.ProductMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductAddMenuItem,
            this.ProductAddFileMenuItem});
            this.ProductMenuItem.Name = "ProductMenuItem";
            this.ProductMenuItem.Size = new System.Drawing.Size(81, 24);
            this.ProductMenuItem.Text = "상품관리";
            // 
            // ProductAddMenuItem
            // 
            this.ProductAddMenuItem.Name = "ProductAddMenuItem";
            this.ProductAddMenuItem.Size = new System.Drawing.Size(184, 26);
            this.ProductAddMenuItem.Text = "상품등록";
            this.ProductAddMenuItem.Click += new System.EventHandler(this.ProductAddMenuItem_Click);
            // 
            // ProductAddFileMenuItem
            // 
            this.ProductAddFileMenuItem.Name = "ProductAddFileMenuItem";
            this.ProductAddFileMenuItem.Size = new System.Drawing.Size(184, 26);
            this.ProductAddFileMenuItem.Text = "일괄(파일)등록";
            // 
            // OrderMenuItem
            // 
            this.OrderMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderItemMenuItem});
            this.OrderMenuItem.Name = "OrderMenuItem";
            this.OrderMenuItem.Size = new System.Drawing.Size(81, 24);
            this.OrderMenuItem.Text = "발주관리";
            // 
            // InputMenuItem
            // 
            this.InputMenuItem.Name = "InputMenuItem";
            this.InputMenuItem.Size = new System.Drawing.Size(81, 24);
            this.InputMenuItem.Text = "입고관리";
            // 
            // CompanyMenuItem
            // 
            this.CompanyMenuItem.Name = "CompanyMenuItem";
            this.CompanyMenuItem.Size = new System.Drawing.Size(96, 24);
            this.CompanyMenuItem.Text = "거래처관리";
            // 
            // SystemMenuItem
            // 
            this.SystemMenuItem.Name = "SystemMenuItem";
            this.SystemMenuItem.Size = new System.Drawing.Size(66, 24);
            this.SystemMenuItem.Text = "시스템";
            // 
            // OrderItemMenuItem
            // 
            this.OrderItemMenuItem.Name = "OrderItemMenuItem";
            this.OrderItemMenuItem.Size = new System.Drawing.Size(181, 26);
            this.OrderItemMenuItem.Text = "상품발주";
            this.OrderItemMenuItem.Click += new System.EventHandler(this.OrderItemMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.Text = "Material Manage System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ProductMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InputMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompanyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SystemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductAddMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductAddFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderItemMenuItem;
    }
}