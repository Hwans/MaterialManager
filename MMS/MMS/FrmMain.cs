using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //
            this.Hide();

            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void ProductAddMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduct frmProduct = new FrmProduct();
            frmProduct.MdiParent = this;
            //frmProduct.WindowState = FormWindowState.Maximized;
            frmProduct.Show();
        }

        private void OrderItemMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrderList frmOrderList = new FrmOrderList();
            frmOrderList.MdiParent = this;
            //frmOrderList.WindowState = FormWindowState.Maximized;
            frmOrderList.Show();
        }

        private void FrmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                tabForms.Visible = false;
            }
            else
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
                if (this.ActiveMdiChild.Tag == null)
                {
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = tabForms;
                    tabForms.SelectedTab = tp;

                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                } 
                if (!tabForms.Visible)
                {
                    tabForms.Visible = true;
                }
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((tabForms.SelectedTab != null) && (tabForms.SelectedTab.Tag != null))
            {
                (tabForms.SelectedTab.Tag as Form).Select();
            }
        }
    }
}
