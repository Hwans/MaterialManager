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
                String sSeq = itemGrid[7, e.RowIndex].Value.ToString();
                oDs = getProduct(sSeq);
                if (oDs.Tables.Count > 0)
                {
                    DataRow oRows = oDs.Tables[0].Rows[0];
                    txtSEQ.Text = oRows["SEQ"].ToString();
                    txtTitle.Text = oRows["TITLE"].ToString();
                    txtTitle2.Text = oRows["TITLE2"].ToString();
                    txtSize.Text = oRows["SIZE"].ToString();
                    txtImage.Text = oRows["IMAGE"].ToString();

                    if (oRows["IMAGE"].ToString() != "")
                    {
                        try
                        {
                            String imageURL = "https://retromom.cafe24.com/web/product/big/" + oRows["IMAGE"].ToString();
                            pImage.Load(imageURL);
                        }
                        catch (Exception ex)
                        {
                            Console.Write(ex.Message);
                        }
                    }

                    
                    //
                    optionGrid.Rows.Clear();
                    //
                    int idx = 0;

                    foreach (DataRow options in oDs.Tables[0].Rows)
                    {
                        optionGrid.Rows.Add();
                        optionGrid[0, idx].Value = "저장";
                        optionGrid[1, idx].Value = "삭제";
                        optionGrid[2, idx].Value = options["OPTION_TITLE"];
                        optionGrid[3, idx].Value = options["OPTION_SIZE"];
                        optionGrid[4, idx].Value = options["OPTION_ETC"];
                        optionGrid[5, idx].Value = options["SSEQ"];
                        idx = idx + 1;
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
                ds = new DataSet();

                String sql = "";
                sql = sql + " SELECT P.SEQ, P.CODE, P.TITLE, P.TITLE2, P.SIZE, P.IMAGE, PO.SSEQ, PO.TITLE AS OPTION_TITLE, PO.SIZE AS OPTION_SIZE, PO.ETC AS OPTION_ETC ";
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

        private void initText()
        {
            if (pImage.Image != null)
            {
                pImage.Image = null;
            }

            txtSEQ.Text = "";
            txtTitle.Text = "";
            txtTitle2.Text = "";
            cboCompany.Items.Clear();
            cboCompany.Text = "";
        }

        private void optionGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //
                if(e.ColumnIndex == 0)
                {
                    //저장

                }
                else if(e.ColumnIndex == 1)
                {
                    //삭제
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
