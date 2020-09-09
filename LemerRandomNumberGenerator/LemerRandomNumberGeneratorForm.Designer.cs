namespace LemerRandomNumberGenerator
{
    partial class LemerRandomNumberGeneratorForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartLemer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxR0 = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelR0 = new System.Windows.Forms.Label();
            this.labelm = new System.Windows.Forms.Label();
            this.labelMeanValueEstimate = new System.Windows.Forms.Label();
            this.labelMeanValueEstimateResult = new System.Windows.Forms.Label();
            this.labelDispersionValueEstimate = new System.Windows.Forms.Label();
            this.labelDispersionValueEstimateResult = new System.Windows.Forms.Label();
            this.labelDeviationValueEstimate = new System.Windows.Forms.Label();
            this.labelDeviationValueEstimateResult = new System.Windows.Forms.Label();
            this.labelIndirectSigns = new System.Windows.Forms.Label();
            this.labelIndirectSignsResult = new System.Windows.Forms.Label();
            this.labelPeriodLength = new System.Windows.Forms.Label();
            this.labelPeriodLengthResult = new System.Windows.Forms.Label();
            this.labelAperiodicityLength = new System.Windows.Forms.Label();
            this.labelAperiodicityLengthResult = new System.Windows.Forms.Label();
            this.comboBoxDistributions = new System.Windows.Forms.ComboBox();
            this.labelImitate = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.labelλ = new System.Windows.Forms.Label();
            this.textBoxλ = new System.Windows.Forms.TextBox();
            this.labelη = new System.Windows.Forms.Label();
            this.textBoxη = new System.Windows.Forms.TextBox();
            this.btnImitate = new System.Windows.Forms.Button();
            this.labelMx = new System.Windows.Forms.Label();
            this.textBoxMx = new System.Windows.Forms.TextBox();
            this.labelσx = new System.Windows.Forms.Label();
            this.textBoxσx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartLemer)).BeginInit();
            this.SuspendLayout();
            // 
            // chartLemer
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLemer.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartLemer.Legends.Add(legend1);
            this.chartLemer.Location = new System.Drawing.Point(24, 24);
            this.chartLemer.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.chartLemer.Name = "chartLemer";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "LemerSeries";
            this.chartLemer.Series.Add(series1);
            this.chartLemer.Size = new System.Drawing.Size(1083, 825);
            this.chartLemer.TabIndex = 0;
            this.chartLemer.Text = "LemerChart";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(1269, 324);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(219, 86);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(1269, 67);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(217, 38);
            this.textBoxA.TabIndex = 2;
            this.textBoxA.Text = "5214";
            // 
            // textBoxR0
            // 
            this.textBoxR0.Location = new System.Drawing.Point(1269, 150);
            this.textBoxR0.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.textBoxR0.Name = "textBoxR0";
            this.textBoxR0.Size = new System.Drawing.Size(217, 38);
            this.textBoxR0.TabIndex = 3;
            this.textBoxR0.Text = "214522";
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(1269, 234);
            this.textBoxM.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(217, 38);
            this.textBoxM.TabIndex = 4;
            this.textBoxM.Text = "1231311";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(1141, 72);
            this.labelA.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(114, 32);
            this.labelA.TabIndex = 5;
            this.labelA.Text = "Enter a:";
            // 
            // labelR0
            // 
            this.labelR0.AutoSize = true;
            this.labelR0.Location = new System.Drawing.Point(1120, 157);
            this.labelR0.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelR0.Name = "labelR0";
            this.labelR0.Size = new System.Drawing.Size(134, 32);
            this.labelR0.TabIndex = 6;
            this.labelR0.Text = "Enter R0:";
            // 
            // labelm
            // 
            this.labelm.AutoSize = true;
            this.labelm.Location = new System.Drawing.Point(1133, 241);
            this.labelm.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelm.Name = "labelm";
            this.labelm.Size = new System.Drawing.Size(121, 32);
            this.labelm.TabIndex = 7;
            this.labelm.Text = "Enter m:";
            // 
            // labelMeanValueEstimate
            // 
            this.labelMeanValueEstimate.AutoSize = true;
            this.labelMeanValueEstimate.Location = new System.Drawing.Point(1117, 436);
            this.labelMeanValueEstimate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMeanValueEstimate.Name = "labelMeanValueEstimate";
            this.labelMeanValueEstimate.Size = new System.Drawing.Size(293, 32);
            this.labelMeanValueEstimate.TabIndex = 8;
            this.labelMeanValueEstimate.Text = "Mean Value Estimate:";
            // 
            // labelMeanValueEstimateResult
            // 
            this.labelMeanValueEstimateResult.AutoSize = true;
            this.labelMeanValueEstimateResult.Location = new System.Drawing.Point(1435, 436);
            this.labelMeanValueEstimateResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMeanValueEstimateResult.Name = "labelMeanValueEstimateResult";
            this.labelMeanValueEstimateResult.Size = new System.Drawing.Size(0, 32);
            this.labelMeanValueEstimateResult.TabIndex = 9;
            // 
            // labelDispersionValueEstimate
            // 
            this.labelDispersionValueEstimate.AutoSize = true;
            this.labelDispersionValueEstimate.Location = new System.Drawing.Point(1117, 491);
            this.labelDispersionValueEstimate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDispersionValueEstimate.Name = "labelDispersionValueEstimate";
            this.labelDispersionValueEstimate.Size = new System.Drawing.Size(357, 32);
            this.labelDispersionValueEstimate.TabIndex = 10;
            this.labelDispersionValueEstimate.Text = "Dispersion Value Estimate:";
            // 
            // labelDispersionValueEstimateResult
            // 
            this.labelDispersionValueEstimateResult.AutoSize = true;
            this.labelDispersionValueEstimateResult.Location = new System.Drawing.Point(1467, 491);
            this.labelDispersionValueEstimateResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDispersionValueEstimateResult.Name = "labelDispersionValueEstimateResult";
            this.labelDispersionValueEstimateResult.Size = new System.Drawing.Size(0, 32);
            this.labelDispersionValueEstimateResult.TabIndex = 11;
            // 
            // labelDeviationValueEstimate
            // 
            this.labelDeviationValueEstimate.AutoSize = true;
            this.labelDeviationValueEstimate.Location = new System.Drawing.Point(1117, 553);
            this.labelDeviationValueEstimate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDeviationValueEstimate.Name = "labelDeviationValueEstimate";
            this.labelDeviationValueEstimate.Size = new System.Drawing.Size(342, 32);
            this.labelDeviationValueEstimate.TabIndex = 12;
            this.labelDeviationValueEstimate.Text = "Deviation Value Estimate:";
            // 
            // labelDeviationValueEstimateResult
            // 
            this.labelDeviationValueEstimateResult.AutoSize = true;
            this.labelDeviationValueEstimateResult.Location = new System.Drawing.Point(1453, 553);
            this.labelDeviationValueEstimateResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDeviationValueEstimateResult.Name = "labelDeviationValueEstimateResult";
            this.labelDeviationValueEstimateResult.Size = new System.Drawing.Size(0, 32);
            this.labelDeviationValueEstimateResult.TabIndex = 13;
            // 
            // labelIndirectSigns
            // 
            this.labelIndirectSigns.AutoSize = true;
            this.labelIndirectSigns.Location = new System.Drawing.Point(1117, 606);
            this.labelIndirectSigns.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelIndirectSigns.Name = "labelIndirectSigns";
            this.labelIndirectSigns.Size = new System.Drawing.Size(195, 32);
            this.labelIndirectSigns.TabIndex = 14;
            this.labelIndirectSigns.Text = "Indirect Signs:";
            // 
            // labelIndirectSignsResult
            // 
            this.labelIndirectSignsResult.AutoSize = true;
            this.labelIndirectSignsResult.Location = new System.Drawing.Point(1323, 606);
            this.labelIndirectSignsResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelIndirectSignsResult.Name = "labelIndirectSignsResult";
            this.labelIndirectSignsResult.Size = new System.Drawing.Size(0, 32);
            this.labelIndirectSignsResult.TabIndex = 15;
            // 
            // labelPeriodLength
            // 
            this.labelPeriodLength.AutoSize = true;
            this.labelPeriodLength.Location = new System.Drawing.Point(1117, 661);
            this.labelPeriodLength.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPeriodLength.Name = "labelPeriodLength";
            this.labelPeriodLength.Size = new System.Drawing.Size(201, 32);
            this.labelPeriodLength.TabIndex = 16;
            this.labelPeriodLength.Text = "Period Length:";
            // 
            // labelPeriodLengthResult
            // 
            this.labelPeriodLengthResult.AutoSize = true;
            this.labelPeriodLengthResult.Location = new System.Drawing.Point(1323, 661);
            this.labelPeriodLengthResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPeriodLengthResult.Name = "labelPeriodLengthResult";
            this.labelPeriodLengthResult.Size = new System.Drawing.Size(0, 32);
            this.labelPeriodLengthResult.TabIndex = 17;
            // 
            // labelAperiodicityLength
            // 
            this.labelAperiodicityLength.AutoSize = true;
            this.labelAperiodicityLength.Location = new System.Drawing.Point(1117, 711);
            this.labelAperiodicityLength.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAperiodicityLength.Name = "labelAperiodicityLength";
            this.labelAperiodicityLength.Size = new System.Drawing.Size(267, 32);
            this.labelAperiodicityLength.TabIndex = 18;
            this.labelAperiodicityLength.Text = "Aperiodicity Length:";
            // 
            // labelAperiodicityLengthResult
            // 
            this.labelAperiodicityLengthResult.AutoSize = true;
            this.labelAperiodicityLengthResult.Location = new System.Drawing.Point(1397, 711);
            this.labelAperiodicityLengthResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAperiodicityLengthResult.Name = "labelAperiodicityLengthResult";
            this.labelAperiodicityLengthResult.Size = new System.Drawing.Size(0, 32);
            this.labelAperiodicityLengthResult.TabIndex = 19;
            // 
            // comboBoxDistributions
            // 
            this.comboBoxDistributions.FormattingEnabled = true;
            this.comboBoxDistributions.Items.AddRange(new object[] {
            "",
            "Uniform Distribution",
            "Gaussian Distribution",
            "Exponential Distribution",
            "Gamma Distribution",
            "Triangular Distribution",
            "Simpson Distribution"});
            this.comboBoxDistributions.Location = new System.Drawing.Point(1707, 62);
            this.comboBoxDistributions.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.comboBoxDistributions.Name = "comboBoxDistributions";
            this.comboBoxDistributions.Size = new System.Drawing.Size(473, 39);
            this.comboBoxDistributions.TabIndex = 20;
            this.comboBoxDistributions.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistributions_SelectedIndexChanged);
            // 
            // labelImitate
            // 
            this.labelImitate.AutoSize = true;
            this.labelImitate.Location = new System.Drawing.Point(1555, 72);
            this.labelImitate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelImitate.Name = "labelImitate";
            this.labelImitate.Size = new System.Drawing.Size(108, 32);
            this.labelImitate.TabIndex = 21;
            this.labelImitate.Text = "Imitate:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(1555, 157);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(114, 32);
            this.labelFrom.TabIndex = 22;
            this.labelFrom.Text = "Enter a:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(1899, 157);
            this.labelTo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(114, 32);
            this.labelTo.TabIndex = 23;
            this.labelTo.Text = "Enter b:";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(1707, 150);
            this.textBoxFrom.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(153, 38);
            this.textBoxFrom.TabIndex = 24;
            this.textBoxFrom.Text = "-4";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(2024, 150);
            this.textBoxTo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(153, 38);
            this.textBoxTo.TabIndex = 25;
            this.textBoxTo.Text = "3";
            // 
            // labelλ
            // 
            this.labelλ.AutoSize = true;
            this.labelλ.Location = new System.Drawing.Point(1555, 331);
            this.labelλ.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelλ.Name = "labelλ";
            this.labelλ.Size = new System.Drawing.Size(112, 32);
            this.labelλ.TabIndex = 26;
            this.labelλ.Text = "Enter λ:";
            // 
            // textBoxλ
            // 
            this.textBoxλ.Location = new System.Drawing.Point(1707, 324);
            this.textBoxλ.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.textBoxλ.Name = "textBoxλ";
            this.textBoxλ.Size = new System.Drawing.Size(153, 38);
            this.textBoxλ.TabIndex = 27;
            this.textBoxλ.Text = "-2";
            // 
            // labelη
            // 
            this.labelη.AutoSize = true;
            this.labelη.Location = new System.Drawing.Point(1899, 331);
            this.labelη.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelη.Name = "labelη";
            this.labelη.Size = new System.Drawing.Size(114, 32);
            this.labelη.TabIndex = 28;
            this.labelη.Text = "Enter η:";
            // 
            // textBoxη
            // 
            this.textBoxη.Location = new System.Drawing.Point(2024, 324);
            this.textBoxη.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.textBoxη.Name = "textBoxη";
            this.textBoxη.Size = new System.Drawing.Size(153, 38);
            this.textBoxη.TabIndex = 29;
            this.textBoxη.Text = "7";
            // 
            // btnImitate
            // 
            this.btnImitate.Location = new System.Drawing.Point(1707, 439);
            this.btnImitate.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnImitate.Name = "btnImitate";
            this.btnImitate.Size = new System.Drawing.Size(472, 86);
            this.btnImitate.TabIndex = 30;
            this.btnImitate.Text = "Imitate";
            this.btnImitate.UseVisualStyleBackColor = true;
            this.btnImitate.Click += new System.EventHandler(this.btnImitate_Click);
            // 
            // labelMx
            // 
            this.labelMx.AutoSize = true;
            this.labelMx.Location = new System.Drawing.Point(1555, 236);
            this.labelMx.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMx.Name = "labelMx";
            this.labelMx.Size = new System.Drawing.Size(135, 32);
            this.labelMx.TabIndex = 31;
            this.labelMx.Text = "Enter mx:";
            // 
            // textBoxMx
            // 
            this.textBoxMx.Location = new System.Drawing.Point(1707, 234);
            this.textBoxMx.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.textBoxMx.Name = "textBoxMx";
            this.textBoxMx.Size = new System.Drawing.Size(153, 38);
            this.textBoxMx.TabIndex = 32;
            this.textBoxMx.Text = "0";
            // 
            // labelσx
            // 
            this.labelσx.AutoSize = true;
            this.labelσx.Location = new System.Drawing.Point(1899, 236);
            this.labelσx.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelσx.Name = "labelσx";
            this.labelσx.Size = new System.Drawing.Size(128, 32);
            this.labelσx.TabIndex = 33;
            this.labelσx.Text = "Enter σx:";
            // 
            // textBoxσx
            // 
            this.textBoxσx.Location = new System.Drawing.Point(2024, 234);
            this.textBoxσx.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.textBoxσx.Name = "textBoxσx";
            this.textBoxσx.Size = new System.Drawing.Size(153, 38);
            this.textBoxσx.TabIndex = 34;
            this.textBoxσx.Text = "0,2";
            // 
            // LemerRandomNumberGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2325, 862);
            this.Controls.Add(this.textBoxσx);
            this.Controls.Add(this.labelσx);
            this.Controls.Add(this.textBoxMx);
            this.Controls.Add(this.labelMx);
            this.Controls.Add(this.btnImitate);
            this.Controls.Add(this.textBoxη);
            this.Controls.Add(this.labelη);
            this.Controls.Add(this.textBoxλ);
            this.Controls.Add(this.labelλ);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelImitate);
            this.Controls.Add(this.comboBoxDistributions);
            this.Controls.Add(this.labelAperiodicityLengthResult);
            this.Controls.Add(this.labelAperiodicityLength);
            this.Controls.Add(this.labelPeriodLengthResult);
            this.Controls.Add(this.labelPeriodLength);
            this.Controls.Add(this.labelIndirectSignsResult);
            this.Controls.Add(this.labelIndirectSigns);
            this.Controls.Add(this.labelDeviationValueEstimateResult);
            this.Controls.Add(this.labelDeviationValueEstimate);
            this.Controls.Add(this.labelDispersionValueEstimateResult);
            this.Controls.Add(this.labelDispersionValueEstimate);
            this.Controls.Add(this.labelMeanValueEstimateResult);
            this.Controls.Add(this.labelMeanValueEstimate);
            this.Controls.Add(this.labelm);
            this.Controls.Add(this.labelR0);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxR0);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chartLemer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2357, 950);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1507, 753);
            this.Name = "LemerRandomNumberGeneratorForm";
            this.Text = "LemerRandomNumberGenerator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chartLemer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartLemer;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxR0;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelR0;
        private System.Windows.Forms.Label labelm;
        private System.Windows.Forms.Label labelMeanValueEstimate;
        private System.Windows.Forms.Label labelMeanValueEstimateResult;
        private System.Windows.Forms.Label labelDispersionValueEstimate;
        private System.Windows.Forms.Label labelDispersionValueEstimateResult;
        private System.Windows.Forms.Label labelDeviationValueEstimate;
        private System.Windows.Forms.Label labelDeviationValueEstimateResult;
        private System.Windows.Forms.Label labelIndirectSigns;
        private System.Windows.Forms.Label labelIndirectSignsResult;
        private System.Windows.Forms.Label labelPeriodLength;
        private System.Windows.Forms.Label labelPeriodLengthResult;
        private System.Windows.Forms.Label labelAperiodicityLength;
        private System.Windows.Forms.Label labelAperiodicityLengthResult;
        private System.Windows.Forms.ComboBox comboBoxDistributions;
        private System.Windows.Forms.Label labelImitate;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label labelλ;
        private System.Windows.Forms.TextBox textBoxλ;
        private System.Windows.Forms.Label labelη;
        private System.Windows.Forms.TextBox textBoxη;
        private System.Windows.Forms.Button btnImitate;
        private System.Windows.Forms.Label labelMx;
        private System.Windows.Forms.TextBox textBoxMx;
        private System.Windows.Forms.Label labelσx;
        private System.Windows.Forms.TextBox textBoxσx;
    }
}

