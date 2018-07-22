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
    public partial class FrmCompanyList : Form
    {
        MySqlConnection conn = null;

        public FrmCompanyList()
        {
            InitializeComponent();
        }

        private void FrmCompany_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(ClsCommon.strConn);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                selectCompanyList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    selectCompanyList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void selectCompanyList()
        {
            DataSet oDs = null;
            try
            {
                //
                companyGrid.Rows.Clear();

                String pValue = txtQuery.Text;
                oDs = getCompanyList("", pValue);
                if (oDs.Tables.Count > 0)
                {
                    int idx = 0;
                    foreach (DataRow oRows in oDs.Tables[0].Rows)
                    {
                        companyGrid.Rows.Add();
                        companyGrid[0, idx].Value = idx + 1;
                        companyGrid[1, idx].Value = oRows["BIZ_NAME"];
                        companyGrid[2, idx].Value = oRows["BIZ_CODE"];
                        companyGrid[3, idx].Value = oRows["NAME"];
                        companyGrid[4, idx].Value = oRows["BIZ_TEL"];
                        companyGrid[5, idx].Value = oRows["BIZ_MOBILE"];
                        companyGrid[6, idx].Value = oRows["HOMEPAGE"];
                        companyGrid[7, idx].Value = oRows["SEQ"];
                        idx = idx + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataSet getCompanyList(String type, String pValue)
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                string sql = " SELECT * FROM TB_COMPANY WHERE BIZ_NAME LIKE '%" + pValue + "%' ";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "TB_COMPANY");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }

        private void companyGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet oDs = null;
            try
            {
                //
                initText();

                //
                String sSeq = companyGrid[7, e.RowIndex].Value.ToString();
                oDs = getUser(sSeq);
                if (oDs.Tables.Count > 0)
                {
                    DataRow oRows = oDs.Tables[0].Rows[0];

                    txtSEQ.Text = oRows["SEQ"].ToString();
                    txtBizName.Text = oRows["BIZ_NAME"].ToString();
                    txtBizNo.Text = oRows["BIZ_CODE"].ToString();
                    txtName.Text = oRows["NAME"].ToString();
                    txtTel.Text = oRows["BIZ_TEL"].ToString();
                    txtMobile.Text = oRows["BIZ_MOBILE"].ToString();
                    txtBank.Text = oRows["BANK"].ToString();
                    txtBankNumber.Text = oRows["BANK_NUMBER"].ToString();
                    txtBankName.Text = oRows["BANK_NAME"].ToString();
                    txtHomepage.Text = oRows["HOMEPAGE"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataSet getUser(String pSeq)
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();

                String sql = "";
                sql = sql + " SELECT * ";
                sql = sql + " FROM TB_COMPANY ";
                sql = sql + " WHERE SEQ = '" + pSeq + "' ";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "TB_COMPANY");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkText() == true)
            {
                if (MessageBox.Show("저장하시겠습니까?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        if (txtSEQ.Text == "")
                        {
                            insertCompany();
                        }
                        else
                        {
                            updateCompany();
                        }
                        MessageBox.Show("저장하였습니다.");

                        initText();
                        selectCompanyList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private Boolean checkText()
        {
            if (txtBizName.Text == "")
            {
                MessageBox.Show("거래처명을 입력하세요.");
                txtBizName.Focus();
                return false;
            }
            return true;
        }

        private void insertCompany()
        {
            try
            {
                String sql = "";
                sql = sql + " INSERT INTO TB_COMPANY( BIZ_NAME, BIZ_CODE, NAME, BIZ_TEL, BIZ_MOBILE, BANK, BANK_NUMBER, BANK_NAME, HOMEPAGE ) ";
                sql = sql + " VALUES( @BIZ_NAME, @BIZ_CODE, @NAME, @BIZ_TEL, @BIZ_MOBILE, @BANK, @BANK_NUMBER,@BANK_NAME, @HOMEPAGE )";

                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = sql;
                oCommand.Parameters.Add("@BIZ_NAME", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@BIZ_CODE", MySqlDbType.VarChar, 50);
                oCommand.Parameters.Add("@NAME", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@BIZ_TEL", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@BIZ_MOBILE", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@BANK", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@BANK_NUMBER", MySqlDbType.VarChar, 50);
                oCommand.Parameters.Add("@BANK_NAME", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@HOMEPAGE", MySqlDbType.VarChar, 200);

                oCommand.Parameters[0].Value = txtBizName.Text;
                oCommand.Parameters[1].Value = txtBizNo.Text;
                oCommand.Parameters[2].Value = txtName.Text;
                oCommand.Parameters[3].Value = txtTel.Text;
                oCommand.Parameters[4].Value = txtMobile.Text;
                oCommand.Parameters[5].Value = txtBank.Text;
                oCommand.Parameters[6].Value = txtBankNumber.Text;
                oCommand.Parameters[7].Value = txtBankName.Text;
                oCommand.Parameters[8].Value = txtHomepage.Text;
                oCommand.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void updateCompany()
        {
            try
            {
                String sql = "";
                sql = sql + " UPDATE TB_COMPANY SET ";
                sql = sql + " BIZ_NAME=@BIZ_NAME, ";
                sql = sql + " BIZ_CODE=@BIZ_CODE, ";
                sql = sql + " NAME=@NAME, ";
                sql = sql + " BIZ_TEL=@BIZ_TEL, ";
                sql = sql + " BIZ_MOBILE=@BIZ_MOBILE, ";
                sql = sql + " BANK=@BANK, ";
                sql = sql + " BANK_NUMBER=@BANK_NUMBER, ";
                sql = sql + " BANK_NAME=@BANK_NAME, ";
                sql = sql + " HOMEPAGE=@HOMEPAGE ";
                sql = sql + " WHERE SEQ=@SEQ ";

                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = sql;
                oCommand.Parameters.Add("@BIZ_NAME", MySqlDbType.VarChar, 50);
                oCommand.Parameters.Add("@BIZ_CODE", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@NAME", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@BIZ_TEL", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@BIZ_MOBILE", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@BANK", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@BANK_NUMBER", MySqlDbType.VarChar, 50);
                oCommand.Parameters.Add("@BANK_NAME", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@HOMEPAGE", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@SEQ", MySqlDbType.Int16, 11);

                oCommand.Parameters[0].Value = txtBizName.Text;
                oCommand.Parameters[1].Value = txtBizNo.Text;
                oCommand.Parameters[2].Value = txtName.Text;
                oCommand.Parameters[3].Value = txtTel.Text;
                oCommand.Parameters[4].Value = txtMobile.Text;
                oCommand.Parameters[5].Value = txtBank.Text;
                oCommand.Parameters[6].Value = txtBankNumber.Text;
                oCommand.Parameters[7].Value = txtBankName.Text;
                oCommand.Parameters[8].Value = txtHomepage.Text;
                oCommand.Parameters[9].Value = txtSEQ.Text;
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
            if (MessageBox.Show("삭제하시겠습니까?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    delteUser();
                    MessageBox.Show("삭제하였습니다.");

                    initText();
                    selectCompanyList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void delteUser()
        {
            try
            {
                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = " DELETE FROM TB_COMPANY WHERE SEQ = @SEQ ";
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

        private void initText()
        {
            txtSEQ.Text = "";
            txtBizName.Text = "";
            txtBizNo.Text = "";
            txtName.Text = "";
            txtTel.Text = "";
            txtMobile.Text = "";
            txtBank.Text = "";
            txtBankNumber.Text = "";
            txtBankName.Text = "";
            txtHomepage.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료할까요?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
