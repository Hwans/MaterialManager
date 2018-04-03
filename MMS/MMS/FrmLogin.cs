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
        static string strConn = "Server=localhost;Database=test;Uid=root;Pwd=123;";
        MySqlConnection conn = new MySqlConnection(strConn);


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string pass = textBox2.Text;
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
                if ("test" != id)
                {
                    MessageBox.Show("사용자가 없습니다.");
                    ClearTexts();
                    return false;
                }
                else
                {
                    if ("1111" != pass)
                    {
                        MessageBox.Show("비밀번호가 맞지 않습니다.");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
        private void ClearTexts() {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
