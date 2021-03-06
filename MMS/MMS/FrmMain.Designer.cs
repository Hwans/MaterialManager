﻿namespace MMS
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
            this.OrderItemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OrderItemMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.InputMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputProductMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompanyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyItemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.codeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabForms = new System.Windows.Forms.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.inputProductMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ProductMenuItem
            // 
            this.ProductMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductAddMenuItem,
            this.ProductAddFileMenuItem});
            this.ProductMenuItem.Name = "ProductMenuItem";
            this.ProductMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ProductMenuItem.Text = "상품관리";
            // 
            // ProductAddMenuItem
            // 
            this.ProductAddMenuItem.Name = "ProductAddMenuItem";
            this.ProductAddMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ProductAddMenuItem.Text = "상품등록";
            this.ProductAddMenuItem.Click += new System.EventHandler(this.ProductAddMenuItem_Click);
            // 
            // ProductAddFileMenuItem
            // 
            this.ProductAddFileMenuItem.Name = "ProductAddFileMenuItem";
            this.ProductAddFileMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ProductAddFileMenuItem.Text = "일괄(파일)등록";
            this.ProductAddFileMenuItem.Click += new System.EventHandler(this.ProductAddFileMenuItem_Click);
            // 
            // OrderMenuItem
            // 
            this.OrderMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderItemMenuItem,
            this.toolStripSeparator1,
            this.OrderItemMenuItem2});
            this.OrderMenuItem.Name = "OrderMenuItem";
            this.OrderMenuItem.Size = new System.Drawing.Size(67, 20);
            this.OrderMenuItem.Text = "발주관리";
            // 
            // OrderItemMenuItem
            // 
            this.OrderItemMenuItem.Name = "OrderItemMenuItem";
            this.OrderItemMenuItem.Size = new System.Drawing.Size(166, 22);
            this.OrderItemMenuItem.Text = "상품발주";
            this.OrderItemMenuItem.Click += new System.EventHandler(this.OrderItemMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // OrderItemMenuItem2
            // 
            this.OrderItemMenuItem2.Name = "OrderItemMenuItem2";
            this.OrderItemMenuItem2.Size = new System.Drawing.Size(166, 22);
            this.OrderItemMenuItem2.Text = "상품발주(관리자)";
            this.OrderItemMenuItem2.Click += new System.EventHandler(this.OrderItemMenuItem2_Click);
            // 
            // InputMenuItem
            // 
            this.InputMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputProductMenuItem,
            this.toolStripSeparator2,
            this.inputProductMenuItem2});
            this.InputMenuItem.Name = "InputMenuItem";
            this.InputMenuItem.Size = new System.Drawing.Size(67, 20);
            this.InputMenuItem.Text = "입고관리";
            // 
            // inputProductMenuItem
            // 
            this.inputProductMenuItem.Name = "inputProductMenuItem";
            this.inputProductMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inputProductMenuItem.Text = "상품입고";
            this.inputProductMenuItem.Click += new System.EventHandler(this.inputProductMenuItem_Click);
            // 
            // CompanyMenuItem
            // 
            this.CompanyMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyItemMenuItem});
            this.CompanyMenuItem.Name = "CompanyMenuItem";
            this.CompanyMenuItem.Size = new System.Drawing.Size(79, 20);
            this.CompanyMenuItem.Text = "거래처관리";
            // 
            // companyItemMenuItem
            // 
            this.companyItemMenuItem.Name = "companyItemMenuItem";
            this.companyItemMenuItem.Size = new System.Drawing.Size(180, 22);
            this.companyItemMenuItem.Text = "거래처등록";
            this.companyItemMenuItem.Click += new System.EventHandler(this.companyItemMenuItem_Click);
            // 
            // SystemMenuItem
            // 
            this.SystemMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMenuItem,
            this.toolStripMenuItem1,
            this.codeMenuItem});
            this.SystemMenuItem.Name = "SystemMenuItem";
            this.SystemMenuItem.Size = new System.Drawing.Size(55, 20);
            this.SystemMenuItem.Text = "시스템";
            // 
            // userMenuItem
            // 
            this.userMenuItem.Name = "userMenuItem";
            this.userMenuItem.Size = new System.Drawing.Size(134, 22);
            this.userMenuItem.Text = "사용자관리";
            this.userMenuItem.Click += new System.EventHandler(this.userMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 6);
            // 
            // codeMenuItem
            // 
            this.codeMenuItem.Name = "codeMenuItem";
            this.codeMenuItem.Size = new System.Drawing.Size(134, 22);
            this.codeMenuItem.Text = "코드관리";
            // 
            // tabForms
            // 
            this.tabForms.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabForms.Location = new System.Drawing.Point(0, 24);
            this.tabForms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabForms.Name = "tabForms";
            this.tabForms.SelectedIndex = 0;
            this.tabForms.Size = new System.Drawing.Size(800, 24);
            this.tabForms.TabIndex = 3;
            this.tabForms.Visible = false;
            this.tabForms.SelectedIndexChanged += new System.EventHandler(this.tabForms_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusName
            // 
            this.statusName.Name = "statusName";
            this.statusName.Size = new System.Drawing.Size(39, 17);
            this.statusName.Text = "Name";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // inputProductMenuItem2
            // 
            this.inputProductMenuItem2.Name = "inputProductMenuItem2";
            this.inputProductMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.inputProductMenuItem2.Text = "상품입고::관리자";
            this.inputProductMenuItem2.Click += new System.EventHandler(this.inputProductMenuItem2_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabForms);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Material Manage System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MdiChildActivate += new System.EventHandler(this.FrmMain_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.TabControl tabForms;
        private System.Windows.Forms.ToolStripMenuItem userMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem codeMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusName;
        private System.Windows.Forms.ToolStripMenuItem companyItemMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem OrderItemMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem inputProductMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem inputProductMenuItem2;
    }
}