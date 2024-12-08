using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bet
{
    public partial class Withdraw : Form
    {
        private WitReport repwitForm; // Keep a single instance of Form3
        public Withdraw()
        {
            
            InitializeComponent();
            // Subscribe to the TextChanged event of the TextBox
            WNote.TextChanged += TxtInput_TextChanged;

            // Initial state: disable the button
            btnWitSubmit.Enabled = false;
            repwitForm = new WitReport();
            //InitializeCustomEvents();
            txtWAmount.TextChanged += TxtWAmount_TextChanged;
            txtW2000.TextChanged += TxtW2000_TextChanged;
            txtW500.TextChanged += TxtW500_TextChanged;
            txtW200.TextChanged += TxtW200_TextChanged;
            txtW100.TextChanged += TxtW100_TextChanged;
            txtW50.TextChanged += TxtW50_TextChanged;
            txtW20.TextChanged += TxtW20_TextChanged;
            txtW10.TextChanged += TxtW10_TextChanged;
            txtW5.TextChanged += TxtW5_TextChanged;
            txtW2.TextChanged += TxtW2_TextChanged;
            txtW1.TextChanged += TxtW1_TextChanged;
        }
        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            // Enable or disable the button based on whether the TextBox is empty
            btnWitSubmit.Enabled = !string.IsNullOrWhiteSpace(WNote.Text);
        }
        private void TxtWAmount_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtWAmount.Text, out int amount))
            {
                int num2000 = amount / 2000;
                amount %= 2000;

                int num500 = amount / 500;
                amount %= 500;

                int num200 = amount / 200;
                amount %= 200;

                int num100 = amount / 100;
                amount %= 100;

                int num50 = amount / 50;
                amount %= 50;

                int num20 = amount / 20;
                amount %= 20;

                int num10 = amount / 10;
                amount %= 10;

                int num5 = amount / 5;
                amount %= 5;

                int num2 = amount / 2;
                amount %= 2;

                int num1 = amount / 1;
                amount %= 1;

                // Update the textboxes
                txtW2000.Text = num2000.ToString();
                txtW500.Text = num500.ToString();
                txtW200.Text = num200.ToString();
                txtW100.Text = num100.ToString();
                txtW50.Text = num50.ToString();
                txtW20.Text = num20.ToString();
                txtW10.Text = num10.ToString();
                txtW5.Text = num5.ToString();
                txtW2.Text = num2.ToString();
                txtW1.Text = num1.ToString();
                               
                // Update textbox5 based on the new value of textbox2
                //UpdateWAA2000();
            }
            else
            {
                ClearTextboxes();
            }
        }
        private void TxtW2000_TextChanged(object sender, EventArgs e)
        {
            // Recalculate textbox5 whenever textbox2 changes
            UpdateWAA2000();
            UpdateWWTotal();
        }
        private void UpdateWAA2000()
        {
            if (int.TryParse(txtW2000.Text, out int num2000))
            {
                WA2000.Text = (num2000 * 2000).ToString();
            }
            else
            {
                WA2000.Text = "0";
            }
        }
        private void TxtW500_TextChanged(object sender, EventArgs e)
        {
            // Recalculate textbox5 whenever textbox2 changes
            UpdateWAA500();
            UpdateWWTotal();
        }
        private void UpdateWAA500()
        {
            if (int.TryParse(txtW500.Text, out int num500))
            {
                WA500.Text = (num500 * 500).ToString();
            }
            else
            {
                WA500.Text = "0";
            }
        }
        private void TxtW200_TextChanged(object sender, EventArgs e)
        {
            // Recalculate textbox5 whenever textbox2 changes
            UpdateWAA200();
            UpdateWWTotal();
        }
        private void UpdateWAA200()
        {
            if (int.TryParse(txtW200.Text, out int num200))
            {
                WA200.Text = (num200 * 200).ToString();
            }
            else
            {
                WA200.Text = "0";
            }
        }
        private void TxtW100_TextChanged(object sender, EventArgs e)
        {
            // Recalculate textbox5 whenever textbox2 changes
            UpdateWAA100();
            UpdateWWTotal();
        }
        private void UpdateWAA100()
        {
            if (int.TryParse(txtW100.Text, out int num100))
            {
                WA100.Text = (num100 * 100).ToString();
            }
            else
            {
                WA100.Text = "0";
            }
        }
        private void TxtW50_TextChanged(object sender, EventArgs e)
        {
            // Recalculate textbox5 whenever textbox2 changes
            UpdateWAA50();
            UpdateWWTotal();
        }
        private void UpdateWAA50()
        {
            if (int.TryParse(txtW50.Text, out int num50))
            {
                WA50.Text = (num50 * 50).ToString();
            }
            else
            {
                WA50.Text = "0";
            }
        }
        private void TxtW20_TextChanged(object sender, EventArgs e)
        {
            // Recalculate textbox5 whenever textbox2 changes
            UpdateWAA20();
            UpdateWWTotal();
        }
        private void UpdateWAA20()
        {
            if (int.TryParse(txtW20.Text, out int num20))
            {
                WA20.Text = (num20 * 20).ToString();
            }
            else
            {
                WA20.Text = "0";
            }
        }
        private void TxtW10_TextChanged(object sender, EventArgs e)
        {
            // Recalculate textbox5 whenever textbox2 changes
            UpdateWAA10();
            UpdateWWTotal();
        }
        private void UpdateWAA10()
        {
            if (int.TryParse(txtW10.Text, out int num10))
            {
                WA10.Text = (num10 * 10).ToString();
            }
            else
            {
                WA10.Text = "0";
            }
        }
        private void TxtW5_TextChanged(object sender, EventArgs e)
        {
            // Recalculate textbox5 whenever textbox2 changes
            UpdateWAA5();
            UpdateWWTotal();
        }
        private void UpdateWAA5()
        {
            if (int.TryParse(txtW5.Text, out int num5))
            {
                WA5.Text = (num5 * 5).ToString();
            }
            else
            {
                WA5.Text = "0";
            }
        }
        private void TxtW2_TextChanged(object sender, EventArgs e)
        {
            // Recalculate textbox5 whenever textbox2 changes
            UpdateWAA2();
            UpdateWWTotal();
        }
        private void UpdateWAA2()
        {
            if (int.TryParse(txtW2.Text, out int num2))
            {
                WA2.Text = (num2 * 2).ToString();
            }
            else
            {
                WA2.Text = "0";
            }
        }
        private void TxtW1_TextChanged(object sender, EventArgs e)
        {
            // Recalculate textbox5 whenever textbox2 changes
            UpdateWAA1();
            UpdateWWTotal();
        }
        private void UpdateWAA1()
        {
            if (int.TryParse(txtW1.Text, out int num1))
            {
                WA1.Text = (num1 * 1).ToString();
            }
            else
            {
                WA1.Text = "0";
            }
        }
        private void UpdateWWTotal()
        {
            // Parse the values of WA5 and WA10
            int valueWA2000 = int.TryParse(WA2000.Text, out int numWA2000) ? numWA2000 : 0;
            int valueWA500 = int.TryParse(WA500.Text, out int numWA500) ? numWA500 : 0;
            int valueWA200 = int.TryParse(WA200.Text, out int numWA200) ? numWA200 : 0;
            int valueWA100 = int.TryParse(WA100.Text, out int numWA100) ? numWA100 : 0;
            int valueWA50 = int.TryParse(WA50.Text, out int numWA50) ? numWA50 : 0;
            int valueWA20 = int.TryParse(WA20.Text, out int numWA20) ? numWA20 : 0;
            int valueWA10 = int.TryParse(WA10.Text, out int numWA10) ? numWA10 : 0;
            int valueWA5 = int.TryParse(WA5.Text, out int numWA5) ? numWA5 : 0;
            int valueWA2 = int.TryParse(WA2.Text, out int numWA2) ? numWA5 : 0;
            int valueWA1 = int.TryParse(WA1.Text, out int numWA1) ? numWA1 : 0;

            // Calculate the total and update textboxWTotal
            WATotal.Text = (valueWA2000 + valueWA500 + valueWA200 + valueWA100 + valueWA50 + valueWA20 + valueWA10 + valueWA5 + valueWA2 + valueWA1).ToString();
        }
        private void ClearTextboxes()
        {
            txtW2000.Text = "0";
            txtW500.Text = "0";
            txtW200.Text = "0";
            txtW100.Text = "0";
            txtW50.Text = "0";
            txtW20.Text = "0";
            txtW10.Text = "0";
            txtW5.Text = "0";
            txtW2.Text = "0";
            txtW1.Text = "0";
        }
        private void btnWitSubmit_Click(object sender, EventArgs e)
        {
            string valueW2000 = txtW2000.Text;
            string valueW500 = txtW500.Text;
            string valueW200 = txtW200.Text;
            string valueW100 = txtW100.Text;
            string valueW50 = txtW50.Text;
            string valueW20 = txtW20.Text;
            string valueW10 = txtW10.Text;
            string valueW5 = txtW5.Text;
            string valueW2 = txtW2.Text;
            string valueW1 = txtW1.Text;
            if (string.IsNullOrWhiteSpace(WNote.Text))
            {
                // Show a warning message
                MessageBox.Show("Enter Account Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Proceed with other logic if needed
                MessageBox.Show("Withdraw Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Pass data to MainForm
            MainFrom mainForm = (MainFrom)Application.OpenForms["MainFrom"];
            if (mainForm != null)
            {
                mainForm.SetValue(valueW2000, valueW500, valueW200, valueW100, valueW50, valueW20, valueW10, valueW5, valueW2, valueW1);
            }
            
            repwitForm.AddRowTodataGridViewW(txtW2000.Text, txtW500.Text, txtW200.Text, txtW100.Text, txtW50.Text, txtW20.Text, txtW10.Text, txtW5.Text, txtW2.Text, txtW1.Text,txtWAmount.Text, txtWTotal.Text);
            repwitForm.Show();
            txtW2000.Clear();// Clear text in 2000qty
            txtW500.Clear(); // Clear text in 500qty
            txtW200.Clear(); // Clear text in 200qty
            txtW100.Clear(); // Clear text in 100qty
            txtW50.Clear(); // Clear text in 50qty
            txtW20.Clear(); // Clear text in 20qty
            txtW10.Clear(); // Clear text in 10qty
            txtW5.Clear(); // Clear text in 5qty
            txtW2.Clear(); // Clear text in 2qty
            txtW1.Clear(); // Clear text in 1qty
            txtWTotal.Clear(); // Clear text in 1qty
            WNote.Clear(); // Clear text in 1qty
        }
    }
}
