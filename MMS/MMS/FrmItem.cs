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
    public partial class FrmItem : Form
    {
        public FrmItem()
        {
            InitializeComponent();
        }

        private void FrmItemList_Load(object sender, EventArgs e)
        {
            cboQuery.SelectedIndex = 0;
            setCobmoStep();
        }

        private void setCobmoStep()
        {
            cboStep.DisplayMember = "Text";
            cboStep.ValueMember = "Value";

            cboStep.Items.Add(new { Text = "☆☆☆☆★", Value = 1 });
            cboStep.Items.Add(new { Text = "☆☆☆★★", Value = 2 });
            cboStep.Items.Add(new { Text = "☆☆★★★", Value = 3 });
            cboStep.Items.Add(new { Text = "☆★★★★", Value = 4 });
            cboStep.Items.Add(new { Text = "★★★★★", Value = 5 });

            cboStep.SelectedIndex = 0;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                itemGrid.Rows.Clear();
                selectOrderList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void selectOrderList()
        {
            DataSet oDs = null;
            try
            {
                String pValue = txtQuery.Text;
                oDs = getProductList("", pValue);
                if (oDs.Tables.Count > 0)
                {
                    int idx = 0;
                    foreach (DataRow oRows in oDs.Tables[0].Rows)
                    {
                        itemGrid.Rows.Add();
                        itemGrid[0, idx].Value = idx + 1;
                        itemGrid[1, idx].Value = oRows["TITLE"];
                        itemGrid[2, idx].Value = oRows["SEQ"];
                        idx = idx + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataSet getProductList(String type, String pValue)
        {
            DataSet ds = null;
            try
            {
                MySqlConnection conn = new MySqlConnection(ClsCommon.strConn);
                ds = new DataSet();
                string sql = "SELECT SEQ, TITLE FROM TB_PRODUCT WHERE TITLE LIKE '%" + pValue + "%' ";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "TB_PRODUCT");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }

        private void itemGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet oDs = null;
            try
            {
                String sSeq = itemGrid[2, e.RowIndex].Value.ToString();
                oDs = getProduct(sSeq);
                if (oDs.Tables.Count > 0)
                {
                    DataRow oRows = oDs.Tables[0].Rows[0];
                    String imageURL = "";


                    txtSEQ.Text = oRows["SEQ"].ToString();
                    txtSSEQ.Text = oRows["SSEQ"].ToString();
                    txtTitle.Text = oRows["TITLE"].ToString();

                    if(oRows["IMAGE"].ToString() != "")
                    {
                        try
                        {
                            imageURL = "https://retromom.cafe24.com/web/product/big/" + oRows["IMAGE"].ToString();
                            pImage.Load(imageURL);
                        }
                        catch (Exception ex)
                        {
                            Console.Write(ex.Message);
                        }
                    }

                    cboOption.DisplayMember = "Text";
                    cboOption.ValueMember = "Value";
                    foreach (DataRow options in oDs.Tables[0].Rows)
                    {
                        cboOption.Items.Add(new { Text = options["OPTION_TITLE"], Value = options["SSEQ"] });
                    }
                    //
                    if(cboOption.Items.Count > 0)
                    {
                        cboOption.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataSet getProduct(String pSeq)
        {
            DataSet ds = null;
            try
            {
                MySqlConnection conn = new MySqlConnection(ClsCommon.strConn);
                ds = new DataSet();

                String sql = "";
                sql = sql + " SELECT P.SEQ, P.CODE, P.TITLE, P.TITLE2, P.IMAGE, PO.SSEQ, PO.TITLE AS OPTION_TITLE ";
                sql = sql + " FROM TB_PRODUCT P ";
                sql = sql + " LEFT JOIN TB_PRODUCT_OPTION PO ON P.SEQ = PO.SEQ ";
                sql = sql + " WHERE P.SEQ = '" + pSeq + "' ";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "TB_PRODUCT_OPTION");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
