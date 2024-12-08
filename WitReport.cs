using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bet
{
    public partial class WitReport : Form
    {
        public WitReport()
        {
            InitializeComponent();
            InitializeGrid();
        }
        private void InitializeGrid()
        {

            dataGridViewW.ColumnCount = 13; // Set the number of columns
            dataGridViewW.Columns[0].Name = "Column1";
            dataGridViewW.Columns[1].Name = "Column2";
            dataGridViewW.Columns[2].Name = "Column3";
            dataGridViewW.Columns[3].Name = "Column4";
            dataGridViewW.Columns[4].Name = "Column5";
            dataGridViewW.Columns[5].Name = "Column6";
            dataGridViewW.Columns[6].Name = "Column7";
            dataGridViewW.Columns[7].Name = "Column8";
            dataGridViewW.Columns[8].Name = "Column9";
            dataGridViewW.Columns[9].Name = "Column10";
            dataGridViewW.Columns[10].Name = "Column11";
            dataGridViewW.Columns[11].Name = "Column12";
            dataGridViewW.Columns[12].Name = DateTime.Now.ToString("yyyy-MM-dd");
            //row.Cells[0].Value = DateTime.Now.ToString("yyyy-MM-dd"); // Set current system date
        }
        public void AddRowTodataGridViewW (string value1, string value2, string value3, string value4, string value5, string value6, string value7, string value8, string value9, string value10, string value11, string value12)
        {
            dataGridViewW.Rows.Add(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        }
    }
}