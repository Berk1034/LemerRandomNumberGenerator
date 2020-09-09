using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LemerRandomNumberGenerator
{
    public partial class LemerRandomNumberGeneratorForm : Form
    {
        private List<double> generatedSequence = new List<double>();
        private List<double> generatedSequenceCopy = new List<double>();
        private const int COUNT = 1000000;
        private const int INTERVALS_COUNT = 20;
        private double meanValue, dispersionValue;
        private int period = 0;

        public LemerRandomNumberGeneratorForm()
        {
            InitializeComponent();
            comboBoxDistributions.SelectedIndex = 0;
        }

        private double CalculateLemer(double a, double R, double m)
        {
            double result = (a * R) % m;
            generatedSequence.Add(result / m);

            return result;
        }

        private void CalculateMeanValueEstimate()
        {
            double sum = 0;
            for (int i = 0; i < COUNT; i++)
            {
                sum += generatedSequence[i];
            }

            meanValue = sum / COUNT;

            labelMeanValueEstimateResult.Text = meanValue.ToString("0.000");
        }

        private void CalculateDispersionAndDeviationValueEstimates()
        {
            double sum = 0;
            for (int i = 0; i < COUNT; i++)
            {
                sum += Math.Pow(generatedSequence[i] - meanValue, 2);
            }

            dispersionValue = sum / (COUNT - 1);

            labelDispersionValueEstimateResult.Text = dispersionValue.ToString("0.000");
            labelDeviationValueEstimateResult.Text = Math.Sqrt(dispersionValue).ToString("0.000");
        }

        private void CheckByIndirectSigns()
        {
            double couples = 0;
            for (int i = 0; i < generatedSequence.Count; i += 2)
            {
                if (Math.Pow(generatedSequence[i], 2) + Math.Pow(generatedSequence[i + 1], 2) < 1)
                {
                    couples++;
                }
            }

            double result = 2 * couples / COUNT;

            labelIndirectSignsResult.Text = result.ToString("0.000");
        }

        private void CalculatePeriodLength()
        {
            int x1 = 0;
            int x2 = 0;

            for (int i = 0; i < generatedSequence.Count; i++)
            {
                if (generatedSequence[i] == generatedSequence[COUNT - 1])
                {
                    x1 = i;
                    break;
                }
            }

            for (int i = x1 + 1; i < generatedSequence.Count; i++)
            {
                if (generatedSequence[i] == generatedSequence[COUNT - 1])
                {
                    x2 = i;
                    break;
                }
            }

            period = x2 - x1;

            labelPeriodLengthResult.Text = period.ToString();
        }

        private void CalculateAperiodictyLength()
        {
            int aperiodicityLength = 0;
            for (int i = 0; i < COUNT; i++)
            {
                if (generatedSequence[i] == generatedSequence[Math.Abs(i + period) % COUNT])
                {
                    aperiodicityLength = i + period;
                    break;
                }
            }

            labelAperiodicityLengthResult.Text = aperiodicityLength.ToString();
        }

        private void DrawHistogram()
        {
            chartLemer.Series["LemerSeries"].Points.Clear();

            generatedSequence.Sort();
            double minValue = generatedSequence[0];
            double maxValue = generatedSequence[COUNT - 1];

            double variationRange = Math.Abs(maxValue - minValue);
            double intervalLength = Math.Round(variationRange / INTERVALS_COUNT, 2);

            double interval = Math.Round(minValue) + intervalLength;
            int insideIntervalCounter = 0;

            for (int i = 0; i < generatedSequence.Count; i++)
            {
                if (generatedSequence[i] <= interval)
                {
                    insideIntervalCounter++;
                }
                else
                {
                    chartLemer.Series["LemerSeries"].Points.AddXY(interval, insideIntervalCounter / Convert.ToDouble(COUNT));
                    insideIntervalCounter = 0;
                    interval += intervalLength;
                }
            }

            chartLemer.Series["LemerSeries"].Points.AddXY(interval, insideIntervalCounter / Convert.ToDouble(COUNT));
        }

        private void comboBoxDistributions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxDistributions.SelectedIndex)
            {
                case 0:
                    textBoxA.Enabled = true;
                    textBoxR0.Enabled = true;
                    textBoxM.Enabled = true;
                    btnCalculate.Enabled = true;
                    textBoxFrom.Enabled = false;
                    textBoxTo.Enabled = false;
                    textBoxλ.Enabled = false;
                    textBoxη.Enabled = false;
                    textBoxMx.Enabled = false;
                    textBoxσx.Enabled = false;
                    btnImitate.Enabled = false;
                    break;
                case 1:
                case 5:
                case 6:
                    textBoxA.Enabled = false;
                    textBoxR0.Enabled = false;
                    textBoxM.Enabled = false;
                    btnCalculate.Enabled = false;
                    textBoxFrom.Enabled = true;
                    textBoxTo.Enabled = true;
                    textBoxλ.Enabled = false;
                    textBoxη.Enabled = false;
                    textBoxMx.Enabled = false;
                    textBoxσx.Enabled = false;
                    btnImitate.Enabled = true;
                    break;
                case 2:
                    textBoxA.Enabled = false;
                    textBoxR0.Enabled = false;
                    textBoxM.Enabled = false;
                    btnCalculate.Enabled = false;
                    textBoxFrom.Enabled = false;
                    textBoxTo.Enabled = false;
                    textBoxλ.Enabled = false;
                    textBoxη.Enabled = false;
                    textBoxMx.Enabled = true;
                    textBoxσx.Enabled = true;
                    btnImitate.Enabled = true;
                    break;
                case 3:
                    textBoxA.Enabled = false;
                    textBoxR0.Enabled = false;
                    textBoxM.Enabled = false;
                    btnCalculate.Enabled = false;
                    textBoxFrom.Enabled = false;
                    textBoxTo.Enabled = false;
                    textBoxλ.Enabled = true;
                    textBoxη.Enabled = false;
                    textBoxMx.Enabled = false;
                    textBoxσx.Enabled = false;
                    btnImitate.Enabled = true;
                    break;
                case 4:
                    textBoxA.Enabled = false;
                    textBoxR0.Enabled = false;
                    textBoxM.Enabled = false;
                    btnCalculate.Enabled = false;
                    textBoxFrom.Enabled = false;
                    textBoxTo.Enabled = false;
                    textBoxλ.Enabled = true;
                    textBoxη.Enabled = true;
                    textBoxMx.Enabled = false;
                    textBoxσx.Enabled = false;
                    btnImitate.Enabled = true;
                    break;
            }
        }

        private void ImitateUniformDistribution(double from, double to)
        {
            for (int i = 0; i < COUNT; i++)
            {
                generatedSequence[i] = from + (to - from) * generatedSequence[i];
            }
        }

        private void ImitateGaussianDistribution(double mx, double dx)
        {
            int counter = 0;

            for (int i = 0; i < COUNT; i++)
            {
                double sum = 0;
                for (int j = 1; j <= 6; j++)
                {
                    sum += generatedSequenceCopy[counter % COUNT];
                    counter++;
                }

                generatedSequence[i] = mx + dx * Math.Sqrt(2) * (sum - 3);
            }

        }

        private void ImitateExponentialDistribution(double lambda)
        {
            for (int i = 0; i < COUNT; i++)
            {
                generatedSequence[i] = -1 / lambda * Math.Log(generatedSequence[i]);
            }
        }

        private void ImitateGammaDistribution(double lambda, double n)
        {
            int counter = 0;

            for (int i = 0; i < COUNT; i++)
            {
                double mul = 1;
                for (int j = 1; j <= n; j++)
                {
                    mul *= generatedSequenceCopy[counter % COUNT];
                    counter++;
                }

                generatedSequence[i] = -1 / lambda * Math.Log(mul);
            }
        }

        private void ImitateTriangularDistribution(double a, double b)
        {
            for (int i = 0; i < COUNT; i++)
            {
                generatedSequence[i] = a + (b - a) * Math.Max(generatedSequence[i % COUNT], generatedSequence[(i + 1) % COUNT]);
            }
        }

        private void ImitateSimpsonDistribution()
        {
            for (int i = 0; i < COUNT; i++)
            {
                generatedSequence[i] = generatedSequence[i % COUNT] + generatedSequence[(i + 1) % COUNT];
            }
        }

        private void btnImitate_Click(object sender, EventArgs e)
        {
            GenerateSequence();

            switch (comboBoxDistributions.SelectedIndex)
            {
                case 1:
                    double from = Convert.ToDouble(textBoxFrom.Text);
                    double to = Convert.ToDouble(textBoxTo.Text);
                    ImitateUniformDistribution(from, to);
                    break;
                case 2:
                    double mx = Convert.ToDouble(textBoxMx.Text);
                    double dx = Convert.ToDouble(textBoxσx.Text);
                    ImitateGaussianDistribution(mx, dx);
                    break;
                case 3:
                    double lambda = Convert.ToDouble(textBoxλ.Text);
                    ImitateExponentialDistribution(lambda);
                    break;
                case 4:
                    double λ = Convert.ToDouble(textBoxλ.Text);
                    double n = Convert.ToDouble(textBoxη.Text);
                    ImitateGammaDistribution(λ, n);
                    break;
                case 5:
                    double a = Convert.ToDouble(textBoxFrom.Text);
                    double b = Convert.ToDouble(textBoxTo.Text);
                    ImitateTriangularDistribution(a, b);
                    break;
                case 6:
                    double aS = Convert.ToDouble(textBoxFrom.Text);
                    double bS = Convert.ToDouble(textBoxTo.Text);
                    ImitateUniformDistribution(aS / 2, bS / 2);
                    ImitateSimpsonDistribution();
                    break;
            }
            CalculateMeanValueEstimate();
            CalculateDispersionAndDeviationValueEstimates();
            labelIndirectSignsResult.Text = "";
            labelPeriodLengthResult.Text = "";
            labelAperiodicityLengthResult.Text = "";

            DrawHistogram();
        }

        public void GenerateSequence()
        {
            generatedSequence.Clear();

            double a = Convert.ToDouble(textBoxA.Text);
            double R = Convert.ToDouble(textBoxR0.Text);
            double m = Convert.ToDouble(textBoxM.Text);

            for (int i = 0; i < COUNT; i++)
            {
                R = CalculateLemer(a, R, m);
            }

            generatedSequenceCopy = new List<double>(generatedSequence);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            GenerateSequence();

            CalculateMeanValueEstimate();
            CalculateDispersionAndDeviationValueEstimates();
            CheckByIndirectSigns();
            CalculatePeriodLength();
            CalculateAperiodictyLength();
            DrawHistogram();
        }
    }
}
