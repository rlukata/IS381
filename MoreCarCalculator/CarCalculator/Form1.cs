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
            //declare variables to assign them value from Form
            double principal = (double)CarPriceNumericUpDown.Value;
            double downpayment = (double)DownPaymentNumericUpDown.Value;
            double interestRate = (double)InterestRateUpDown.Value / 100.00;
            double installments = (double)InstallmentsNumericUpDown.Value;

            //compute and assign value to Monthly Amoount
            double monthlyAmount = Calculate.CalculateCarTotalPrice(principal, downpayment, interestRate, installments);

            //populate labels with values
            TotalInterestValueLabel.Text = (monthlyAmount * installments - principal + downpayment).ToString("0.00");
            MonthlyPaymentsValueLabel.Text = monthlyAmount.ToString("0.00");
            totalCarPriceValueLabel.Text = (monthlyAmount * installments + downpayment).ToString("0.00");
        }

        private void compareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compare myComparison = new Compare();

            //Compare label 1
            Label CompareBoxLabel1 = new Label();
            CompareBoxLabel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CompareBoxLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            CompareBoxLabel1.Size = new System.Drawing.Size(290, 275);
            foreach (String labelText in myComparison.Car1())
            {
                CompareBoxLabel1.Text += labelText + "\n";
            }

            //Compare label 2
            Label CompareBoxLabel2 = new Label();
            CompareBoxLabel2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CompareBoxLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            CompareBoxLabel2.Size = new System.Drawing.Size(290, 275);
            foreach (String labelText in myComparison.Car2())
            {
                CompareBoxLabel2.Text += labelText + "\n";
            }

            //About Panel
            TableLayoutPanel ComparePanel = new System.Windows.Forms.TableLayoutPanel();
            ComparePanel.Name = "Compare Panel";
            ComparePanel.Size = new System.Drawing.Size(600, 300);
            ComparePanel.TabIndex = 0;
            ComparePanel.ColumnCount = 2;
            ComparePanel.RowCount = 1;
            ComparePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F));
            ComparePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F));
            ComparePanel.Controls.Add(CompareBoxLabel1, 0, 0);
            ComparePanel.Controls.Add(CompareBoxLabel2, 1, 0);

            Form compareForm = new Form();
            compareForm.Size = new System.Drawing.Size(650, 350);
            compareForm.Text = "About Car Calulator";
            compareForm.Controls.Add(ComparePanel);
            compareForm.Show();
        }
    }

    // Calculate class does the computations necessary to do calculations on car payments
    static class Calculate
    {
        public static double CalculateCarTotalPrice(double principal, double downpayment, double interestRate,
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

            //calculate using the formula previously provided, and return value
            double monthlyAmount = ((principal - downpayment) * (interestRate / 12.00)) /
                (1.00 - Math.Pow((1.00 + (interestRate / 12.00)), -installments));
            return monthlyAmount;
        }
    }

    //Car  abstract class creates a structure so that car can be defined by different traits
    abstract class Car
    {
        public string[] carBrand()
        {
            return new string[] { "Mercedes-Benz", "Volvo", "Ford", "Tesla" };
        }
        public string[] carEngine()
        {
            return new string[] { "V6", "V8", "2.4", "2.0", "EVC" };
        }
        public string[] carType()
        {
            return new string[] { "sedan", "coupe", "crossover", "hatchback", "convertible" };
        }

        public string[] passengers()
        {
            return new string[] { "2", "4", "5" };
        }

        public int ArraySize()
        {
            return 4;
        }
    }

    // Compare class compares different cars based on different arguments
    class Compare : Car
    {
        public string[] Car1()
        {
            string[] compare1 = { "Brand: " + carBrand()[0], "Engine Type: " + carEngine()[0],
                "Car type: " + carType()[0], "Passengers capacity: " + passengers()[1] };
            return compare1;
        }

        public string[] Car2()
        {
            string[] compare2 = { "Brand: " + carBrand()[3], "Engine Type: " + carEngine()[4],
                "Car type: " + carType()[0], "Passengers capacity: " + passengers()[2] };
            return compare2;
        }
    }
}