using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace MMS
{
    public partial class FrmProductFile : Form
    {
        MySqlConnection conn = null;

        public FrmProductFile()
        {
            InitializeComponent();
        }

        private void FrmProductFile_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(ClsCommon.strConn);
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Excel Files(*.xls; *.xlsx)|*.xls;*.xlsx;";

                openFile.ShowDialog();

                if (openFile.FileNames.Length > 0)
                {
                    foreach (string filename in openFile.FileNames)
                    {
                        this.txtFilePath.Text = filename;
                    }

                    //
                    setGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setGrid()
        {
            Excel.Application oExcel = null;
            Excel.Workbook oWorkbook = null;
            Excel.Worksheet oWorksheet = null;

            DataTable oDt = new DataTable();
            DataRow oRow = null;

            String path = txtFilePath.Text;

            try
            {
                oExcel = new Excel.Application();
                oWorkbook = oExcel.Workbooks.Open(path);
                oWorksheet = oWorkbook.Worksheets.get_Item(1) as Excel.Worksheet;
                Excel.Range oRange = oWorksheet.UsedRange;

                int rowCount = oRange.Rows.Count;
                int colCount = oRange.Columns.Count;

                oDt.Columns.Add(new DataColumn("상품코드", typeof(string)));
                oDt.Columns.Add(new DataColumn("상품명", typeof(string)));
                oDt.Columns.Add(new DataColumn("옵션", typeof(string)));
                oDt.Columns.Add(new DataColumn("이미지", typeof(string)));

                for (int iRow = 2; iRow <= rowCount; iRow++)
                {
                    //
                    oRow = oDt.NewRow();

                    if (oRange.Cells[iRow, 1].Value2 != null)
                    {
                        oRow["상품코드"] = oRange.Cells[iRow, 1].Value2.ToString();
                    }
                    if (oRange.Cells[iRow, 3].Value2 != null)
                    {
                        oRow["상품명"] = oRange.Cells[iRow, 3].Value2.ToString();
                    }
                    if (oRange.Cells[iRow, 5].Value2 != null)
                    {
                        oRow["옵션"] = oRange.Cells[iRow, 5].Value2.ToString();
                    }
                    if (oRange.Cells[iRow, 6].Value2 != null)
                    {
                        oRow["이미지"] = oRange.Cells[iRow, 6].Value2.ToString();
                    }

                    //
                    oDt.Rows.Add(oRow);
                }
                itemGrid.DataSource = oDt;

                oWorkbook.Close(true);
                oExcel.Quit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ReleaseExcelObject(oWorksheet);
                ReleaseExcelObject(oWorkbook);
                ReleaseExcelObject(oExcel);
            }
        }

        private void ReleaseExcelObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                String sCode = "";
                String sTitle = "";
                String sOption = "";
                String sImage = "";

                for(int iRow=0; iRow < itemGrid.RowCount -1; iRow++)
                {
                    sCode = itemGrid.Rows[iRow].Cells[0].Value.ToString();
                    sTitle = itemGrid.Rows[iRow].Cells[1].Value.ToString();
                    sOption = itemGrid.Rows[iRow].Cells[2].Value.ToString();
                    sImage = itemGrid.Rows[iRow].Cells[3].Value.ToString();

                    if (sOption == null || sOption == "")
                    {
                        saveProduct(sCode, sTitle, sImage);
                    }
                    else
                    {
                        
                        int seq = saveProduct(sCode, sTitle, sImage);
                        
                        if (seq > 0)
                        {
                            String[] arryOption = getOptionList(sOption);
                            if (arryOption != null)
                            {
                                for (int idx = 0; idx < arryOption.Length -1; idx++)
                                {
                                    saveProductOption(seq, arryOption[idx]);
                                }
                            }
                        }
                    }
                }
                MessageBox.Show("저장하였습니다.");

                itemGrid.DataSource = null;
                txtFilePath.Text = "";
           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private String[] getOptionList(String options)
        {

            String[] arryOption = null;

            try
            {
                if (options == null || options == "")
                {
                    return null;
                }

                if (options.IndexOf("수량") > 1)
                {
                    options = options.Substring(0, options.IndexOf("수량") - 2);
                }
                String[] arryOptions = options.Split(new string[] { "//" }, StringSplitOptions.None);

                if (arryOptions.Length > 1)
                {
                    int iStart = 0;
                    int iEnd = 0;
                    String[] arryTmp = new String[2];

                    iStart = arryOptions[0].IndexOf("{");
                    iEnd = arryOptions[0].IndexOf("}");
                    arryTmp[0] = arryOptions[0].Substring(iStart + 1, iEnd - iStart -1);

                    iStart = arryOptions[1].IndexOf("{");
                    iEnd = arryOptions[1].IndexOf("}");
                    arryTmp[1] = arryOptions[1].Substring(iStart + 1, iEnd - iStart - 1);

                    int idx = 0;
                    arryOption = new String[arryTmp[0].Split('|').Length * arryTmp[1].Split('|').Length];
                    for (int i = 0; i < arryTmp[0].Split('|').Length; i++)
                    {
                        for (int j = 0; j < arryTmp[1].Split('|').Length; j++)
                        {
                            arryOption[idx] = arryTmp[0].Split('|')[i] + "_" + arryTmp[1].Split('|')[j];
                            idx++;
                        }
                    }
                }
                else
                {
                    int iStart = 0;
                    int iEnd = 0;

                    iStart = arryOptions[0].IndexOf("{");
                    iEnd = arryOptions[0].IndexOf("}");

                    String option = arryOptions[0].Substring(iStart + 1, iEnd - iStart - 1);
                    String[] arryTmp = option.Split('|');
                    arryOption = new String[arryTmp.Length];
                    for (int i = 0; i < arryTmp.Length; i++)
                    {
                        arryOption[i] = arryTmp[i];
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return arryOption;
        }


        private int saveProduct(String sCode, String sTitle, String sImage)
        {
            int seq = 0;
            try
            {
                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = "INSERT INTO TB_PRODUCT( CODE, TITLE, IMAGE, REG_DATE ) VALUES( @CODE, @TITLE, @IMAGE, NOW() )";
                oCommand.Parameters.Add("@CODE", MySqlDbType.VarChar, 50);
                oCommand.Parameters.Add("@TITLE", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@IMAGE", MySqlDbType.VarChar, 200);
                oCommand.Parameters.Add("@SEQ", MySqlDbType.Int16, 4).Direction = ParameterDirection.Output;

                oCommand.Parameters[0].Value = sCode;
                oCommand.Parameters[1].Value = sTitle;
                oCommand.Parameters[2].Value = sImage;
                oCommand.ExecuteNonQuery();

                seq = Convert.ToInt32(oCommand.LastInsertedId);

                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return seq;
        }

        private void saveProductOption(int seq, String sTitle)
        {
            try
            {
                conn.Open();

                MySqlCommand oCommand = new MySqlCommand();
                oCommand.Connection = conn;
                oCommand.CommandText = "INSERT INTO TB_PRODUCT_OPTION( SEQ, TITLE, REG_DATE) VALUE( @SEQ, @TITLE, NOW() )";
                oCommand.Parameters.Add("@SEQ", MySqlDbType.Int16, 11);
                oCommand.Parameters.Add("@TITLE", MySqlDbType.VarChar, 200);
                
                oCommand.Parameters[0].Value = seq;
                oCommand.Parameters[1].Value = sTitle;
                oCommand.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
