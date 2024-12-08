using bet;
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

namespace bet
{
    public partial class KOBalance : Form
    {
        public KOBalance()
        {
            InitializeComponent();
        }
private void btnKOBAdd_Click(object sender, EventArgs e)
        {
            string koba = KOBAdd.Text;
            // Pass data to MainForm
            MainFrom mainForm = (MainFrom)Application.OpenForms["MainFrom"];
            if (mainForm != null)
            {
                mainForm.SetValueko(koba);
            }

            KOBAdd.Clear(); // Clear text in 500qty
        }
        //private void buttonDepSubmit_Click(object sender, EventArgs e)
        //{
        //    string value2000 = Ds2000.Text;
            

        //    // Pass data to MainForm
        //    MainFrom mainForm = (MainFrom)Application.OpenForms["MainFrom"];
        //    if (mainForm != null)
        //    {
        //        mainForm.SetValues(value2000, value500, value200, value100, value50, value20, value10, value5, value2, value1);
        //    }
            
        //    Ds2000.Clear(); // Clear text in 500qty
            
        //}
    }
}
