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
    public partial class FrmImage : Form
    {

        private String imgURL = "";

        public FrmImage()
        {
            InitializeComponent();
        }

        public FrmImage(String value)
        {
            InitializeComponent();
            imgURL = value;
        }

        private void FrmImage_Load(object sender, EventArgs e)
        {
            try
            {
                bigImage.Load(imgURL);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bigImage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
