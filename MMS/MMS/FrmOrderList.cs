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
        MySqlConnection conn = null;

        public FrmOrderList()
        {
            InitializeComponent();
        }

        private void FrmOrderList_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(ClsCommon.strConn);
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
            DataSet oDs = null;
            try
            {
                String pDate = sDate.Text;
                oDs = getOrderList(pDate);
                if (oDs.Tables.Count > 0)
                {
                    int idx = 0;
                    foreach (DataRow oRows in oDs.Tables[0].Rows)
                    {
                        //itemGrid.Rows.Add();
                        //itemGrid[0, idx].Value = idx + 1;
                        //itemGrid[1, idx].Value = oRows["TITLE"];
                        //itemGrid[2, idx].Value = oRows["SEQ"];
                        //idx = idx + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataSet getOrderList(String pDate)
        {
            DataSet oDs = null;
            try
            {
                oDs = new DataSet();

                string sql = "";
                sql = sql + "SELECT P.SEQ, O.PSEQ, O.PSSEQ, P.TITLE AS P_TITLE, PO.TITLE AS PO_TITLE, O.STEP, O.ETC, O.REQUEST_DATE, O.USER_NAME";
                sql = sql + "FROM TB_ORDER O";
                sql = sql + "JOIN TB_PRODUCT P ON O.PSEQ = P.SEQ";
                sql = sql + "JOIN TB_PRODUCT_OPTION PO ON O.PSSEQ = PO.SSEQ";
                sql = sql + "WHERE DATE(O.REQUEST_DATE) = '" + pDate + "'";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(oDs, "TB_ORDER");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return oDs;
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

    }
}
