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

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application oExcel = null;
            Excel.Workbook oWorkbook = null;
            Excel.Worksheet oWorksheet = null;

            DataTable oDt = new DataTable();
            DataRow oRow = null;

            String path = textBox1.Text;

            try
            {
                oExcel = new Excel.Application();
                oWorkbook = oExcel.Workbooks.Open(path);
                oWorksheet = oWorkbook.Worksheets.get_Item(1) as Excel.Worksheet;
                Excel.Range oRange = oWorksheet.UsedRange;

                int rowCount = oRange.Rows.Count;
                int colCount = oRange.Columns.Count;


                oDt.Columns.Add(new DataColumn("CODE", typeof(string)));
                oDt.Columns.Add(new DataColumn("NAME", typeof(string)));
                oDt.Columns.Add(new DataColumn("OPTION", typeof(string)));
                oDt.Columns.Add(new DataColumn("IMAGE", typeof(string)));

                for (int iRow = 2; iRow <= rowCount; iRow++)
                {
                    //
                    oRow = oDt.NewRow();

                    if (oRange.Cells[iRow, 1] != null)
                    {
                        oRow["CODE"] = oRange.Cells[iRow, 1].Value2.ToString();
                    }
                    if (oRange.Cells[iRow, 3] != null)
                    {
                        oRow["NAME"] = oRange.Cells[iRow, 3].Value2.ToString();
                    }
                    if (oRange.Cells[iRow, 5] != null)
                    {
                        oRow["OPTION"] = oRange.Cells[iRow, 5].Value2.ToString();
                    }
                    if (oRange.Cells[iRow, 6] != null)
                    {
                        oRow["IMAGE"] = oRange.Cells[iRow, 6].Value2.ToString();
                    }

                    //
                    oDt.Rows.Add(oRow);
                }
                dataGridView1.DataSource = oDt;

                oWorkbook.Close(true);
                oExcel.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Excel Files(*.xls; *.xlsx)|*.xls;*.xlsx;";

            openFile.ShowDialog();

            if (openFile.FileNames.Length > 0)
            {
                foreach (string filename in openFile.FileNames)
                {
                    this.textBox1.Text = filename;
                }
            }
        }
    }
}
