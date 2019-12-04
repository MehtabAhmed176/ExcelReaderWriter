using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.BinaryFileFormat;
using ExcelLibrary.BinaryDrawingFormat;
using System.Data.OleDb;

namespace ReadWriteExcelWinform
{
    public partial class Form1 : Form
    {
        OpenFileDialog _excelFileDialog = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }
      
        private void _save_Input_Btn_Click(object sender, EventArgs e)
        {
          
           
            string file = "C:\\Users\\ROG\\Desktop\\new.xlsx";  // creating new xls file

            Workbook workbook = Workbook.Load(file);
            Worksheet sheet = workbook.Worksheets[0];

            int _lastRow = sheet.Cells.LastRowIndex;

            Column.Text = Column.Text + (_lastRow + 1).ToString();
            sheet.Cells[++_lastRow, 0] = new Cell("Mehtab");
         

            workbook.Save(file);
        


        }

     

        private void Button2_Click(object sender, EventArgs e)
        {
            _excelFileDialog.Title = "Excel File";
            _excelFileDialog.Filter = "Excel files (*.xls or .xlsx)|.xls;*.xlsx";
            if (_excelFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = _excelFileDialog.FileName;
            }
  

        }

        private void _load_DataGrid_Click(object sender, EventArgs e)
        {
           string file = _excelFileDialog.FileName;

            String name = "Items";
            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            file +
                            ";Extended Properties='Excel 8.0;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand(@"Select * From [" + file + "$]", con);
            con.Open();


            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

        }
    }
}
