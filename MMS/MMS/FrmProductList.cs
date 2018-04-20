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
    public partial class FrmProductList : Form
    {
        MySqlConnection conn = null;

        public FrmProductList()
        {
            InitializeComponent();
        }

        private void FrmProductList_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(ClsCommon.strConn);

            cboQuery.SelectedIndex = 0;
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
                itemGrid.Rows.Clear();
                
                //
                String pValue = txtQuery.Text;
                oDs = getProductList("", pValue);
                if (oDs.Tables.Count > 0)
                {
                    int idx = 0;
                    foreach (DataRow oRows in oDs.Tables[0].Rows)
                    {
                        itemGrid.Rows.Add();
                        itemGrid[0, idx].Value = idx + 1;
                        itemGrid[1, idx].Value = oRows["CODE"];
                        itemGrid[2, idx].Value = oRows["TITLE"];
                        itemGrid[3, idx].Value = oRows["TITLE2"];
                        itemGrid[4, idx].Value = oRows["SIZE"];
                        itemGrid[5, idx].Value = oRows["REG_DATE"];
                        itemGrid[6, idx].Value = oRows["BIZ_SEQ"];
                        itemGrid[7, idx].Value = oRows["SEQ"];
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
                ds = new DataSet();
                string sql = "SELECT * FROM TB_PRODUCT WHERE TITLE LIKE '%" + pValue + "%' ";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "TB_PRODUCT");
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

        private void itemGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet oDs = null;
            try
            {
                //
                initText();

                //
                String sSeq = itemGrid[2, e.RowIndex].Value.ToString();
                oDs = getProduct(sSeq);
                if (oDs.Tables.Count > 0)
                {
                    DataRow oRows = oDs.Tables[0].Rows[0];
                    String imageURL = "";

                    txtSEQ.Text = oRows["SEQ"].ToString();
                    txtSSEQ.Text = oRows["SSEQ"].ToString();
                    txtTitle.Text = oRows["TITLE"].ToString();

                    if (oRows["IMAGE"].ToString() != "")
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

                    cboOption.Items.Clear();
                    cboOption.DisplayMember = "Text";
                    cboOption.ValueMember = "Value";
                    foreach (DataRow options in oDs.Tables[0].Rows)
                    {
                        cboOption.Items.Add(new { Text = options["OPTION_TITLE"], Value = options["SSEQ"] });
                    }
                    //
                    if (cboOption.Items.Count > 0)
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
    }
}
