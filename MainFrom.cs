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
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void buttonMDeposite_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            DepositeForm depositForm = new DepositeForm();
            depositForm.TopLevel = false;
            depositForm.FormBorderStyle = FormBorderStyle.None;
            depositForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(depositForm);
            depositForm.Show();
        }

        private void buttonMWithdraw_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Withdraw withdrawForm = new Withdraw();
            withdrawForm.TopLevel = false;
            withdrawForm.FormBorderStyle = FormBorderStyle.None;
            withdrawForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(withdrawForm);
            withdrawForm.Show();
        }

        private void buttonMRepDep_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ReportDeposite repdepForm = new ReportDeposite();
            repdepForm.TopLevel = false;
            repdepForm.FormBorderStyle = FormBorderStyle.None;
            repdepForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(repdepForm);
            repdepForm.Show();
        }

        private void buttonMWitRep_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            WitReport repwitForm = new WitReport();
            repwitForm.TopLevel = false;
            repwitForm.FormBorderStyle = FormBorderStyle.None;
            repwitForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(repwitForm);
            repwitForm.Show();
        }

        private void buttontest_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            test testForm = new test();
            testForm.TopLevel = false;
            testForm.FormBorderStyle = FormBorderStyle.None;
            testForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(testForm);
            testForm.Show();
        }
        private void buttonMKobalance_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            KOBalance kobalance = new KOBalance();
            kobalance.TopLevel = false;
            kobalance.FormBorderStyle = FormBorderStyle.None;
            kobalance.Dock = DockStyle.Fill;
            panelMain.Controls.Add(kobalance);
            kobalance.Show();
        }
        public void SetValues(string dC2000Value, string dC500Value, string dC200Value, string dC100Value, string dC50Value, string dC20Value, string dC10Value, string dC5Value, string dC2Value, string dC1Value)
        {
            CC2000.Text = dC2000Value;
            CC500.Text = dC500Value;
            CC200.Text = dC200Value;
            CC100.Text = dC100Value;
            CC50.Text = dC50Value;
            CC20.Text = dC20Value;
            CC10.Text = dC10Value;
            CC5.Text = dC5Value;
            CC2.Text = dC2Value;
            CC1.Text = dC1Value;

            int existingValue2000 = string.IsNullOrEmpty(CCC2000.Text) ? 0 : int.Parse(CCC2000.Text);
            int valueFrom2000 = string.IsNullOrEmpty(CC2000.Text) ? 0 : int.Parse(CC2000.Text);
            CCC2000.Text = (existingValue2000 + valueFrom2000).ToString();
            int CCCA2000 = int.Parse(CCC2000.Text);
            int existingValue500 = string.IsNullOrEmpty(CCC500.Text) ? 0 : int.Parse(CCC500.Text);
            int valueFrom500 = string.IsNullOrEmpty(CC500.Text) ? 0 : int.Parse(CC500.Text);
            CCC500.Text = (existingValue500 + valueFrom500).ToString();
            int CCCA500 = int.Parse(CCC500.Text);
            int existingValue200 = string.IsNullOrEmpty(CCC200.Text) ? 0 : int.Parse(CCC200.Text);
            int valueFrom200 = string.IsNullOrEmpty(CC200.Text) ? 0 : int.Parse(CC200.Text);
            CCC200.Text = (existingValue200 + valueFrom200).ToString();
            int CCCA200 = int.Parse(CCC200.Text);
            int existingValue100 = string.IsNullOrEmpty(CCC100.Text) ? 0 : int.Parse(CCC100.Text);
            int valueFrom100 = string.IsNullOrEmpty(CC100.Text) ? 0 : int.Parse(CC100.Text);
            CCC100.Text = (existingValue100 + valueFrom100).ToString();
            int CCCA100 = int.Parse(CCC100.Text);
            int existingValue50 = string.IsNullOrEmpty(CCC50.Text) ? 0 : int.Parse(CCC50.Text);
            int valueFrom50 = string.IsNullOrEmpty(CC50.Text) ? 0 : int.Parse(CC50.Text);
            CCC50.Text = (existingValue50 + valueFrom50).ToString();
            int CCCA50 = int.Parse(CCC50.Text);
            int existingValue20 = string.IsNullOrEmpty(CCC20.Text) ? 0 : int.Parse(CCC20.Text);
            int valueFrom20 = string.IsNullOrEmpty(CC20.Text) ? 0 : int.Parse(CC20.Text);
            CCC20.Text = (existingValue20 + valueFrom20).ToString();
            int CCCA20 = int.Parse(CCC20.Text);
            int existingValue10 = string.IsNullOrEmpty(CCC10.Text) ? 0 : int.Parse(CCC10.Text);
            int valueFrom10 = string.IsNullOrEmpty(CC10.Text) ? 0 : int.Parse(CC10.Text);
            CCC10.Text = (existingValue10 + valueFrom10).ToString();
            int CCCA10 = int.Parse(CCC10.Text);
            int existingValue5 = string.IsNullOrEmpty(CCC5.Text) ? 0 : int.Parse(CCC5.Text);
            int valueFrom5 = string.IsNullOrEmpty(CC5.Text) ? 0 : int.Parse(CC5.Text);
            CCC5.Text = (existingValue5 + valueFrom5).ToString();
            int CCCA5 = int.Parse(CCC5.Text);
            int existingValue2 = string.IsNullOrEmpty(CCC2.Text) ? 0 : int.Parse(CCC2.Text);
            int valueFrom2 = string.IsNullOrEmpty(CC2.Text) ? 0 : int.Parse(CC2.Text);
            CCC2.Text = (existingValue2 + valueFrom2).ToString();
            int CCCA2 = int.Parse(CCC2.Text);
            int existingValue1 = string.IsNullOrEmpty(CCC1.Text) ? 0 : int.Parse(CCC1.Text);
            int valueFrom1 = string.IsNullOrEmpty(CC1.Text) ? 0 : int.Parse(CC1.Text);
            CCC1.Text = (existingValue1 + valueFrom1).ToString();
            int CCCA1 = string.IsNullOrEmpty(CCC1.Text) ? 0 : int.Parse(CCC1.Text);
            int CCCtotal = ((CCCA1 * 1) + (CCCA2 * 2) + (CCCA5 * 5) + (CCCA10 * 10) + (CCCA20 * 20) + (CCCA50 * 50) + (CCCA100 * 100) + (CCCA200 * 200) + (CCCA500 * 500) + (CCCA2000 * 2000));
            CCTotal.Text = CCCtotal.ToString();          
        }

        public void SetValue(string wC2000Value, string wC500Value, string wC200Value, string wC100Value, string wC50Value, string wC20Value, string wC10Value, string wC5Value, string wC2Value, string wC1Value)
        {
            CW2000.Text = wC2000Value;
            CW500.Text = wC500Value;
            CW200.Text = wC200Value;
            CW100.Text = wC100Value;
            CW50.Text = wC50Value;
            CW20.Text = wC20Value;
            CW10.Text = wC10Value;
            CW5.Text = wC5Value;
            CW2.Text = wC2Value;
            CW1.Text = wC1Value;

            int existingValue2000 = string.IsNullOrEmpty(CCC2000.Text) ? 0 : int.Parse(CCC2000.Text);
            int valueFrm2000 = string.IsNullOrEmpty(CW2000.Text) ? 0 : int.Parse(CW2000.Text);
            CCC2000.Text = (existingValue2000 - valueFrm2000).ToString();
            int CCCA2000 = int.Parse(CCC2000.Text);
            int existingValue500 = string.IsNullOrEmpty(CCC500.Text) ? 0 : int.Parse(CCC500.Text);
            int valueFrm500 = string.IsNullOrEmpty(CW500.Text) ? 0 : int.Parse(CW500.Text);
            CCC500.Text = (existingValue500 - valueFrm500).ToString();
            int CCCA500 = int.Parse(CCC500.Text);
            int existingValue200 = string.IsNullOrEmpty(CCC200.Text) ? 0 : int.Parse(CCC200.Text);
            int valueFrm200 = string.IsNullOrEmpty(CW200.Text) ? 0 : int.Parse(CW200.Text);
            CCC200.Text = (existingValue200 - valueFrm200).ToString();
            int CCCA200 = int.Parse(CCC200.Text);
            int existingValue100 = string.IsNullOrEmpty(CCC100.Text) ? 0 : int.Parse(CCC100.Text);
            int valueFrm100 = string.IsNullOrEmpty(CW100.Text) ? 0 : int.Parse(CW100.Text);
            CCC100.Text = (existingValue100 - valueFrm100).ToString();
            int CCCA100 = int.Parse(CCC100.Text);
            int existingValue50 = string.IsNullOrEmpty(CCC50.Text) ? 0 : int.Parse(CCC50.Text);
            int valueFrm50 = string.IsNullOrEmpty(CW50.Text) ? 0 : int.Parse(CW50.Text);
            CCC50.Text = (existingValue50 - valueFrm50).ToString();
            int CCCA50 = int.Parse(CCC50.Text);
            int existingValue20 = string.IsNullOrEmpty(CCC20.Text) ? 0 : int.Parse(CCC20.Text);
            int valueFrm20 = string.IsNullOrEmpty(CW20.Text) ? 0 : int.Parse(CW20.Text);
            CCC20.Text = (existingValue20 - valueFrm20).ToString();
            int CCCA20 = int.Parse(CCC20.Text);
            int existingValue10 = string.IsNullOrEmpty(CCC10.Text) ? 0 : int.Parse(CCC10.Text);
            int valueFrm10 = string.IsNullOrEmpty(CW10.Text) ? 0 : int.Parse(CW10.Text);
            CCC10.Text = (existingValue10 - valueFrm10).ToString();
            int CCCA10 = int.Parse(CCC10.Text);
            int existingValue5 = string.IsNullOrEmpty(CCC5.Text) ? 0 : int.Parse(CCC5.Text);
            int valueFrm5 = string.IsNullOrEmpty(CW5.Text) ? 0 : int.Parse(CW5.Text);
            CCC5.Text = (existingValue5 - valueFrm5).ToString();
            int CCCA5 = int.Parse(CCC5.Text);
            int existingValue2 = string.IsNullOrEmpty(CCC2.Text) ? 0 : int.Parse(CCC2.Text);
            int valueFrm2 = string.IsNullOrEmpty(CW2.Text) ? 0 : int.Parse(CW2.Text);
            CCC2.Text = (existingValue2 - valueFrm2).ToString();
            int CCCA2 = int.Parse(CCC2.Text);
            int existingValue1 = string.IsNullOrEmpty(CCC1.Text) ? 0 : int.Parse(CCC1.Text);
            int valueFrm1 = string.IsNullOrEmpty(CW1.Text) ? 0 : int.Parse(CW1.Text);
            CCC1.Text = (existingValue1 - valueFrm1).ToString();
            int CCCA1 = string.IsNullOrEmpty(CCC1.Text) ? 0 : int.Parse(CCC1.Text);
            int CCCtotal = ((CCCA1 * 1) + (CCCA2 * 2) + (CCCA5 * 5) + (CCCA10 * 10) + (CCCA20 * 20) + (CCCA50 * 50) + (CCCA100 * 100) + (CCCA200 * 200) + (CCCA500 * 500) + (CCCA2000 * 2000));
            CCTotal.Text = CCCtotal.ToString();
        }
        public void SetValueko(string koba)
        {

            Kb.Text = koba;
            int existingValueKOB = string.IsNullOrEmpty(KOBalance.Text) ? 0 : int.Parse(KOBalance.Text);
            int valueFrmKOB = string.IsNullOrEmpty(Kb.Text) ? 0 : int.Parse(Kb.Text);
            int valueFrmKOtemp = string.IsNullOrEmpty(KTotal.Text) ? 0 : int.Parse(KTotal.Text);
            KOBalance.Text = (existingValueKOB + valueFrmKOB - valueFrmKOtemp).ToString();
        }
        
    }
}

