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
    public partial class FrmItem : Form
    {
        MySqlConnection conn = null;

        public FrmItem()
        {
            InitializeComponent();
        }

        private void FrmItemList_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(ClsCommon.strConn);

            cboQuery.SelectedIndex = 0;
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                itemGrid.Rows.Clear();
                selectOrderList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void selectOrderList()
        {
            DataSet oDs = null;
            try
            {
                String pValue = txtQuery.Text;
                oDs = getProductList("", pValue);
                if (oDs.Tables.Count > 0)
                {
                    int idx = 0;
                    foreach (DataRow oRows in oDs.Tables[0].Rows)
                    {
                        itemGrid.Rows.Add();
                        itemGrid[0, idx].Value = idx + 1;
                        itemGrid[1, idx].Value = oRows["TITLE"];
                        itemGrid[2, idx].Value = oRows["SEQ"];
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
                string sql = "SELECT SEQ, TITLE FROM TB_PRODUCT WHERE TITLE LIKE '%" + pValue + "%' ";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "TB_PRODUCT");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
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

                    if(oRows["IMAGE"].ToString() != "")
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
                    if(cboOption.Items.Count > 0)
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

        private DataSet getProduct(String pSeq)
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();

                String sql = "";
                sql = sql + " SELECT P.SEQ, P.CODE, P.TITLE, P.TITLE2, P.IMAGE, PO.SSEQ, PO.TITLE AS OPTION_TITLE ";
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("저장하시겠습니까?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    saveItem();
                    MessageBox.Show("저장하였습니다.");
                    initText();
                }
                catch(Exception ex)
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
                if(cboStep.SelectedIndex > 0)
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
            catch(Exception ex)
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
            txtSSEQ.Text = "";

            if (pImage.Image != null)
            {
                pImage.Image = null;
            }

            txtTitle.Text = "";
            cboOption.Items.Clear();
            cboOption.Text = "";
            cboStep.SelectedIndex = 0;
            txtETC.Text = "";
        }
    }
}
