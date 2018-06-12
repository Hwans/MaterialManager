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
using System.Reflection;

using Excel = Microsoft.Office.Interop.Excel;

namespace MMS
{
    public partial class FrmOrderList2 : Form
    {
        MySqlConnection conn = null;

        public FrmOrderList2()
        {
            InitializeComponent();
        }

        private void FrmOrderList2_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(ClsCommon.strConn);
                //
                sDate.Value = DateTime.Today.AddDays(-3);
                //
                cboQuery.SelectedIndex = 0;
                //
                selectOrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                orderGrid.Rows.Clear();

                //
                String pSDate = sDate.Text;
                String pEDate = eDate.Text;

                oDs = getOrderList(pSDate, pEDate);
                if (oDs.Tables.Count > 0)
                {
                    int idx = 0;
                    foreach (DataRow oRows in oDs.Tables[0].Rows)
                    {
                        orderGrid.Rows.Add();
                        orderGrid[0, idx].Value = idx + 1;
                        orderGrid[1, idx].Value = oRows["BIZ_NAME"].ToString();
                        orderGrid[2, idx].Value = oRows["P_TITLE"].ToString();
                        orderGrid[3, idx].Value = oRows["PO_TITLE"].ToString();
                        orderGrid[4, idx].Value = getStatus(oRows["STATUS"].ToString());
                        orderGrid[5, idx].Value = getStep(oRows["STEP"].ToString());
                        orderGrid[6, idx].Value = oRows["ETC"].ToString();
                        orderGrid[7, idx].Value = oRows["QTY"].ToString();
                        orderGrid[8, idx].Value = oRows["REQUEST_DATE"];
                        orderGrid[9, idx].Value = oRows["USER_NAME"].ToString();
                        orderGrid[10, idx].Value = oRows["SEQ"];
                        orderGrid[11, idx].Value = oRows["PSEQ"];
                        orderGrid[12, idx].Value = oRows["PSSEQ"];
                        orderGrid[13, idx].Value = oRows["BIZ_SEQ"];

                        if( Int16.Parse(oRows["QTY"].ToString()) > 0 )
                        {
                            orderGrid.Rows[idx].DefaultCellStyle.BackColor = Color.LightBlue;
                        }

                        if (Int16.Parse(oRows["EMPTY_YN"].ToString()) > 0)
                        {
                            orderGrid.Rows[idx].DefaultCellStyle.BackColor = Color.PaleVioletRed;
                        }

                        idx = idx + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private String getStatus(String sCode)
        {
            String sReturn = "";
            try
            {
                if(sCode=="1")
                {
                    sReturn = "발주요청";
                }
                else if (sCode == "2")
                {
                    sReturn = "발주";
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return sReturn;
        }

        private DataSet getOrderList(String pSDate, String pEDate)
        {
            DataSet oDs = null;
            try
            {
                oDs = new DataSet();

                string sql = "";
                sql = sql + " SELECT O.SEQ, O.PSEQ, O.PSSEQ, P.TITLE AS P_TITLE, PO.TITLE AS PO_TITLE, O.STEP, O.EMPTY_YN, O.QTY, O.ETC, O.STATUS, O.REQUEST_DATE, O.USER_NAME, C.SEQ AS BIZ_SEQ, C.BIZ_NAME ";
                sql = sql + " FROM TB_ORDER O ";
                sql = sql + " LEFT JOIN TB_PRODUCT P ON O.PSEQ = P.SEQ ";
                sql = sql + " LEFT JOIN TB_PRODUCT_OPTION PO ON O.PSSEQ = PO.SSEQ ";
                sql = sql + " LEFT JOIN TB_COMPANY C ON P.BIZ_SEQ = C.SEQ ";
                if(chkView.Checked == true)
                {
                    sql = sql + " WHERE O.STATUS IN (1) ";
                }
                else
                {
                    sql = sql + " WHERE O.STATUS IN (1, 2) ";
                }
                sql = sql + " AND DATE(O.REQUEST_DATE) BETWEEN '" + pSDate + "' AND '" + pEDate + "' ";
                sql = sql + " AND P.TITLE LIKE '%" + txtQuery.Text + "%' ";
                sql = sql + " ORDER BY O.REQUEST_DATE, P.TITLE ";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(oDs, "TB_ORDER");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return oDs;
        }

        private String getStep(String pValue)
        {
            switch (pValue)
            {
                case "1":
                    return "☆☆☆☆★";
                case "2":
                    return "☆☆☆★★";
                case "3":
                    return "☆☆★★★";
                case "4":
                    return "☆★★★★";
                case "5":
                    return "★★★★★";
                default:
                    return "☆☆☆☆★";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료할까요?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmItemList frmItem = new FrmItemList();
            frmItem.ShowDialog();

            try
            {
                selectOrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void orderGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String sSEQ = orderGrid[10, e.RowIndex].Value.ToString();
            FrmOrderDetail2 frmOrderDetail2 = new FrmOrderDetail2(sSEQ);
            frmOrderDetail2.ShowDialog();

            try
            {
                selectOrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

            saveFileDialog1.FileName = "TempName";
            saveFileDialog1.DefaultExt = "xls";
            saveFileDialog1.Filter = "Excel files (*.xls)|*.xls";
            saveFileDialog1.InitialDirectory = "c:\\";

            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                int num = 0;
                object missingType = Type.Missing;

                Excel.Application objApp;
                Excel._Workbook objBook;
                Excel.Workbooks objBooks;
                Excel.Sheets objSheets;
                Excel._Worksheet objSheet;
                Excel.Range range;

                string[] headers = new string[orderGrid.ColumnCount];
                string[] columns = new string[orderGrid.ColumnCount];

                for (int c = 0; c < orderGrid.ColumnCount; c++)
                {
                    headers[c] = orderGrid.Rows[0].Cells[c].OwningColumn.HeaderText.ToString();
                    num = c + 65;
                    columns[c] = Convert.ToString((char)num);
                }

                try
                {
                    objApp = new Excel.Application();
                    objBooks = objApp.Workbooks;
                    objBook = objBooks.Add(Missing.Value);
                    objSheets = objBook.Worksheets;
                    objSheet = (Excel._Worksheet)objSheets.get_Item(1);

                    for (int i = 0; i < orderGrid.RowCount - 1; i++)
                    {
                        for (int j = 0; j < orderGrid.ColumnCount; j++)
                        {
                            range = objSheet.get_Range(columns[j] + Convert.ToString(i + 2), Missing.Value);
                            range.set_Value(Missing.Value, orderGrid.Rows[i].Cells[j].Value.ToString());
                        }
                    }

                    objApp.Visible = false;
                    objApp.UserControl = false;

                    objBook.SaveAs(saveFileDialog1.FileName,
                                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,
                                    missingType, missingType, missingType, missingType,
                                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                                    missingType, missingType, missingType, missingType, missingType);
                    objBook.Close(false, missingType, missingType);

                    Cursor.Current = Cursors.Default;

                    MessageBox.Show("Save Success!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FrmOrderList2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
            {
                try
                {
                    String sText = "";
                    FrmFindField frmFindField = new FrmFindField();
                    if(frmFindField.ShowDialog() == DialogResult.OK)
                    {
                        sText = frmFindField.SearchText;
                        if(sText != "")
                        {
                            int iRow = -1;
                            foreach (DataGridViewRow row in orderGrid.Rows)
                            {
                                if (row.Cells[row.Index].Value.ToString().Equals(sText))
                                {
                                    orderGrid.Rows[row.Index].Selected = true;
                                    break;
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

        private void orderGrid_KeyDown(object sender, KeyEventArgs e)
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
                            foreach (DataGridViewRow row in orderGrid.Rows)
                            {
                                orderGrid.Rows[row.Index].Selected = false;
                            }

                            foreach (DataGridViewRow row in orderGrid.Rows)
                            {
                                if(row.Cells[2].Value != null && row.Cells[2].Value.ToString().Contains(sText))
                                {
                                    orderGrid.Rows[row.Index].Selected = true;
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
