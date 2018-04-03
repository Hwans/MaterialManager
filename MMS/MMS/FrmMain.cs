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
            if(frmLogin.ShowDialog() != DialogResult.OK)
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
            frmProduct.WindowState = FormWindowState.Maximized;
            frmProduct.Show();
        }


    }
}
