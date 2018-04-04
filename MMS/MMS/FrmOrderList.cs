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
    public partial class FrmOrderList : Form
    {
        static string sTitle = "상품발주";

        public FrmOrderList()
        {
            InitializeComponent();
        }

        private void FrmOrderList_Load(object sender, EventArgs e)
        {
            orderGrid.BorderStyle = BorderStyle.FixedSingle;
            orderGrid.ColumnsCount = 8;
            orderGrid.FixedRows = 1;
            orderGrid.Rows.Insert(0);
            orderGrid.Columns[1].Width = 480;
            orderGrid[0, 0] = new SourceGrid2.Cells.Real.ColumnHeader("No");
            orderGrid[0, 1] = new SourceGrid2.Cells.Real.ColumnHeader("상품명");
            orderGrid[0, 2] = new SourceGrid2.Cells.Real.ColumnHeader("옵션명");
            orderGrid[0, 3] = new SourceGrid2.Cells.Real.ColumnHeader("발주상태");
            orderGrid[0, 4] = new SourceGrid2.Cells.Real.ColumnHeader("중요도");
            orderGrid[0, 5] = new SourceGrid2.Cells.Real.ColumnHeader("비고");
            orderGrid[0, 6] = new SourceGrid2.Cells.Real.ColumnHeader("발주요청일");
            orderGrid[0, 7] = new SourceGrid2.Cells.Real.ColumnHeader("발주요청자");

            for (int r = 1; r < 10; r++)
            {
                orderGrid.Rows.Insert(r);
                orderGrid[r, 0] = new SourceGrid2.Cells.Real.Cell("Hello "+ r.ToString(), typeof(string));
                orderGrid[r, 1] = new SourceGrid2.Cells.Real.Cell(DateTime.Today, typeof(DateTime));
                orderGrid[r, 2] = new SourceGrid2.Cells.Real.CheckBox(true);
            }
            orderGrid.AutoSizeAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("종료할까요?", sTitle, MessageBoxButtons.YesNo) == DialogResult.Yes )
            {
                this.Close();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                selectOrderList();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectOrderList()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmItemList frmItemList = new FrmItemList();
            frmItemList.Show();
        }
    }
}
