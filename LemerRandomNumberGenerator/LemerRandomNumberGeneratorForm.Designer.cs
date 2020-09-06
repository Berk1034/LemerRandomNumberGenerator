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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartLemer)).BeginInit();
            this.SuspendLayout();
            // 
            // chartLemer
            // 
            chartArea6.Name = "ChartArea1";
            this.chartLemer.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.chartLemer.Legends.Add(legend6);
            this.chartLemer.Location = new System.Drawing.Point(12, 12);
            this.chartLemer.Name = "chartLemer";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "LemerSeries";
            this.chartLemer.Series.Add(series6);
            this.chartLemer.Size = new System.Drawing.Size(541, 426);
            this.chartLemer.TabIndex = 0;
            this.chartLemer.Text = "LemerChart";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(634, 167);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 44);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(634, 34);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(110, 22);
            this.textBoxA.TabIndex = 2;
            this.textBoxA.Text = "52142";
            // 
            // textBoxR0
            // 
            this.textBoxR0.Location = new System.Drawing.Point(634, 78);
            this.textBoxR0.Name = "textBoxR0";
            this.textBoxR0.Size = new System.Drawing.Size(110, 22);
            this.textBoxR0.TabIndex = 3;
            this.textBoxR0.Text = "2145";
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(634, 121);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(110, 22);
            this.textBoxM.TabIndex = 4;
            this.textBoxM.Text = "123131";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(570, 37);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(58, 17);
            this.labelA.TabIndex = 5;
            this.labelA.Text = "Enter a:";
            // 
            // labelR0
            // 
            this.labelR0.AutoSize = true;
            this.labelR0.Location = new System.Drawing.Point(560, 81);
            this.labelR0.Name = "labelR0";
            this.labelR0.Size = new System.Drawing.Size(68, 17);
            this.labelR0.TabIndex = 6;
            this.labelR0.Text = "Enter R0:";
            // 
            // labelm
            // 
            this.labelm.AutoSize = true;
            this.labelm.Location = new System.Drawing.Point(567, 124);
            this.labelm.Name = "labelm";
            this.labelm.Size = new System.Drawing.Size(61, 17);
            this.labelm.TabIndex = 7;
            this.labelm.Text = "Enter m:";
            // 
            // labelMeanValueEstimate
            // 
            this.labelMeanValueEstimate.AutoSize = true;
            this.labelMeanValueEstimate.Location = new System.Drawing.Point(559, 225);
            this.labelMeanValueEstimate.Name = "labelMeanValueEstimate";
            this.labelMeanValueEstimate.Size = new System.Drawing.Size(145, 17);
            this.labelMeanValueEstimate.TabIndex = 8;
            this.labelMeanValueEstimate.Text = "Mean Value Estimate:";
            // 
            // labelMeanValueEstimateResult
            // 
            this.labelMeanValueEstimateResult.AutoSize = true;
            this.labelMeanValueEstimateResult.Location = new System.Drawing.Point(717, 225);
            this.labelMeanValueEstimateResult.Name = "labelMeanValueEstimateResult";
            this.labelMeanValueEstimateResult.Size = new System.Drawing.Size(0, 17);
            this.labelMeanValueEstimateResult.TabIndex = 9;
            // 
            // labelDispersionValueEstimate
            // 
            this.labelDispersionValueEstimate.AutoSize = true;
            this.labelDispersionValueEstimate.Location = new System.Drawing.Point(559, 254);
            this.labelDispersionValueEstimate.Name = "labelDispersionValueEstimate";
            this.labelDispersionValueEstimate.Size = new System.Drawing.Size(177, 17);
            this.labelDispersionValueEstimate.TabIndex = 10;
            this.labelDispersionValueEstimate.Text = "Dispersion Value Estimate:";
            // 
            // labelDispersionValueEstimateResult
            // 
            this.labelDispersionValueEstimateResult.AutoSize = true;
            this.labelDispersionValueEstimateResult.Location = new System.Drawing.Point(734, 254);
            this.labelDispersionValueEstimateResult.Name = "labelDispersionValueEstimateResult";
            this.labelDispersionValueEstimateResult.Size = new System.Drawing.Size(0, 17);
            this.labelDispersionValueEstimateResult.TabIndex = 11;
            // 
            // labelDeviationValueEstimate
            // 
            this.labelDeviationValueEstimate.AutoSize = true;
            this.labelDeviationValueEstimate.Location = new System.Drawing.Point(559, 286);
            this.labelDeviationValueEstimate.Name = "labelDeviationValueEstimate";
            this.labelDeviationValueEstimate.Size = new System.Drawing.Size(169, 17);
            this.labelDeviationValueEstimate.TabIndex = 12;
            this.labelDeviationValueEstimate.Text = "Deviation Value Estimate:";
            // 
            // labelDeviationValueEstimateResult
            // 
            this.labelDeviationValueEstimateResult.AutoSize = true;
            this.labelDeviationValueEstimateResult.Location = new System.Drawing.Point(727, 286);
            this.labelDeviationValueEstimateResult.Name = "labelDeviationValueEstimateResult";
            this.labelDeviationValueEstimateResult.Size = new System.Drawing.Size(0, 17);
            this.labelDeviationValueEstimateResult.TabIndex = 13;
            // 
            // labelIndirectSigns
            // 
            this.labelIndirectSigns.AutoSize = true;
            this.labelIndirectSigns.Location = new System.Drawing.Point(559, 313);
            this.labelIndirectSigns.Name = "labelIndirectSigns";
            this.labelIndirectSigns.Size = new System.Drawing.Size(97, 17);
            this.labelIndirectSigns.TabIndex = 14;
            this.labelIndirectSigns.Text = "Indirect Signs:";
            // 
            // labelIndirectSignsResult
            // 
            this.labelIndirectSignsResult.AutoSize = true;
            this.labelIndirectSignsResult.Location = new System.Drawing.Point(662, 313);
            this.labelIndirectSignsResult.Name = "labelIndirectSignsResult";
            this.labelIndirectSignsResult.Size = new System.Drawing.Size(0, 17);
            this.labelIndirectSignsResult.TabIndex = 15;
            // 
            // labelPeriodLength
            // 
            this.labelPeriodLength.AutoSize = true;
            this.labelPeriodLength.Location = new System.Drawing.Point(559, 341);
            this.labelPeriodLength.Name = "labelPeriodLength";
            this.labelPeriodLength.Size = new System.Drawing.Size(101, 17);
            this.labelPeriodLength.TabIndex = 16;
            this.labelPeriodLength.Text = "Period Length:";
            // 
            // labelPeriodLengthResult
            // 
            this.labelPeriodLengthResult.AutoSize = true;
            this.labelPeriodLengthResult.Location = new System.Drawing.Point(662, 341);
            this.labelPeriodLengthResult.Name = "labelPeriodLengthResult";
            this.labelPeriodLengthResult.Size = new System.Drawing.Size(0, 17);
            this.labelPeriodLengthResult.TabIndex = 17;
            // 
            // labelAperiodicityLength
            // 
            this.labelAperiodicityLength.AutoSize = true;
            this.labelAperiodicityLength.Location = new System.Drawing.Point(559, 367);
            this.labelAperiodicityLength.Name = "labelAperiodicityLength";
            this.labelAperiodicityLength.Size = new System.Drawing.Size(133, 17);
            this.labelAperiodicityLength.TabIndex = 18;
            this.labelAperiodicityLength.Text = "Aperiodicity Length:";
            // 
            // labelAperiodicityLengthResult
            // 
            this.labelAperiodicityLengthResult.AutoSize = true;
            this.labelAperiodicityLengthResult.Location = new System.Drawing.Point(698, 367);
            this.labelAperiodicityLengthResult.Name = "labelAperiodicityLengthResult";
            this.labelAperiodicityLengthResult.Size = new System.Drawing.Size(0, 17);
            this.labelAperiodicityLengthResult.TabIndex = 19;
            // 
            // LemerRandomNumberGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "LemerRandomNumberGeneratorForm";
            this.Text = "LemerRandomNumberGenerator";
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
    }
}

