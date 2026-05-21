using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_Akther_Car_Dealership
{
    public partial class Form1 : Form
    {
        const int NONE = 1;
        const int EXTRAS = 2;
        const int LUXURY = 3;

        int packageChoice;

        decimal taxRate = 0.08875m;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoNonePackage.Checked = true;
           

            txtCustomerName.Focus();
        }

        private void rdoNonePackage_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNonePackage.Checked)
            {
                packageChoice = NONE;
            }
        }

        private void rdoExtraPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoExtraPackage.Checked)
            {
                packageChoice = EXTRAS;
            }
        }

        private void rdoLuxuryPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLuxuryPackage.Checked)
            {
                packageChoice = LUXURY;
            }
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult buttonSelected;

            buttonSelected = MessageBox.Show(
                                "Do you really want to quit?",
                                "Exiting...",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (buttonSelected == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();

            txtBasePrice.Clear();

            lstOutput.Items.Clear();

            rdoNonePackage.Checked = true;

            txtCustomerName.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal basePrice;
            decimal packagePrice = 0m;
            decimal subtotal;
            decimal taxAmount;
            decimal total;

            bool priceGood;

            priceGood = decimal.TryParse(txtBasePrice.Text, out basePrice);
            switch (packageChoice)
            {
                case NONE:
                    packagePrice = 0m;
                    break;

                case EXTRAS:
                    packagePrice = 2500m;
                    break;

                case LUXURY:
                    packagePrice = 5000m;
                    break;
            }
            if (priceGood)
            {
                subtotal = basePrice + packagePrice;

                taxAmount = subtotal * taxRate;

                total = subtotal + taxAmount;

                lstOutput.Items.Add("Customer Name: " +
                                    txtCustomerName.Text);

                lstOutput.Items.Add("Base Price: " +
                                    basePrice.ToString("C"));

                lstOutput.Items.Add("Package Price: " +
                                    packagePrice.ToString("C"));

                lstOutput.Items.Add("Tax Amount: " +
                                    taxAmount.ToString("C"));

                lstOutput.Items.Add("Total Price: " +
                                    total.ToString("C"));
            }
            else
            {
                MessageBox.Show("Please enter a valid base price");
            }
        }
    }
}
