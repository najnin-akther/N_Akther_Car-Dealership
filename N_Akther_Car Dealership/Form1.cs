using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        decimal basePrice;
        decimal packagePrice;
        decimal subtotal;
        decimal taxAmount;
        decimal total;

        decimal taxRate = 0.08875m;

        decimal nonePackagePrice = 0m;
        decimal extrasPackagePrice = 2500m;
        decimal luxuryPackagePrice = 5000m;

        string configFile = "CarConfig.txt";

        StreamReader sr;

        public decimal TaxRate
        {
            get
            {
                return taxRate;
            }

            set
            {
                taxRate = value;
            }
        }

        public decimal NonePackagePrice
        {
            get
            {
                return nonePackagePrice;
            }

            set
            {
                nonePackagePrice = value;
            }
        }

        public decimal ExtrasPackagePrice
        {
            get
            {
                return extrasPackagePrice;
            }

            set
            {
                extrasPackagePrice = value;
            }
        }

        public decimal LuxuryPackagePrice
        {
            get
            {
                return luxuryPackagePrice;
            }

            set
            {
                luxuryPackagePrice = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool fileGood = false;

            rdoNonePackage.Checked = true;

            txtCustomerName.Focus();

            do
            {
                try
                {
                    sr = File.OpenText(configFile);

                    TaxRate = decimal.Parse(sr.ReadLine());

                    NonePackagePrice = decimal.Parse(sr.ReadLine());

                    ExtrasPackagePrice = decimal.Parse(sr.ReadLine());

                    LuxuryPackagePrice = decimal.Parse(sr.ReadLine());

                    sr.Close();

                    fileGood = true;
                }
                catch
                {
                    MessageBox.Show("Problem reading file");

                    OpenFileDialog ofd = new OpenFileDialog();

                    ofd.Title = "Select Config File";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        configFile = ofd.FileName;
                    }
                }

            } while (fileGood == false);
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
            bool priceGood;

            priceGood = decimal.TryParse(txtBasePrice.Text,
                                         out basePrice);

            switch (packageChoice)
            {
                case NONE:
                    packagePrice = NonePackagePrice;
                    break;

                case EXTRAS:
                    packagePrice = ExtrasPackagePrice;
                    break;

                case LUXURY:
                    packagePrice = LuxuryPackagePrice;
                    break;
            }

            if (priceGood)
            {
                lstOutput.Items.Clear();

                subtotal = basePrice + packagePrice;

                taxAmount = subtotal * TaxRate;

                total = subtotal + taxAmount;

                lstOutput.Items.Add("Customer Name: " +
                                    txtCustomerName.Text);

                lstOutput.Items.Add("Type of Add-on: " +
                                    packageChoice);

                lstOutput.Items.Add("Base Vehicle Price: " +
                                    basePrice.ToString("C"));

                lstOutput.Items.Add("Price of Add-on: " +
                                    packagePrice.ToString("C"));

                lstOutput.Items.Add("Subtotal: " +
                                    subtotal.ToString("C"));

                lstOutput.Items.Add("Tax Rate: " +
                                    TaxRate.ToString("P"));

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