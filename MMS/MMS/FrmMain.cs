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
                //
                statusName.Text = ClsCommon.strName;

                if(ClsCommon.strAdmin != "1")
                {
                    toolStripSeparator1.Visible = false;
                    OrderItemMenuItem2.Visible = false;

                    toolStripSeparator2.Visible = false;
                    inputProductMenuItem2.Visible = false;

                    CompanyMenuItem.Visible = false;
                    SystemMenuItem.Visible = false;
                }
            }
        }

        private void ProductAddMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductList frmProductList = new FrmProductList();
            frmProductList.MdiParent = this;
            frmProductList.Show();
        }

        private void ProductAddFileMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductFile frmProductFile = new FrmProductFile();
            frmProductFile.MdiParent = this;
            frmProductFile.Show();
        }

        private void OrderItemMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrderList frmOrderList = new FrmOrderList();
            frmOrderList.MdiParent = this;
            frmOrderList.Show();
        }

        private void OrderItemMenuItem2_Click(object sender, EventArgs e)
        {
            FrmOrderList2 frmOrderList2 = new FrmOrderList2();
            frmOrderList2.MdiParent = this;
            frmOrderList2.Show();
        }

        private void inputProductMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrderInputList frmOrderInputList = new FrmOrderInputList();
            frmOrderInputList.MdiParent = this;
            frmOrderInputList.Show();
        }

        private void inputProductMenuItem2_Click(object sender, EventArgs e)
        {
            FrmOrderInputList2 frmOrderInputList2 = new FrmOrderInputList2();
            frmOrderInputList2.MdiParent = this;
            frmOrderInputList2.Show();
        }

        private void companyItemMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompanyList frmCompanyList = new FrmCompanyList();
            frmCompanyList.MdiParent = this;
            frmCompanyList.Show();
        }

        private void userMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserList frmUserList = new FrmUserList();
            frmUserList.MdiParent = this;
            frmUserList.Show();
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

                if (!tabForms.Visible) tabForms.Visible = true;

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
