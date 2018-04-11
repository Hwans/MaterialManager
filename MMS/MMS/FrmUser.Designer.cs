namespace MMS
{
    partial class FrmUser
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
            this.grid1 = new SourceGrid2.Grid();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.AutoSizeMinHeight = 10;
            this.grid1.AutoSizeMinWidth = 10;
            this.grid1.AutoStretchColumnsToFitWidth = false;
            this.grid1.AutoStretchRowsToFitHeight = false;
            this.grid1.ContextMenuStyle = SourceGrid2.ContextMenuStyle.None;
            this.grid1.CustomSort = false;
            this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1.FocusStyle = SourceGrid2.FocusStyle.None;
            this.grid1.GridToolTipActive = true;
            this.grid1.Location = new System.Drawing.Point(0, 0);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(800, 450);
            this.grid1.SpecialKeys = ((SourceGrid2.GridSpecialKeys)(((((((((SourceGrid2.GridSpecialKeys.Ctrl_C | SourceGrid2.GridSpecialKeys.Ctrl_V) 
            | SourceGrid2.GridSpecialKeys.Ctrl_X) 
            | SourceGrid2.GridSpecialKeys.Delete) 
            | SourceGrid2.GridSpecialKeys.Arrows) 
            | SourceGrid2.GridSpecialKeys.Tab) 
            | SourceGrid2.GridSpecialKeys.PageDownUp) 
            | SourceGrid2.GridSpecialKeys.Enter) 
            | SourceGrid2.GridSpecialKeys.Escape)));
            this.grid1.TabIndex = 0;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid1);
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SourceGrid2.Grid grid1;
    }
}