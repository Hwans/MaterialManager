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
    public partial class FrmOrderList2 : Form
    {
        MySqlConnection conn = null;

        public FrmOrderList2()
        {
            InitializeComponent();
        }

        private void FrmOrderList2_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(ClsCommon.strConn);
                sDate.Value = DateTime.Today.AddDays(-3);
                selectOrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
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

        private void selectOrderList()
        {
            DataSet oDs = null;
            try
            {
                //
                orderGrid.Rows.Clear();

                //
                String pSDate = sDate.Text;
                String pEDate = eDate.Text;

                oDs = getOrderList(pSDate, pEDate);
                if (oDs.Tables.Count > 0)
                {
                    int idx = 0;
                    foreach (DataRow oRows in oDs.Tables[0].Rows)
                    {
                        orderGrid.Rows.Add();
                        orderGrid[0, idx].Value = idx + 1;
                        orderGrid[1, idx].Value = oRows["BIZ_NAME"].ToString();
                        orderGrid[2, idx].Value = oRows["P_TITLE"].ToString();
                        orderGrid[3, idx].Value = oRows["PO_TITLE"].ToString();
                        orderGrid[4, idx].Value = getStatus(oRows["STATUS"].ToString());
                        orderGrid[5, idx].Value = getStep(oRows["STEP"].ToString());
                        orderGrid[6, idx].Value = oRows["ETC"].ToString();
                        orderGrid[7, idx].Value = oRows["QTY"].ToString();
                        orderGrid[8, idx].Value = oRows["REQUEST_DATE"];
                        orderGrid[9, idx].Value = oRows["USER_NAME"].ToString();
                        orderGrid[10, idx].Value = oRows["SEQ"];
                        orderGrid[11, idx].Value = oRows["PSEQ"];
                        orderGrid[12, idx].Value = oRows["PSSEQ"];
                        orderGrid[13, idx].Value = oRows["BIZ_SEQ"];

                        if( Int16.Parse(oRows["QTY"].ToString()) > 0 )
                        {
                            orderGrid.Rows[idx].DefaultCellStyle.BackColor = Color.LightBlue;
                        }

                        idx = idx + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private String getStatus(String sCode)
        {
            String sReturn = "";
            try
            {
                if(sCode=="1")
                {
                    sReturn = "발주요청";
                }
                else if (sCode == "2")
                {
                    sReturn = "발주";
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return sReturn;
        }

        private DataSet getOrderList(String pSDate, String pEDate)
        {
            DataSet oDs = null;
            try
            {
                oDs = new DataSet();

                string sql = "";
                sql = sql + " SELECT O.SEQ, O.PSEQ, O.PSSEQ, P.TITLE AS P_TITLE, PO.TITLE AS PO_TITLE, O.STEP, O.QTY, O.ETC, O.STATUS, O.REQUEST_DATE, O.USER_NAME, C.SEQ AS BIZ_SEQ, C.BIZ_NAME ";
                sql = sql + " FROM TB_ORDER O ";
                sql = sql + " LEFT JOIN TB_PRODUCT P ON O.PSEQ = P.SEQ ";
                sql = sql + " LEFT JOIN TB_PRODUCT_OPTION PO ON O.PSSEQ = PO.SSEQ ";
                sql = sql + " LEFT JOIN TB_COMPANY C ON P.BIZ_SEQ = C.SEQ ";
                sql = sql + " WHERE O.STATUS IN (1, 2) ";
                sql = sql + " AND DATE(O.REQUEST_DATE) BETWEEN '" + pSDate + "' AND '" + pEDate + "' ";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(oDs, "TB_ORDER");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return oDs;
        }

        private String getStep(String pValue)
        {
            switch (pValue)
            {
                case "1":
                    return "☆☆☆☆★";
                case "2":
                    return "☆☆☆★★";
                case "3":
                    return "☆☆★★★";
                case "4":
                    return "☆★★★★";
                case "5":
                    return "★★★★★";
                default:
                    return "☆☆☆☆★";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료할까요?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmItemList frmItem = new FrmItemList();
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

        private void orderGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String sSEQ = orderGrid[10, e.RowIndex].Value.ToString();
            FrmOrderDetail2 frmOrderDetail2 = new FrmOrderDetail2(sSEQ);
            frmOrderDetail2.ShowDialog();

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
