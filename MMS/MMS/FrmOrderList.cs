using MySql.Data.MySqlClient;
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
    public partial class FrmOrderList : Form
    {
        static string sTitle = "상품발주";

        public FrmOrderList()
        {
            InitializeComponent();
        }

        private void FrmOrderList_Load(object sender, EventArgs e)
        {
            try
            {
                selectOrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("종료할까요?", sTitle, MessageBoxButtons.YesNo) == DialogResult.Yes )
            {
                this.Close();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                selectOrderList();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectOrderList()
        {
            try
            {
                String sDate1 = sDate.Value.Year.ToString() + sDate.Value.Month.ToString().PadLeft(2, '0') + sDate.Value.Day.ToString().PadLeft(2, '0');

                dataGridView1.Rows.Add(5);

                dataGridView1[0, 0].Value = "1";
                dataGridView1[0, 1].Value = "test1";
                dataGridView1[0, 2].Value = "op1";
                dataGridView1[0, 3].Value = "1";

                dataGridView1[1, 0].Value = "1";
                dataGridView1[1, 1].Value = "test1";
                dataGridView1[1, 2].Value = "op1";
                dataGridView1[1, 3].Value = "1";

                dataGridView1[2, 0].Value = "1";
                dataGridView1[2, 1].Value = "test1";
                dataGridView1[2, 2].Value = "op1";
                dataGridView1[2, 3].Value = "1";

                dataGridView1[3, 0].Value = "1";
                dataGridView1[3, 1].Value = "test1";
                dataGridView1[3, 2].Value = "op1";
                dataGridView1[3, 3].Value = "1";

                dataGridView1[4, 0].Value = "1";
                dataGridView1[4, 1].Value = "test1";
                dataGridView1[4, 2].Value = "op1";
                dataGridView1[4, 3].Value = "1";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmItem frmItem = new FrmItem();
            frmItem.ShowDialog();

            try
            {
                selectOrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*
         * 오늘날짜
         * DateTime.Now.ToString("yyyyMMddHHmmss");
         */

        private DataSet getOrderList(String pDate)
        {
            DataSet ds = null;
            try
            {
                MySqlConnection conn = new MySqlConnection(ClsCommon.strConn);
                ds = new DataSet();
                string sql = "SELECT USER_ID, USER_NAME, PASSWORD FROM TB_USERS WHERE USER_ID ='" + pDate + "' ";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "TB_USERS");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }

    }
}
