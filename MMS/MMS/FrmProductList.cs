﻿using MySql.Data.MySqlClient;
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
            setCompanyList();

            //
            getProductMaxCode();
        }

        private void setCompanyList()
        {
            DataSet oDs = null;
            try
            {
                oDs = getCompanyList();

                Dictionary<string, string> dicOption = getCompnayDictionary(oDs);
                Dictionary<string, string> dicOption2 = getCompnayDictionary(oDs);
                Dictionary<string, string> dicOption3 = getCompnayDictionary(oDs);


                cboCompany.DataSource = new BindingSource(dicOption, null);
                cboCompany.DisplayMember = "Value";
                cboCompany.ValueMember = "Key";
                cboCompany.Text = "";

                //
                cboCompany2.DataSource = new BindingSource(dicOption2, null);
                cboCompany2.DisplayMember = "Value";
                cboCompany2.ValueMember = "Key";
                cboCompany2.Text = "";

                //
                cboCompany3.DataSource = new BindingSource(dicOption3, null);
                cboCompany3.DisplayMember = "Value";
                cboCompany3.ValueMember = "Key";
                cboCompany3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Dictionary<string, string> getCompnayDictionary(DataSet pDs)
        {
            Dictionary<string, string> dicOption = new Dictionary<string, string>();
            
            //
            if (pDs.Tables[0].Rows.Count > 0)
            {
                dicOption.Add("0", " ");
            }

            foreach (DataRow options in pDs.Tables[0].Rows)
            {
                dicOption.Add(options["SEQ"].ToString(), options["BIZ_NAME"].ToString());
            }

            return dicOption;
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

        private void getProductMaxCode()
        {
            DataSet ds = null;
            try
            {
                //
                lblMaxCode.Text = "";

                //
                ds = new DataSet();
                string sql = " SELECT MAX(CODE) AS MaxCode FROM TB_PRODUCT WHERE CODE NOT LIKE 'R%' ";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "TB_PRODUCT");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow oRows = ds.Tables[0].Rows[0];
                    lblMaxCode.Text = oRows[0].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
                string sql = "";
                sql += "SELECT * FROM TB_PRODUCT ";
                if(cboQuery.SelectedIndex == 0)
                {
                    sql += " WHERE TITLE LIKE '%" + pValue + "%' ";
                }
                else
                {
                    sql += " WHERE CODE LIKE '" + pValue + "%' ";
                }
                sql += " ORDER BY TITLE ";
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
                if (itemGrid[7, e.RowIndex].Value != null)
                {
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

                        cboCompany.SelectedValue = oRows["BIZ_SEQ"].ToString();
                        cboCompany2.SelectedValue = oRows["BIZ_SEQ2"].ToString();
                        cboCompany3.SelectedValue = oRows["BIZ_SEQ3"].ToString();

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
                sql = sql + " SELECT P.SEQ, P.CODE, P.TITLE, P.TITLE2, P.SIZE, P.IMAGE, PO.SSEQ, PO.TITLE AS OPTION_TITLE, PO.SIZE AS OPTION_SIZE, PO.ETC AS OPTION_ETC, P.BIZ_SEQ, P.BIZ_SEQ2, P.BIZ_SEQ3 ";
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
            cboCompany2.Text = "";
            cboCompany3.Text = "";
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
                        optionGrid.DataSource = null;
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
                        optionGrid.DataSource = null;
                        //
                        selectOrderList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                //
                getProductMaxCode();
            }
        }

        private void insertProduct()
        {
            try
            {
                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = "INSERT INTO TB_PRODUCT( CODE, TITLE, TITLE2, SIZE, IMAGE, BIZ_SEQ, BIZ_SEQ2, BIZ_SEQ3, REG_DATE ) VALUES( @CODE, @TITLE, @TITLE2, @SIZE, @IMAGE, @BIZ_SEQ, @BIZ_SEQ2, @BIZ_SEQ3, NOW() )";
                oCommand.Parameters.Add("@CODE", MySqlDbType.VarChar, 50);
                oCommand.Parameters.Add("@TITLE", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@TITLE2", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@SIZE", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@IMAGE", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@BIZ_SEQ", MySqlDbType.Int16, 11);
                oCommand.Parameters.Add("@BIZ_SEQ2", MySqlDbType.Int16, 11);
                oCommand.Parameters.Add("@BIZ_SEQ3", MySqlDbType.Int16, 11);

                oCommand.Parameters[0].Value = txtCode.Text;
                oCommand.Parameters[1].Value = txtTitle.Text;
                oCommand.Parameters[2].Value = txtTitle2.Text;
                oCommand.Parameters[3].Value = txtSize.Text;
                oCommand.Parameters[4].Value = txtImage.Text;
                oCommand.Parameters[5].Value = ((KeyValuePair<String, String>)cboCompany.SelectedItem).Key;
                oCommand.Parameters[6].Value = ((KeyValuePair<String, String>)cboCompany2.SelectedItem).Key;
                oCommand.Parameters[7].Value = ((KeyValuePair<String, String>)cboCompany3.SelectedItem).Key;
                oCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
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
                sql = sql + " IMAGE=@IMAGE, ";
                sql = sql + " BIZ_SEQ=@BIZ_SEQ, ";
                sql = sql + " BIZ_SEQ2=@BIZ_SEQ2, ";
                sql = sql + " BIZ_SEQ3=@BIZ_SEQ3 ";
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
                oCommand.Parameters.Add("@BIZ_SEQ", MySqlDbType.Int16, 11);
                oCommand.Parameters.Add("@BIZ_SEQ2", MySqlDbType.Int16, 11);
                oCommand.Parameters.Add("@BIZ_SEQ3", MySqlDbType.Int16, 11);
                oCommand.Parameters.Add("@SEQ", MySqlDbType.Int16, 11);

                oCommand.Parameters[0].Value = txtCode.Text;
                oCommand.Parameters[1].Value = txtTitle.Text;
                oCommand.Parameters[2].Value = txtTitle2.Text;
                oCommand.Parameters[3].Value = txtSize.Text;
                oCommand.Parameters[4].Value = txtImage.Text;
                oCommand.Parameters[5].Value = ((KeyValuePair<String, String>)cboCompany.SelectedItem).Key;
                oCommand.Parameters[6].Value = ((KeyValuePair<String, String>)cboCompany2.SelectedItem).Key;
                oCommand.Parameters[7].Value = ((KeyValuePair<String, String>)cboCompany3.SelectedItem).Key;
                oCommand.Parameters[8].Value = txtSEQ.Text;
                oCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
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
                oCommand.CommandText = " DELETE FROM TB_PRODUCT WHERE SEQ = @SEQ ";
                oCommand.Parameters.Add("@SEQ", MySqlDbType.Int16, 11);

                oCommand.Parameters[0].Value = txtSEQ.Text;
                oCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
            {
                conn.Close();
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

        private void itemGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
            {
                try
                {
                    String sText = "";
                    FrmFindField frmFindField = new FrmFindField();
                    if (frmFindField.ShowDialog() == DialogResult.OK)
                    {
                        sText = frmFindField.SearchText;
                        if (sText != "")
                        {
                            foreach (DataGridViewRow row in itemGrid.Rows)
                            {
                                itemGrid.Rows[row.Index].Selected = false;
                            }

                            foreach (DataGridViewRow row in itemGrid.Rows)
                            {
                                if (row.Cells[2].Value != null && row.Cells[2].Value.ToString().Contains(sText))
                                {
                                    itemGrid.Rows[row.Index].Selected = true;
                                }

                            }
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

            }
        }
    }
}
