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
    public partial class FrmUserList : Form
    {
        MySqlConnection conn = null;

        public FrmUserList()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(ClsCommon.strConn);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                selectUserList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectUserList()
        {
            DataSet oDs = null;
            try
            {
                //
                userGrid.Rows.Clear();

                String pValue = txtQuery.Text;
                oDs = getUserList("", pValue);
                if (oDs.Tables.Count > 0)
                {
                    int idx = 0;
                    foreach (DataRow oRows in oDs.Tables[0].Rows)
                    {
                        userGrid.Rows.Add();
                        userGrid[0, idx].Value = idx + 1;
                        userGrid[1, idx].Value = oRows["USER_ID"];
                        userGrid[2, idx].Value = oRows["USER_NAME"];
                        userGrid[3, idx].Value = oRows["BIRTH_DAY"];
                        userGrid[4, idx].Value = oRows["PHONE"];
                        userGrid[5, idx].Value = oRows["EMAIL"];
                        userGrid[6, idx].Value = oRows["REG_DATE"];
                        userGrid[7, idx].Value = oRows["SEQ"];
                        idx = idx + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataSet getUserList(String type, String pValue)
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                string sql = " SELECT * FROM TB_USERS WHERE USER_NAME LIKE '%" + pValue + "%' ";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "TB_USERS");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }

        private void userGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet oDs = null;
            try
            {
                //
                initText();

                //
                String sSeq = userGrid[7, e.RowIndex].Value.ToString();
                oDs = getUser(sSeq);
                if (oDs.Tables.Count > 0)
                {
                    DataRow oRows = oDs.Tables[0].Rows[0];

                    txtSEQ.Text = oRows["SEQ"].ToString();
                    txtUserID.Text = oRows["USER_ID"].ToString();
                    txtUserName.Text = oRows["USER_NAME"].ToString();
                    txtPassword.Text = oRows["PASSWORD"].ToString();
                    txtBirthday.Text = oRows["BIRTH_DAY"].ToString();
                    txtPhone.Text = oRows["PHONE"].ToString();
                    txtEmail.Text = oRows["EMAIL"].ToString();
                    if(oRows["ENABLED"].ToString() == "0")
                    {
                        rdoUseN.Checked = true;
                    }
                    else
                    {
                        rdoUseY.Checked = true;
                    }
                    if (oRows["ADMIN"].ToString() == "0")
                    {
                        rdoAdminN.Checked = true;
                    }
                    else
                    {
                        rdoAdminY.Checked = true;
                    }
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
                sql = sql + " FROM TB_USERS ";
                sql = sql + " WHERE SEQ = '" + pSeq + "' ";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "TB_USERS");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }

        private void initText()
        {
            txtSEQ.Text = "";
            txtUserID.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtBirthday.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            rdoUseY.Checked = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if(checkText() == true)
            {
                if (MessageBox.Show("저장하시겠습니까?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        if (txtSEQ.Text == "")
                        {
                            saveUser();
                        }
                        else
                        {
                            updateUser();
                        }
                        MessageBox.Show("저장하였습니다.");

                        initText();
                        selectUserList();
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
            if (txtUserID.Text == "")
            {
                MessageBox.Show("사용자ID를 입력하세요.");
                txtUserID.Focus();
                return false;
            }
            if (txtUserName.Text == "")
            {
                MessageBox.Show("사용자명를 입력하세요.");
                txtUserName.Focus();
                return false;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("비밀번호를 입력하세요.");
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void saveUser()
        {
            try
            {
                String sql = "";
                sql = sql + " INSERT INTO TB_USERS( USER_ID, USER_NAME, PASSWORD, ENABLED, BIRTH_DAY, PHONE, EMAIL, ADMIN, REG_DATE) ";
                sql = sql + " VALUES(@USER_ID, @USER_NAME, @PASSWORD, @ENABLED, @BIRTH_DAY, @PHONE, @EMAIL,@ADMIN, NOW())";

                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = sql;
                oCommand.Parameters.Add("@USER_ID", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@USER_NAME", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@PASSWORD", MySqlDbType.VarChar, 50);
                oCommand.Parameters.Add("@ENABLED", MySqlDbType.Int16, 11);
                oCommand.Parameters.Add("@BIRTH_DAY", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@PHONE", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@EMAIL", MySqlDbType.VarChar, 50);
                oCommand.Parameters.Add("@ADMIN", MySqlDbType.Int16, 11);

                int bUseYN = 1;
                if (rdoUseN.Checked == true)
                {
                    bUseYN = 0;
                }

                int bAdminYN = 1;
                if (rdoAdminN.Checked == true)
                {
                    bAdminYN = 0;
                }

                oCommand.Parameters[0].Value = txtUserID.Text;
                oCommand.Parameters[1].Value = txtUserName.Text;
                oCommand.Parameters[2].Value = txtPassword.Text;
                oCommand.Parameters[3].Value = bUseYN;
                oCommand.Parameters[4].Value = txtBirthday.Text;
                oCommand.Parameters[5].Value = txtPhone.Text;
                oCommand.Parameters[6].Value = txtEmail.Text;
                oCommand.Parameters[7].Value = bAdminYN;
                oCommand.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void updateUser()
        {
            try
            {
                String sql = "";
                sql = sql + " UPDATE TB_USERS SET ";
                sql = sql + " USER_ID = @USER_ID, ";
                sql = sql + " USER_NAME=@USER_NAME, ";
                sql = sql + " PASSWORD =@PASSWORD, ";
                sql = sql + " ENABLED =@ENABLED, ";
                sql = sql + " BIRTH_DAY =@BIRTH_DAY, ";
                sql = sql + " PHONE =@PHONE, ";
                sql = sql + " EMAIL =@EMAIL, ";
                sql = sql + " ADMIN =@ADMIN ";
                sql = sql + " WHERE SEQ=@SEQ ";

                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = sql;
                oCommand.Parameters.Add("@USER_ID", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@USER_NAME", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@PASSWORD", MySqlDbType.VarChar, 50);
                oCommand.Parameters.Add("@ENABLED", MySqlDbType.Int16, 11);
                oCommand.Parameters.Add("@BIRTH_DAY", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@PHONE", MySqlDbType.VarChar, 20);
                oCommand.Parameters.Add("@EMAIL", MySqlDbType.VarChar, 50);
                oCommand.Parameters.Add("@ADMIN", MySqlDbType.Int16, 11);
                oCommand.Parameters.Add("@SEQ", MySqlDbType.Int16, 11);

                int bUseYN = 1;
                if (rdoUseN.Checked == true)
                {
                    bUseYN = 0;
                }

                int bAdminYN = 1;
                if (rdoAdminN.Checked == true)
                {
                    bAdminYN = 0;
                }

                oCommand.Parameters[0].Value = txtUserID.Text;
                oCommand.Parameters[1].Value = txtUserName.Text;
                oCommand.Parameters[2].Value = txtPassword.Text;
                oCommand.Parameters[3].Value = bUseYN;
                oCommand.Parameters[4].Value = txtBirthday.Text;
                oCommand.Parameters[5].Value = txtPhone.Text;
                oCommand.Parameters[6].Value = txtEmail.Text;
                oCommand.Parameters[7].Value = bAdminYN;
                oCommand.Parameters[8].Value = txtSEQ.Text;
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
                    selectUserList();
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
                oCommand.CommandText = " DELETE FROM TB_USERS WHERE SEQ = @SEQ ";
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
    }
}
