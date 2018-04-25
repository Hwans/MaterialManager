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
    public partial class FrmItemDetail : Form
    {
        MySqlConnection conn = null;

        public FrmItemDetail()
        {
            InitializeComponent();
        }

        public FrmItemDetail(String sSEQ)
        {
            InitializeComponent();
            txtSEQ.Text = "sSEQ";
        }

        private void FrmItemDetail_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(ClsCommon.strConn);

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("저장하시겠습니까?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    saveItem();
                    MessageBox.Show("저장하였습니다.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveItem()
        {
            try
            {
                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = "INSERT INTO TB_ORDER( PSEQ, PSSEQ, STEP, ETC, REQUEST_DATE, USER_NAME ) VALUES(@PSEQ, @PSSEQ, @STEP, @ETC,  NOW(), @USER_NAME)";
                oCommand.Parameters.Add("@PSEQ", MySqlDbType.Int16, 10);
                oCommand.Parameters.Add("@PSSEQ", MySqlDbType.Int16, 10);
                oCommand.Parameters.Add("@STEP", MySqlDbType.Int16, 10);
                oCommand.Parameters.Add("@ETC", MySqlDbType.VarChar, 400);
                oCommand.Parameters.Add("@USER_NAME", MySqlDbType.VarChar, 50);

                int nStep = 1;
                if (cboStep.SelectedIndex > 0)
                {
                    nStep = cboStep.SelectedIndex;
                }

                oCommand.Parameters[0].Value = txtSEQ.Text;
                oCommand.Parameters[1].Value = txtSSEQ.Text;
                oCommand.Parameters[2].Value = nStep;
                oCommand.Parameters[3].Value = txtETC.Text;
                oCommand.Parameters[4].Value = "";
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
                    deleteItem();
                    MessageBox.Show("삭제하였습니다.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deleteItem()
        {
            try
            {
                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = "INSERT INTO TB_ORDER( PSEQ, PSSEQ, STEP, ETC, REQUEST_DATE, USER_NAME ) VALUES(@PSEQ, @PSSEQ, @STEP, @ETC,  NOW(), @USER_NAME)";
                oCommand.Parameters.Add("@PSEQ", MySqlDbType.Int16, 10);
                oCommand.Parameters.Add("@PSSEQ", MySqlDbType.Int16, 10);
                oCommand.Parameters.Add("@STEP", MySqlDbType.Int16, 10);
                oCommand.Parameters.Add("@ETC", MySqlDbType.VarChar, 400);
                oCommand.Parameters.Add("@USER_NAME", MySqlDbType.VarChar, 50);

                int nStep = 1;
                if (cboStep.SelectedIndex > 0)
                {
                    nStep = cboStep.SelectedIndex;
                }

                oCommand.Parameters[0].Value = txtSEQ.Text;
                oCommand.Parameters[1].Value = txtSSEQ.Text;
                oCommand.Parameters[2].Value = nStep;
                oCommand.Parameters[3].Value = txtETC.Text;
                oCommand.Parameters[4].Value = "";
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
            if (MessageBox.Show("창을 닫으시겠습니까?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
