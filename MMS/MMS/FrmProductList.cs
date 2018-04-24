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
            //
            cboQuery.SelectedIndex = 0;
            //
            setCobmoStep();
        }

        private void setCobmoStep()
        {
            cboCompany.DisplayMember = "Text";
            cboCompany.ValueMember = "Value";

            DataSet oDs = null;
            try
            {
                oDs = getCompanyList();
                if (oDs.Tables.Count > 0)
                {
                    foreach (DataRow oRows in oDs.Tables[0].Rows)
                    {
                        cboCompany.Items.Add(new { Text = oRows["BIZ_NAME"].ToString(), Value = oRows["SEQ"].ToString() });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private DataSet getCompanyList()
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                string sql = "SELECT SEQ, BIZ_NAME FROM TB_COMPANY ORDER BY BIZ_NAME ";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "TB_COMPANY");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
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

        private void txtQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                    txtCode.Text = oRows["CODE"].ToString();
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
                    selectProductOption();
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
            txtCode.Text = "";
            txtTitle.Text = "";
            txtTitle2.Text = "";
            txtImage.Text = "";
            cboCompany.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("저장하시겠습니까?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txtSEQ.Text == "")
                {
                    try
                    {
                        insertProduct();
                        MessageBox.Show("저장하였습니다.");
                        //
                        initText();
                        //
                        selectOrderList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        updateProduct();
                        MessageBox.Show("저장하였습니다.");
                        //
                        initText();
                        //
                        selectOrderList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void insertProduct()
        {
            try
            {
                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = "INSERT INTO TB_PRODUCT( CODE, TITLE, TITLE2, SIZE, IMAGE, REG_DATE ) VALUES( @CODE, @TITLE, @TITLE2, @SIZE, @IMAGE, NOW() )";
                oCommand.Parameters.Add("@CODE", MySqlDbType.VarChar, 50);
                oCommand.Parameters.Add("@TITLE", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@TITLE2", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@SIZE", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@IMAGE", MySqlDbType.VarChar, 200);

                oCommand.Parameters[0].Value = txtCode.Text;
                oCommand.Parameters[1].Value = txtTitle.Text;
                oCommand.Parameters[2].Value = txtTitle2.Text;
                oCommand.Parameters[3].Value = txtSize.Text;
                oCommand.Parameters[4].Value = txtImage.Text;
                oCommand.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void updateProduct()
        {
            try
            {
                String sql = "";
                sql = sql + " UPDATE TB_PRODUCT SET ";
                sql = sql + " CODE=@CODE,";
                sql = sql + " TITLE=@TITLE,";
                sql = sql + " TITLE2=@TITLE2,";
                sql = sql + " SIZE=@SIZE, ";
                sql = sql + " IMAGE=@IMAGE ";
                sql = sql + " WHERE SEQ=@SEQ ";

                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = sql;
                oCommand.Parameters.Add("@CODE", MySqlDbType.VarChar, 50);
                oCommand.Parameters.Add("@TITLE", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@TITLE2", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@SIZE", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@IMAGE", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@SEQ", MySqlDbType.Int16, 11);

                oCommand.Parameters[0].Value = txtCode.Text;
                oCommand.Parameters[1].Value = txtTitle.Text;
                oCommand.Parameters[2].Value = txtTitle2.Text;
                oCommand.Parameters[3].Value = txtSize.Text;
                oCommand.Parameters[4].Value = txtImage.Text;
                oCommand.Parameters[5].Value = txtSEQ.Text;
                oCommand.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제하시겠습니까?\r\n(옵션정보다 함께 삭제되어집니다.)", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //
                    delteProductOption();
                    //
                    delteProduct();
                    MessageBox.Show("삭제하였습니다.");
                    //
                    initText();
                    //
                    selectOrderList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void delteProduct()
        {
            try
            {
                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = " DELETE FROM TB_PRODUC WHERE SEQ = @SEQ ";
                oCommand.Parameters.Add("@SEQ", MySqlDbType.Int16, 11);

                oCommand.Parameters[0].Value = txtSEQ.Text;
                oCommand.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void delteProductOption()
        {
            try
            {
                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = " DELETE FROM TB_PRODUCT_OPTION WHERE SEQ = @SEQ ";
                oCommand.Parameters.Add("@SEQ", MySqlDbType.Int16, 11);

                oCommand.Parameters[0].Value = txtSEQ.Text;
                oCommand.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            initText();
        }

        private void btnSaveOption_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("저장하시겠습니까?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for(int idx=0; idx < optionGrid.Rows.Count -1; idx++)
                {
                    if (optionGrid[4, idx].Value != null)
                    {
                        updateProductOption(idx); 
                    }
                    else
                    {
                        insertProductOption(idx);
                    }
                }
                //
                MessageBox.Show("저장하였습니다.");
                //
                selectProductOption();
            }
        }

        private void insertProductOption(int iRow)
        {
            try
            {
                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = "INSERT INTO TB_PRODUCT_OPTION( SEQ, TITLE, SIZE, ETC, REG_DATE) VALUE( @SEQ, @TITLE, @SIZE, @ETC, NOW() )";
                oCommand.Parameters.Add("@SEQ", MySqlDbType.Int16, 11);
                oCommand.Parameters.Add("@TITLE", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@SIZE", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@ETC", MySqlDbType.VarChar, 200);

                oCommand.Parameters[0].Value = txtSEQ.Text;
                oCommand.Parameters[1].Value = optionGrid[1, iRow].Value;
                oCommand.Parameters[2].Value = optionGrid[2, iRow].Value;
                oCommand.Parameters[3].Value = optionGrid[3, iRow].Value;
                oCommand.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void updateProductOption(int iRow)
        {
            try
            {
                String sql = "";
                sql = sql + " UPDATE TB_PRODUCT_OPTION SET ";
                sql = sql + " TITLE=@TITLE,";
                sql = sql + " SIZE=@SIZE, ";
                sql = sql + " ETC=@ETC ";
                sql = sql + " WHERE SSEQ=@SSEQ ";

                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = sql;
                oCommand.Parameters.Add("@TITLE", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@SIZE", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@ETC", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@SSEQ", MySqlDbType.Int16, 11);

                oCommand.Parameters[0].Value = optionGrid[1, iRow].Value;
                oCommand.Parameters[1].Value = optionGrid[2, iRow].Value;
                oCommand.Parameters[2].Value = optionGrid[3, iRow].Value;
                oCommand.Parameters[3].Value = optionGrid[4, iRow].Value;
                oCommand.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void optionGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (MessageBox.Show("삭제하시겠습니까?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //
                        delteProductOption(e.RowIndex);
                        //
                        MessageBox.Show("삭제하였습니다.");
                        //
                        selectProductOption();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void selectProductOption()
        {
            try
            {
                //
                optionGrid.Rows.Clear();
                //
                DataSet oDs = getProductOption(txtSEQ.Text);
                //
                int idx = 0;
                foreach (DataRow options in oDs.Tables[0].Rows)
                {
                    optionGrid.Rows.Add();
                    optionGrid[0, idx].Value = "삭제";
                    optionGrid[1, idx].Value = options["TITLE"];
                    optionGrid[2, idx].Value = options["SIZE"];
                    optionGrid[3, idx].Value = options["ETC"];
                    optionGrid[4, idx].Value = options["SSEQ"];
                    idx = idx + 1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataSet getProductOption(String pSeq)
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();

                String sql = "";
                sql = sql + " SELECT SSEQ, SEQ, TITLE, SIZE, ETC ";
                sql = sql + " FROM TB_PRODUCT_OPTION  ";
                sql = sql + " WHERE SEQ = '" + pSeq + "' ";
                sql = sql + " ORDER BY SSEQ ";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "TB_PRODUCT_OPTION");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }

        private void delteProductOption(int iRow)
        {
            try
            {
                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = " DELETE FROM TB_PRODUCT_OPTION WHERE SSEQ = @SSEQ ";
                oCommand.Parameters.Add("@SSEQ", MySqlDbType.Int16, 11);

                oCommand.Parameters[0].Value = optionGrid[4,iRow].Value;
                oCommand.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCancelOption_Click(object sender, EventArgs e)
        {
            //optionGrid.Rows.Clear();
        }

        private void btnBigImage_Click(object sender, EventArgs e)
        {
            FrmImage fImage = new FrmImage(pImage.ImageLocation);
            fImage.Show();
        }
    }
}
