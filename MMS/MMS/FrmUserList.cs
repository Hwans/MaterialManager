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
    public partial class FrmUserList : Form
    {
        public FrmUserList()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            grid1.BorderStyle = BorderStyle.FixedSingle;
            grid1.ColumnsCount = 3;
            grid1.Columns[1].Width = 240;
            grid1.FixedRows = 1;
            grid1.Rows.Insert(0);
            grid1[0, 0] = new SourceGrid2.Cells.Real.ColumnHeader("String");
            grid1[0, 1] = new SourceGrid2.Cells.Real.ColumnHeader("DateTime");
            grid1[0, 2] = new SourceGrid2.Cells.Real.ColumnHeader("CheckBox");
            for (int r = 1; r < 10; r++)
            {
                grid1.Rows.Insert(r);
                grid1[r, 0] = new SourceGrid2.Cells.Real.Cell("Hello "
                  + r.ToString(), typeof(string));
                grid1[r, 1] = new SourceGrid2.Cells.Real.Cell(
                  DateTime.Today, typeof(DateTime));
                grid1[r, 2] = new SourceGrid2.Cells.Real.CheckBox(true);
            }
            //grid1.AutoSizeAll();
        }
    }
}
