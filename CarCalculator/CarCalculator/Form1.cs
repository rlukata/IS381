using System;
using System.Windows.Forms;

namespace CarCalculator
{
    public partial class CarCalForm : Form
    {
        public CarCalForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //About label
            Label AboutBoxLabel = new Label();
            AboutBoxLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AboutBoxLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            AboutBoxLabel.Size = new System.Drawing.Size(290, 125);
            AboutBoxLabel.Text = "This program calculates the value of a car based on its price, " +
                "compound interest rate, downpayment, and installements.";

            //About Panel
            Panel AboutPanel = new Panel();
            AboutPanel.Name = "AboutPanel";
            AboutPanel.Size = new System.Drawing.Size(295, 150);
            AboutPanel.TabIndex = 0;
            AboutPanel.Controls.Add(AboutBoxLabel);

            //About Form
            Form AboutForm = new Form();
            AboutForm.Size = new System.Drawing.Size(300, 150);
            AboutForm.Text = "About Car Calulator";
            AboutForm.Controls.Add(AboutPanel);
            AboutForm.ShowDialog();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateCarTotalPrice((double)CarPriceNumericUpDown.Value, (double)DownPaymentNumericUpDown.Value,
                ((double)InterestRateUpDown.Value) / 100.00, (double)InstallmentsNumericUpDown.Value);
        }

        private void CalculateCarTotalPrice(double principal, double downpayment, double interestRate, 
            double installments)
        {
            //Exception - downpayment can't be bigger than principal
            if (downpayment > principal) throw new ArgumentOutOfRangeException("Downpayment can't be bigger than Car price");

            /**
            * APR formula:
            * D = (p * i / 12) / (1 - (1 + i / 12)^-m)
            * Where:
            * D = monthly amount
            * p = principal - downpayment
            * i = interest rate
            * m = number of installments
            */

            //calculate using the formula previously provided
            double monthlyAmount = ((principal - downpayment) * (interestRate / 12.00)) /
                (1.00 - Math.Pow((1.00 + (interestRate / 12.00)), -installments));

            //populate labels with values
            TotalInterestValueLabel.Text = (monthlyAmount * installments - principal + downpayment).ToString("0.00");
            MonthlyPaymentsValueLabel.Text = monthlyAmount.ToString("0.00");
            totalCarPriceValueLabel.Text = (monthlyAmount * installments + downpayment).ToString("0.00");
        }
    }
}