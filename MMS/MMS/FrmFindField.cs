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
    public partial class FrmFindField : Form
    {
        String searchText = "";

        public FrmFindField()
        {
            InitializeComponent();
        }

        public String SearchText
        {
            get
            {
                return this.searchText;
            }
            set
            {
                this.searchText = value;
            }
        }


        private void FrmFindField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void txtSearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                search();
            }

            if(e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnSearh_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            if (txtSearchText.Text != "")
            {
                searchText = txtSearchText.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("검색어를 입력하세요.");
                txtSearchText.Focus();
            }
        }
    }
}
