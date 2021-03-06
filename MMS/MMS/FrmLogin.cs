﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace MMS
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtID.Text = getUserID();
        }

        private String getUserID()
        {
            String retValue = "";
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                retValue = config.AppSettings.Settings["UserID"].Value;
            }
            catch(Exception ex)
            {
                
            }
            return retValue;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string pass = txtPWD.Text;
            if (IsLoggedIn(id, pass))
            {
                //
                AppConfiguration.SetAppConfig("UserID", txtID.Text);

                DialogResult = DialogResult.OK;
            }
        }

        private bool IsLoggedIn(string id, string pass)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("아이디를 입력하세요!");
                return false;
            }
            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("패스워드를 입력하세요!");
                return false;
            }

            //check user name is correct 
            DataSet oDs = SelectData(id);
            if (oDs.Tables[0].Rows.Count > 0)
            {
                DataRow oDr = oDs.Tables[0].Rows[0];
                if (oDr["PASSWORD"].ToString() != pass)
                {
                    MessageBox.Show("비밀번호가 맞지 않습니다.");
                    txtPWD.Text = "";
                    return false;
                }
                else
                {
                    ClsCommon.strName = oDr["USER_NAME"].ToString();
                    ClsCommon.strAdmin = oDr["ADMIN"].ToString();
                    return true;
                }
            }
            else
            {
                MessageBox.Show("사용자가 없습니다.");
                ClearTexts();
                return false;
            }
        }

        private DataSet SelectData(string id)
        {
            DataSet ds = null;
            try
            {
                MySqlConnection conn = new MySqlConnection(ClsCommon.strConn);
                ds = new DataSet();
                string sql = "SELECT USER_ID, USER_NAME, PASSWORD, ADMIN FROM TB_USERS WHERE USER_ID ='" + id + "' ";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "TB_USERS");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }

        private void ClearTexts() {
            txtID.Text = "";
            txtPWD.Text = "";
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPWD.Focus();
            }
        }

        private void txtPWD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string id = txtID.Text;
                string pass = txtPWD.Text;
                if (IsLoggedIn(id, pass))
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void picConfig_Click(object sender, EventArgs e)
        {
            FrmConfig frmConfig = new FrmConfig();
            frmConfig.ShowDialog();
        }

    }
}
