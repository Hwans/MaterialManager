using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MMS
{
    public partial class FrmLogin : Form
    {
        static string strConn = "Server=umj64-004.cafe24.com;Database=admin1981;Uid=admin1981;Pwd=admindb@1981;";
        MySqlConnection conn = new MySqlConnection(strConn);


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string pass = txtPWD.Text;
            if (IsLoggedIn(id, pass))
            {
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
            else
            {
                DataSet oDs = SelectData(id);
                if( oDs.Tables[0].Rows.Count > 0 )
                {
                    DataRow oDr = oDs.Tables[0].Rows[0];
                    if (oDr["PASSWORD"].ToString() != pass)
                    {
                        MessageBox.Show("비밀번호가 맞지 않습니다.");
                        textBox2.Text = "";
                        return false;
                    }
                    else
                    {
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
        }

        private DataSet SelectData(string id)
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                string sql = "SELECT USER_ID, USER_NAME, PASSWORD FROM TB_USERS WHERE USER_ID ='" + id + "' ";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "TB_USERS");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string id = textBox1.Text;
                string pass = textBox2.Text;
                if (IsLoggedIn(id, pass))
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
