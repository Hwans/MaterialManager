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
    public partial class FrmOrderInputList : Form
    {
        MySqlConnection conn = null;

        public FrmOrderInputList()
        {
            InitializeComponent();
        }

        private void FrmOrderInputList_Load(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료할까요?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
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
                        orderGrid[1, idx].Value = oRows["P_TITLE"];
                        orderGrid[2, idx].Value = oRows["PO_TITLE"];
                        orderGrid[3, idx].Value = "";
                        orderGrid[4, idx].Value = getStep(oRows["STEP"].ToString());
                        orderGrid[5, idx].Value = oRows["QTY2"].ToString();
                        orderGrid[5, idx].Value = oRows["ETC"];
                        orderGrid[6, idx].Value = oRows["REQUEST_DATE"];
                        orderGrid[7, idx].Value = oRows["USER_NAME"];
                        orderGrid[8, idx].Value = oRows["SEQ"];
                        orderGrid[9, idx].Value = oRows["PSEQ"];
                        orderGrid[10, idx].Value = oRows["PSSEQ"];

                        if(oRows["QTY"].ToString() != oRows["QTY2"].ToString())
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

        private DataSet getOrderList(String pSDate, String pEDate)
        {
            DataSet oDs = null;
            try
            {
                oDs = new DataSet();

                string sql = "";
                sql = sql + " SELECT O.SEQ, O.PSEQ, O.PSSEQ, P.TITLE AS P_TITLE, PO.TITLE AS PO_TITLE, O.STEP, O.ETC, O.REQUEST_DATE, O.USER_NAME, O.QTY, 0.QTY2 ";
                sql = sql + " FROM TB_ORDER O ";
                sql = sql + " LEFT JOIN TB_PRODUCT P ON O.PSEQ = P.SEQ ";
                sql = sql + " LEFT JOIN TB_PRODUCT_OPTION PO ON O.PSSEQ = PO.SSEQ ";
                if(chkView.Checked == true)
                {
                    sql = sql + " WHERE O.STATUS IN (2, 3) ";
                }
                else
                {
                    sql = sql + " WHERE O.STATUS = 2 ";
                }
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

        private void orderGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String sSEQ = orderGrid[8, e.RowIndex].Value.ToString();
            FrmInputDetail frmInputDetail = new FrmInputDetail(sSEQ);
            frmInputDetail.ShowDialog();

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
