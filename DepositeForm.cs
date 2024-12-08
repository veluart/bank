using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bet
{
    public partial class DepositeForm : Form
    {
        private ReportDeposite repdepForm; // Keep a single instance of Form3
        private DepositeForm depForm;
        public DepositeForm()
        {
            InitializeComponent();
            
            // Subscribe to the TextChanged event of the TextBox
            DepNote.TextChanged += TxtInput_TextChanged;

            // Initial state: disable the button
            buttonDepSubmit.Enabled = false;
            repdepForm = new ReportDeposite();
        }
        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            // Enable or disable the button based on whether the TextBox is empty
            buttonDepSubmit.Enabled = !string.IsNullOrWhiteSpace(DepNote.Text);
        }
        Double d2000, c2000, d500, c500, d200, c200, d100, c100, d50, c50, d20, c20, d10, c10, d5, c5, d2, c2, d1, c1, dtq, dta;

        private void Ds2000_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ds2000.Text))
            {
                Ds2000.Text = "0";
            }
            d2000 = Convert.ToDouble(Ds2000.Text);
            Ds2000.Text = d2000.ToString();
            c2000 = (int)(2000 * d2000);
            DA2000.Text = c2000.ToString();
            dtq = (int)(d1 + d2 + d5 + d10 + d20 + d50 + d100 + d200 + d500 + d2000);
            dta = (int)(c1 + c2 + c5 + c10 + c20 + c50 + c100 + c200 + c500 + c2000);
            Dtotal.Text = dtq.ToString();
            DAtotal.Text = dta.ToString();
        }
        private void Ds500_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ds500.Text))
            {
                Ds500.Text = "0";
            }
            d500 = Convert.ToDouble(Ds500.Text);
            Ds500.Text = d500.ToString();
            c500 = (int)(500 * d500);
            DA500.Text = c500.ToString();
            dtq = (int)(d1 + d2 + d5 + d10 + d20 + d50 + d100 + d200 + d500 + d2000);
            dta = (int)(c1 + c2 + c5 + c10 + c20 + c50 + c100 + c200 + c500 + c2000);
            Dtotal.Text = dtq.ToString();
            DAtotal.Text = dta.ToString();
        }
        private void Ds200_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ds200.Text))
            {
                Ds200.Text = "0";
            }
            d200 = Convert.ToDouble(Ds200.Text);
            Ds200.Text = d200.ToString();
            c200 = (int)(200 * d200);
            DA200.Text = c200.ToString();
            dtq = (int)(d1 + d2 + d5 + d10 + d20 + d50 + d100 + d200 + d500 + d2000);
            dta = (int)(c1 + c2 + c5 + c10 + c20 + c50 + c100 + c200 + c500 + c2000);
            Dtotal.Text = dtq.ToString();
            DAtotal.Text = dta.ToString();
        }
        private void Ds100_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ds100.Text))
            {
                Ds100.Text = "0";
            }
            d100 = Convert.ToDouble(Ds100.Text);
            Ds100.Text = d100.ToString();
            c100 = (int)(100 * d100);
            DA100.Text = c100.ToString();
            dtq = (int)(d1 + d2 + d5 + d10 + d20 + d50 + d100 + d200 + d500 + d2000);
            dta = (int)(c1 + c2 + c5 + c10 + c20 + c50 + c100 + c200 + c500 + c2000);
            Dtotal.Text = dtq.ToString();
            DAtotal.Text = dta.ToString();
        }
        private void Ds50_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ds50.Text))
            {
                Ds50.Text = "0";
            }
            d50 = Convert.ToDouble(Ds50.Text);
            Ds50.Text = d50.ToString();
            c50 = (int)(50 * d50);
            DA50.Text = c50.ToString();
            dtq = (int)(d1 + d2 + d5 + d10 + d20 + d50 + d100 + d200 + d500 + d2000);
            dta = (int)(c1 + c2 + c5 + c10 + c20 + c50 + c100 + c200 + c500 + c2000);
            Dtotal.Text = dtq.ToString();
            DAtotal.Text = dta.ToString();
        }
        private void Ds20_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ds20.Text))
            {
                Ds20.Text = "0";
            }
            d20 = Convert.ToDouble(Ds20.Text);
            Ds20.Text = d20.ToString();
            c20 = (int)(20 * d20);
            DA20.Text = c20.ToString();
            dtq = (int)(d1 + d2 + d5 + d10 + d20 + d50 + d100 + d200 + d500 + d2000);
            dta = (int)(c1 + c2 + c5 + c10 + c20 + c50 + c100 + c200 + c500 + c2000);
            Dtotal.Text = dtq.ToString();
            DAtotal.Text = dta.ToString();
        }
        private void Ds10_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ds10.Text))
            {
                Ds10.Text = "0";
            }
            d10 = Convert.ToDouble(Ds10.Text);
            Ds10.Text = d10.ToString();
            c10 = (int)(10 * d10);
            DA10.Text = c10.ToString();
            dtq = (int)(d1 + d2 + d5 + d10 + d20 + d50 + d100 + d200 + d500 + d2000);
            dta = (int)(c1 + c2 + c5 + c10 + c20 + c50 + c100 + c200 + c500 + c2000);
            Dtotal.Text = dtq.ToString();
            DAtotal.Text = dta.ToString();
        }
        private void Ds5_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ds5.Text))
            {
                Ds5.Text = "0";
            }
            d5 = Convert.ToDouble(Ds5.Text);
            Ds5.Text = d5.ToString();
            c5 = (int)(5 * d5);
            DA5.Text = c5.ToString();
            dtq = (int)(d1 + d2 + d5 + d10 + d20 + d50 + d100 + d200 + d500 + d2000);
            dta = (int)(c1 + c2 + c5 + c10 + c20 + c50 + c100 + c200 + c500 + c2000);
            Dtotal.Text = dtq.ToString();
            DAtotal.Text = dta.ToString();
        }
        private void Ds2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ds2.Text))
            {
                Ds2.Text = "0";
            }
            d2 = Convert.ToDouble(Ds2.Text);
            Ds2.Text = d2.ToString();
            c2 = (int)(2 * d2);
            DA2.Text = c2.ToString();
            dtq = (int)(d1 + d2 + d5 + d10 + d20 + d50 + d100 + d200 + d500 + d2000);
            dta = (int)(c1 + c2 + c5 + c10 + c20 + c50 + c100 + c200 + c500 + c2000);
            Dtotal.Text = dtq.ToString();
            DAtotal.Text = dta.ToString();
        }
        private void Ds1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ds1.Text))
            {
                Ds1.Text = "0";
            }
            d1 = Convert.ToDouble(Ds1.Text);
            Ds1.Text = d1.ToString();
            c1 = (int)(1 * d1);
            DA1.Text = c1.ToString();
            dtq = (int)(d1 + d2 + d5 + d10 + d20 + d50 + d100 + d200 + d500 + d2000);
            dta = (int)(c1 + c2 + c5 + c10 + c20 + c50 + c100 + c200 + c500 + c2000);
            Dtotal.Text = dtq.ToString();
            DAtotal.Text = dta.ToString();
        }
        private void buttonDepSubmit_Click(object sender, EventArgs e)
        {
            string value2000 = Ds2000.Text;
            string value500 = Ds500.Text;
            string value200 = Ds200.Text;
            string value100 = Ds100.Text;
            string value50 = Ds50.Text;
            string value20 = Ds20.Text;
            string value10 = Ds10.Text;
            string value5 = Ds5.Text;
            string value2 = Ds2.Text;
            string value1 = Ds1.Text;
            string valuedt = DAtotal.Text;

            if (string.IsNullOrWhiteSpace(DepNote.Text))
            {
                // Show a warning message
                MessageBox.Show("Enter the Account Number !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Proceed with other logic if needed
                MessageBox.Show("Deposit Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Pass data to MainForm
            MainFrom mainForm = (MainFrom)Application.OpenForms["MainFrom"];
            if (mainForm != null)
            {
                mainForm.SetValues(value2000, value500, value200, value100, value50, value20, value10, value5, value2, value1);
            }        
            repdepForm.AddRowToGridView(Ds2000.Text, Ds500.Text, Ds200.Text, Ds100.Text, Ds50.Text, Ds20.Text, Ds10.Text, Ds5.Text, Ds2.Text, Ds1.Text, DAtotal.Text, DepNote.Text);
            repdepForm.Show();
            Ds2000.Clear(); // Clear text in 500qty
            Ds500.Clear(); // Clear text in 1qty
            Ds200.Clear(); // Clear text in 2qty
            Ds100.Clear(); // Clear text in 5qty
            Ds50.Clear(); // Clear text in 10qty
            Ds20.Clear(); // Clear text in 20qty
            Ds10.Clear(); // Clear text in 50qty
            Ds5.Clear(); // Clear text in 100qty
            Ds2.Clear(); // Clear text in 200qty
            Ds1.Clear();// Clear text in 2000qty
            DAtotal.Clear(); // Clear text in 1qty
            Dtotal.Clear(); // Clear text in 1qty
        }
    }
}
