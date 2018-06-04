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
    public partial class FrmInputDetail : Form
    {
        MySqlConnection conn = null;

        public FrmInputDetail()
        {
            InitializeComponent();
        }

        public FrmInputDetail(String sSEQ)
        {
            InitializeComponent();
            txtSEQ.Text = sSEQ;

            if(ClsCommon.strAdmin != "1")
            {
                this.Size = new System.Drawing.Size(647, 426);
                btnOrderCancel.Visible = false;
            }
        }

        private void FrmInputDetail_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(ClsCommon.strConn);

            //
            setComboStep();

            //
            setComboOption();

            //
            selectOrderDetail();
        }

        private void setComboStep()
        {
            Dictionary<string, string> dicStep = new Dictionary<string, string>();
            dicStep.Add("1", "☆☆☆☆★");
            dicStep.Add("2", "☆☆☆★★");
            dicStep.Add("3", "☆☆★★★");
            dicStep.Add("4", "☆★★★★");
            dicStep.Add("5", "★★★★★");

            cboStep.DataSource = new BindingSource(dicStep, null);
            cboStep.DisplayMember = "Value";
            cboStep.ValueMember = "Key";

            cboStep.SelectedIndex = 0;
        }

        private void setComboOption()
        {
            Dictionary<string, string> dicOption = new Dictionary<string, string>();

            DataSet oDs = getProductOption(txtSEQ.Text);
            foreach (DataRow options in oDs.Tables[0].Rows)
            {
                dicOption.Add(options["SSEQ"].ToString(), options["TITLE"].ToString());
            }

            //
            if (dicOption.Count > 0)
            {
                cboOption.DataSource = new BindingSource(dicOption, null);
                cboOption.DisplayMember = "Value";
                cboOption.ValueMember = "Key";

                cboOption.SelectedIndex = 0;
            }
        }

        private DataSet getProductOption(String pSeq)
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();

                String sql = "";
                sql = sql + " SELECT SSEQ, TITLE ";
                sql = sql + " FROM TB_PRODUCT_OPTION ";
                sql = sql + " WHERE SEQ IN (SELECT PSEQ FROM TB_ORDER WHERE SEQ = '" + pSeq + "') ";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "TB_PRODUCT_OPTION");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }

        private void selectOrderDetail()
        {
            DataSet oDs = null;
            try
            {
                //
                String sSeq = txtSEQ.Text;
                oDs = getOrder(sSeq);
                if (oDs.Tables.Count > 0)
                {
                    DataRow oRows = oDs.Tables[0].Rows[0];
                    String imageURL = "";

                    if (oRows["IMAGE"].ToString() != "")
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

                    //
                    txtSEQ.Text = oRows["SEQ"].ToString();
                    txtPSEQ.Text = oRows["PSEQ"].ToString();
                    txtTitle.Text = oRows["TITLE"].ToString();
                    cboOption.SelectedValue = oRows["PSSEQ"].ToString();
                    cboStep.SelectedValue = oRows["STEP"].ToString();
                    txtETC.Text = oRows["ETC"].ToString();
                    //발주정보
                    txtQty.Text = oRows["QTY"].ToString();
                    txtEtc2.Text = oRows["ETC2"].ToString();
                    //입고정보
                    txtQty2.Text = oRows["QTY2"].ToString();
                    txtEtc3.Text = oRows["ETC3"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataSet getOrder(String pSeq)
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();

                String sql = "";
                sql = sql + " SELECT O.SEQ, O.PSEQ, O.PSSEQ, O.STEP, O.QTY, O.QTY2, O.ETC, O.ETC2, O.ETC3, P.CODE, P.TITLE, P.TITLE2, P.IMAGE, PO.TITLE AS OPTION_TITLE ";
                sql = sql + " FROM TB_ORDER O ";
                sql = sql + " LEFT JOIN TB_PRODUCT P ON O.PSEQ = P.SEQ ";
                sql = sql + " LEFT JOIN TB_PRODUCT_OPTION PO ON O.PSSEQ = PO.SSEQ ";
                sql = sql + " WHERE O.SEQ = '" + pSeq + "' ";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "TB_ORDER");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("저장하시겠습니까?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    saveOrder();
                    MessageBox.Show("저장하였습니다.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveOrder()
        {
            try
            {
                String sql = "";
                sql = sql + " UPDATE TB_ORDER SET  ";
                sql = sql + " QTY2=@QTY2, ";
                sql = sql + " ETC3=@ETC3, ";
                sql = sql + " STATUS=3, ";
                sql = sql + " INPUT_DATE=NOW()  ";
                sql = sql + " WHERE SEQ=@SEQ ";

                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = sql;
                oCommand.Parameters.Add("@QTY2", MySqlDbType.Int16, 11);
                oCommand.Parameters.Add("@ETC3", MySqlDbType.VarChar, 400);
                oCommand.Parameters.Add("@SEQ", MySqlDbType.Int16, 11);

                oCommand.Parameters[0].Value = txtQty2.Text;
                oCommand.Parameters[1].Value = txtEtc3.Text;
                oCommand.Parameters[2].Value = txtSEQ.Text;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrderCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("취소하시겠습니까?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    saveOrder();
                    MessageBox.Show("취소하였습니다.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cancelOrder()
        {
            try
            {
                String sql = "";
                sql = sql + " UPDATE TB_ORDER SET  ";
                sql = sql + " QTY2=0, ";
                sql = sql + " ETC3='', ";
                sql = sql + " STATUS=1 ";
                sql = sql + " WHERE SEQ=@SEQ ";

                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = sql;
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
    }
}
