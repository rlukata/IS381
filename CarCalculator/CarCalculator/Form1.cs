﻿using System;
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

            //combobox
            ComboBox myComboBox = new ComboBox();
            //foreach (String labelText in myComparison.Car1())
            //{
            //    myComboBox.Text += labelText + "\n";
            //}

            //Compare label 1
            Label CompareBoxLabel1 = new Label();
            CompareBoxLabel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CompareBoxLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            CompareBoxLabel1.Size = new System.Drawing.Size(270, 260);
            //CompareBoxLabel1.Text = myComparison.Car1().Text;

            foreach (String labelText in myComparison.Car1().Text)
            {
                CompareBoxLabel1.Text += labelText + "\n";
            }

            //Compare label 2
            Label CompareBoxLabel2 = new Label();
            CompareBoxLabel2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //CompareBoxLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            CompareBoxLabel2.Size = new System.Drawing.Size(270, 260);
            CompareBoxLabel2.Text = myComparison.Car2().Text;

            //foreach (String labelText in myComparison.Car2())
            //{
            //    CompareBoxLabel2.Text += labelText + "\n";
            //}

            //About Panel
            TableLayoutPanel ComparePanel = new System.Windows.Forms.TableLayoutPanel();
            ComparePanel.Name = "Compare Panel";
            ComparePanel.Size = new System.Drawing.Size(600, 300);
            ComparePanel.TabIndex = 0;
            ComparePanel.ColumnCount = 2;
            ComparePanel.RowCount = 1;
            ComparePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0F));
            ComparePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0F));
            ComparePanel.Controls.Add(CompareBoxLabel1, 0, 0);
            ComparePanel.Controls.Add(CompareBoxLabel2, 1, 0);
            ComparePanel.Controls.Add(myComboBox, 1, 0);


            Form compareForm = new Form();
            compareForm.Size = new System.Drawing.Size(650, 350);
            compareForm.Text = "Compare Car Calulator";
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

    // Compare class compares different cars based on different arguments
    class Compare
    {
        Car myCar = new Car();
        ComboBox tempComboBox = new ComboBox();
        static int[] firstCar  = { 0, 0, 0, 1 };
        static int[] secondCar = { 3, 4, 0, 2 };
        static int[] thirdCar = { 2, 2, 1, 0 };
        int[][] myCars = { firstCar, secondCar, thirdCar };

        public ComboBox Car1()
        {
            for (int i = 0 ; myCars.Length > i; i++)
            {
                string[] compare1 = new string[] { "Brand: " + myCar.carBrand[myCars[i][0]], "Engine Type: " + myCar.carEngine[myCars[i][1]],
                "Car type: " + myCar.carType[myCars[i][2]], "Passengers capacity: " + myCar.passengers[myCars[i][3]] };
                tempComboBox.Text = compare1[i] + "\n";
            }
            return tempComboBox;
        }

        public ComboBox Car2()
        {
            for (int i = 0; myCars.Length > i; i++)
            {
                string[] compare2 = new string[] { "Brand: " + myCar.carBrand[myCars[i][0]], "Engine Type: " + myCar.carEngine[myCars[i][1]],
                "Car type: " + myCar.carType[myCars[i][2]], "Passengers capacity: " + myCar.passengers[myCars[i][3]] };
                tempComboBox.Text = compare2[i] + "\n";
            }
            return tempComboBox;
        }
    }

    // Car class creates a structure so that car can be defined by different traits
    class Car
    {
        public string[] carBrand = new string[] {"Mercedes-Benz", "Volvo", "Ford", "Tesla"};
        public string[] carEngine = new string[] { "V6", "V8", "2.4", "2.0", "EVC" };
        public string[] carType = new string[] {"sedan", "coupe", "crossover", "hatchback", "convertible" };
        public string[] passengers = new string[] { "2", "4", "5" };
    }
}