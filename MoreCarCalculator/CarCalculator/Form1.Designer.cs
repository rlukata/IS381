namespace CarCalculator
{
    partial class CarCalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MyLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MonthlyPaymentsValueLabel = new System.Windows.Forms.Label();
            this.TotalInterestValueLabel = new System.Windows.Forms.Label();
            this.InstallmentsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.InterestRateUpDown = new System.Windows.Forms.NumericUpDown();
            this.DownPaymentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CarPriceLabel = new System.Windows.Forms.Label();
            this.DownPaymentLabel = new System.Windows.Forms.Label();
            this.InterestRateLabel = new System.Windows.Forms.Label();
            this.MonthlyPayLabel = new System.Windows.Forms.Label();
            this.MonthlyInstallmentsLabel = new System.Windows.Forms.Label();
            this.TotalInterestLabel = new System.Windows.Forms.Label();
            this.CarPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalCarPriceValueLabel = new System.Windows.Forms.Label();
            this.TotalCarPriceLabel = new System.Windows.Forms.Label();
            this.CarCalcMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InstallmentsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterestRateUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownPaymentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPriceNumericUpDown)).BeginInit();
            this.CarCalcMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyLayoutPanel
            // 
            this.MyLayoutPanel.ColumnCount = 2;
            this.MyLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.MyLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.MyLayoutPanel.Controls.Add(this.MonthlyPaymentsValueLabel, 1, 5);
            this.MyLayoutPanel.Controls.Add(this.TotalInterestValueLabel, 1, 4);
            this.MyLayoutPanel.Controls.Add(this.InstallmentsNumericUpDown, 1, 3);
            this.MyLayoutPanel.Controls.Add(this.InterestRateUpDown, 1, 2);
            this.MyLayoutPanel.Controls.Add(this.DownPaymentNumericUpDown, 1, 1);
            this.MyLayoutPanel.Controls.Add(this.CarPriceLabel, 0, 0);
            this.MyLayoutPanel.Controls.Add(this.DownPaymentLabel, 0, 1);
            this.MyLayoutPanel.Controls.Add(this.InterestRateLabel, 0, 2);
            this.MyLayoutPanel.Controls.Add(this.MonthlyPayLabel, 0, 5);
            this.MyLayoutPanel.Controls.Add(this.MonthlyInstallmentsLabel, 0, 3);
            this.MyLayoutPanel.Controls.Add(this.TotalInterestLabel, 0, 4);
            this.MyLayoutPanel.Controls.Add(this.CarPriceNumericUpDown, 1, 0);
            this.MyLayoutPanel.Controls.Add(this.totalCarPriceValueLabel, 1, 6);
            this.MyLayoutPanel.Controls.Add(this.TotalCarPriceLabel, 0, 6);
            this.MyLayoutPanel.Location = new System.Drawing.Point(12, 27);
            this.MyLayoutPanel.Name = "MyLayoutPanel";
            this.MyLayoutPanel.RowCount = 7;
            this.MyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.49276F));
            this.MyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.49275F));
            this.MyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.49275F));
            this.MyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.49275F));
            this.MyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.49275F));
            this.MyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.49275F));
            this.MyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.MyLayoutPanel.Size = new System.Drawing.Size(343, 368);
            this.MyLayoutPanel.TabIndex = 0;
            // 
            // MonthlyPaymentsValueLabel
            // 
            this.MonthlyPaymentsValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MonthlyPaymentsValueLabel.AutoSize = true;
            this.MonthlyPaymentsValueLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyPaymentsValueLabel.Location = new System.Drawing.Point(270, 280);
            this.MonthlyPaymentsValueLabel.Name = "MonthlyPaymentsValueLabel";
            this.MonthlyPaymentsValueLabel.Size = new System.Drawing.Size(70, 22);
            this.MonthlyPaymentsValueLabel.TabIndex = 11;
            this.MonthlyPaymentsValueLabel.Text = "months";
            this.MonthlyPaymentsValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalInterestValueLabel
            // 
            this.TotalInterestValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TotalInterestValueLabel.AutoSize = true;
            this.TotalInterestValueLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalInterestValueLabel.Location = new System.Drawing.Point(240, 227);
            this.TotalInterestValueLabel.Name = "TotalInterestValueLabel";
            this.TotalInterestValueLabel.Size = new System.Drawing.Size(100, 22);
            this.TotalInterestValueLabel.TabIndex = 10;
            this.TotalInterestValueLabel.Text = " interest";
            this.TotalInterestValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstallmentsNumericUpDown
            // 
            this.InstallmentsNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InstallmentsNumericUpDown.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallmentsNumericUpDown.Increment = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.InstallmentsNumericUpDown.Location = new System.Drawing.Point(231, 170);
            this.InstallmentsNumericUpDown.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.InstallmentsNumericUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.InstallmentsNumericUpDown.Name = "InstallmentsNumericUpDown";
            this.InstallmentsNumericUpDown.ReadOnly = true;
            this.InstallmentsNumericUpDown.Size = new System.Drawing.Size(109, 30);
            this.InstallmentsNumericUpDown.TabIndex = 9;
            this.InstallmentsNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InstallmentsNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // InterestRateUpDown
            // 
            this.InterestRateUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InterestRateUpDown.DecimalPlaces = 2;
            this.InterestRateUpDown.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestRateUpDown.Increment = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            this.InterestRateUpDown.Location = new System.Drawing.Point(231, 117);
            this.InterestRateUpDown.Maximum = new decimal(new int[] {
            2495,
            0,
            0,
            131072});
            this.InterestRateUpDown.Minimum = new decimal(new int[] {
            95,
            0,
            0,
            131072});
            this.InterestRateUpDown.Name = "InterestRateUpDown";
            this.InterestRateUpDown.ReadOnly = true;
            this.InterestRateUpDown.Size = new System.Drawing.Size(109, 30);
            this.InterestRateUpDown.TabIndex = 8;
            this.InterestRateUpDown.Tag = "";
            this.InterestRateUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InterestRateUpDown.Value = new decimal(new int[] {
            95,
            0,
            0,
            131072});
            // 
            // DownPaymentNumericUpDown
            // 
            this.DownPaymentNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DownPaymentNumericUpDown.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownPaymentNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.DownPaymentNumericUpDown.Location = new System.Drawing.Point(231, 64);
            this.DownPaymentNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DownPaymentNumericUpDown.Name = "DownPaymentNumericUpDown";
            this.DownPaymentNumericUpDown.ReadOnly = true;
            this.DownPaymentNumericUpDown.Size = new System.Drawing.Size(109, 30);
            this.DownPaymentNumericUpDown.TabIndex = 7;
            this.DownPaymentNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DownPaymentNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // CarPriceLabel
            // 
            this.CarPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CarPriceLabel.AutoSize = true;
            this.CarPriceLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarPriceLabel.Location = new System.Drawing.Point(3, 15);
            this.CarPriceLabel.Name = "CarPriceLabel";
            this.CarPriceLabel.Size = new System.Drawing.Size(100, 22);
            this.CarPriceLabel.TabIndex = 0;
            this.CarPriceLabel.Text = "Car Price";
            // 
            // DownPaymentLabel
            // 
            this.DownPaymentLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DownPaymentLabel.AutoSize = true;
            this.DownPaymentLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownPaymentLabel.Location = new System.Drawing.Point(3, 68);
            this.DownPaymentLabel.Name = "DownPaymentLabel";
            this.DownPaymentLabel.Size = new System.Drawing.Size(130, 22);
            this.DownPaymentLabel.TabIndex = 1;
            this.DownPaymentLabel.Text = "Down Payment";
            // 
            // InterestRateLabel
            // 
            this.InterestRateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.InterestRateLabel.AutoSize = true;
            this.InterestRateLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestRateLabel.Location = new System.Drawing.Point(3, 121);
            this.InterestRateLabel.Name = "InterestRateLabel";
            this.InterestRateLabel.Size = new System.Drawing.Size(140, 22);
            this.InterestRateLabel.TabIndex = 2;
            this.InterestRateLabel.Text = "Interest Rate";
            // 
            // MonthlyPayLabel
            // 
            this.MonthlyPayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MonthlyPayLabel.AutoSize = true;
            this.MonthlyPayLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyPayLabel.Location = new System.Drawing.Point(3, 280);
            this.MonthlyPayLabel.Name = "MonthlyPayLabel";
            this.MonthlyPayLabel.Size = new System.Drawing.Size(170, 22);
            this.MonthlyPayLabel.TabIndex = 4;
            this.MonthlyPayLabel.Text = "Monthly Payments";
            // 
            // MonthlyInstallmentsLabel
            // 
            this.MonthlyInstallmentsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MonthlyInstallmentsLabel.AutoSize = true;
            this.MonthlyInstallmentsLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyInstallmentsLabel.Location = new System.Drawing.Point(3, 174);
            this.MonthlyInstallmentsLabel.Name = "MonthlyInstallmentsLabel";
            this.MonthlyInstallmentsLabel.Size = new System.Drawing.Size(130, 22);
            this.MonthlyInstallmentsLabel.TabIndex = 5;
            this.MonthlyInstallmentsLabel.Text = "Installments";
            // 
            // TotalInterestLabel
            // 
            this.TotalInterestLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TotalInterestLabel.AutoSize = true;
            this.TotalInterestLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalInterestLabel.Location = new System.Drawing.Point(3, 227);
            this.TotalInterestLabel.Name = "TotalInterestLabel";
            this.TotalInterestLabel.Size = new System.Drawing.Size(150, 22);
            this.TotalInterestLabel.TabIndex = 3;
            this.TotalInterestLabel.Text = "Total Interest";
            // 
            // CarPriceNumericUpDown
            // 
            this.CarPriceNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CarPriceNumericUpDown.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarPriceNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.CarPriceNumericUpDown.Location = new System.Drawing.Point(231, 11);
            this.CarPriceNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.CarPriceNumericUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.CarPriceNumericUpDown.Name = "CarPriceNumericUpDown";
            this.CarPriceNumericUpDown.ReadOnly = true;
            this.CarPriceNumericUpDown.Size = new System.Drawing.Size(109, 30);
            this.CarPriceNumericUpDown.TabIndex = 6;
            this.CarPriceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CarPriceNumericUpDown.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // totalCarPriceValueLabel
            // 
            this.totalCarPriceValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalCarPriceValueLabel.AutoSize = true;
            this.totalCarPriceValueLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCarPriceValueLabel.Location = new System.Drawing.Point(280, 332);
            this.totalCarPriceValueLabel.Name = "totalCarPriceValueLabel";
            this.totalCarPriceValueLabel.Size = new System.Drawing.Size(60, 22);
            this.totalCarPriceValueLabel.TabIndex = 13;
            this.totalCarPriceValueLabel.Text = "price";
            this.totalCarPriceValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalCarPriceLabel
            // 
            this.TotalCarPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TotalCarPriceLabel.AutoSize = true;
            this.TotalCarPriceLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCarPriceLabel.Location = new System.Drawing.Point(3, 332);
            this.TotalCarPriceLabel.Name = "TotalCarPriceLabel";
            this.TotalCarPriceLabel.Size = new System.Drawing.Size(160, 22);
            this.TotalCarPriceLabel.TabIndex = 12;
            this.TotalCarPriceLabel.Text = "Total Car Price";
            // 
            // CarCalcMenuStrip
            // 
            this.CarCalcMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.CarCalcMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.CarCalcMenuStrip.Name = "CarCalcMenuStrip";
            this.CarCalcMenuStrip.Size = new System.Drawing.Size(364, 24);
            this.CarCalcMenuStrip.TabIndex = 2;
            this.CarCalcMenuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.compareToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // compareToolStripMenuItem
            // 
            this.compareToolStripMenuItem.Name = "compareToolStripMenuItem";
            this.compareToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.compareToolStripMenuItem.Text = "Compare";
            this.compareToolStripMenuItem.Click += new System.EventHandler(this.compareToolStripMenuItem_Click);
            // 
            // CarCalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 406);
            this.Controls.Add(this.MyLayoutPanel);
            this.Controls.Add(this.CarCalcMenuStrip);
            this.Name = "CarCalForm";
            this.Text = "Car Payments Calculator";
            this.MyLayoutPanel.ResumeLayout(false);
            this.MyLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InstallmentsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterestRateUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownPaymentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPriceNumericUpDown)).EndInit();
            this.CarCalcMenuStrip.ResumeLayout(false);
            this.CarCalcMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MyLayoutPanel;
        private System.Windows.Forms.Label CarPriceLabel;
        private System.Windows.Forms.Label DownPaymentLabel;
        private System.Windows.Forms.Label InterestRateLabel;
        private System.Windows.Forms.Label MonthlyPayLabel;
        private System.Windows.Forms.Label MonthlyInstallmentsLabel;
        private System.Windows.Forms.Label TotalInterestLabel;
        private System.Windows.Forms.NumericUpDown CarPriceNumericUpDown;
        private System.Windows.Forms.NumericUpDown InstallmentsNumericUpDown;
        private System.Windows.Forms.NumericUpDown InterestRateUpDown;
        private System.Windows.Forms.NumericUpDown DownPaymentNumericUpDown;
        private System.Windows.Forms.Label MonthlyPaymentsValueLabel;
        private System.Windows.Forms.Label TotalInterestValueLabel;
        private System.Windows.Forms.MenuStrip CarCalcMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label totalCarPriceValueLabel;
        private System.Windows.Forms.Label TotalCarPriceLabel;
        private System.Windows.Forms.ToolStripMenuItem compareToolStripMenuItem;
    }
}

