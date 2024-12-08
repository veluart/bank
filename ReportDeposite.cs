using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using ClosedXML.Excel;

namespace bet
{
    public partial class ReportDeposite : Form
    {
        public ReportDeposite()
        {
            InitializeComponent();
            InitializeGrid();
        }
        private void InitializeGrid()
        { 
            dataGridView.ColumnCount = 13; // Set the number of columns
            dataGridView.Columns[0].Name = "Column1";
            dataGridView.Columns[1].Name = "Column2";
            dataGridView.Columns[2].Name = "Column3";
            dataGridView.Columns[3].Name = "Column4";
            dataGridView.Columns[4].Name = "Column5";
            dataGridView.Columns[5].Name = "Column6";
            dataGridView.Columns[6].Name = "Column7";
            dataGridView.Columns[7].Name = "Column8";
            dataGridView.Columns[8].Name = "Column9";
            dataGridView.Columns[9].Name = "Column10";
            dataGridView.Columns[10].Name = "Column11";
            dataGridView.Columns[11].Name = "Column12";
            dataGridView.Columns[12].Name = "Column13";
        }
        public void AddRowToGridView(string value1, string value2, string value3, string value4, string value5, string value6, string value7, string value8, string value9, string value10, string value11, string value12)
        {
            dataGridView.Rows.Add(DateTime.Now.ToString("yyyy-MM-dd"),value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        }
        private void btnSavePDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog { Filter = "PDF files (*.pdf)|*.pdf" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = dialog.FileName;
                    using (var writer = new PdfWriter(filePath))
                    using (var pdf = new PdfDocument(writer))
                    using (var document = new Document(pdf))
                    {
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            string rowData = string.Join(" ", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString() ?? ""));
                            document.Add(new Paragraph(rowData));
                        }
                    }
                }
            }
        }
        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog { Filter = "Excel files (*.xlsx)|*.xlsx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = dialog.FileName;
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("DataGridView Data");
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dataGridView.Columns[i].HeaderText;
                        }
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = (XLCellValue)dataGridView.Rows[i].Cells[j].Value;
                            }
                        }
                        workbook.SaveAs(filePath);
                    }
                }
            }
        }
    }
}
