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
    public partial class FrmItemList : Form
    {
        public FrmItemList()
        {
            InitializeComponent();
        }

        private void FrmItemList_Load(object sender, EventArgs e)
        {
            itemGrid.BorderStyle = BorderStyle.FixedSingle;
            itemGrid.ColumnsCount = 8;
            itemGrid.FixedRows = 1;
            itemGrid.Rows.Insert(0);
            itemGrid.Columns[0].Width = 100;
            itemGrid.Columns[1].Width = 240;
            itemGrid[0, 0] = new SourceGrid2.Cells.Real.ColumnHeader("No");
            itemGrid[0, 1] = new SourceGrid2.Cells.Real.ColumnHeader("상품명");


            for (int r = 1; r < 10; r++)
            {
                itemGrid.Rows.Insert(r);
                itemGrid[r, 0] = new SourceGrid2.Cells.Real.Cell("Hello " + r.ToString(), typeof(string));
                itemGrid[r, 1] = new SourceGrid2.Cells.Real.Cell(DateTime.Today, typeof(DateTime));
                //itemGrid[r, 2] = new SourceGrid2.Cells.Real.CheckBox(true);
            }
            itemGrid.AutoSizeAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
