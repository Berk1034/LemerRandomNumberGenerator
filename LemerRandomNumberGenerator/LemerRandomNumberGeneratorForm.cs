using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LemerRandomNumberGenerator
{
    public partial class LemerRandomNumberGeneratorForm : Form
    {
        private List<double> generatedSequence = new List<double>();
        private const int COUNT = 100000;
        private const int INTERVALS_COUNT = 20;
        private double meanValue, dispersionValue;
        private int period;

        public LemerRandomNumberGeneratorForm()
        {
            InitializeComponent();
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
            period = 0;

            for (int i = 1; i < generatedSequence.Count; i++)
            {
                if (generatedSequence[i] == generatedSequence[0])
                {
                    period = i;
                    break;
                }
            }

            labelPeriodLengthResult.Text = period.ToString();
        }

        private void CalculateAperiodictyLength()
        {
            int aperiodicityLength = 0;
            if (period != 0)
            {
                aperiodicityLength = COUNT % period;
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            generatedSequence.Clear();

            double a = Convert.ToDouble(textBoxA.Text);
            double R = Convert.ToDouble(textBoxR0.Text);
            double m = Convert.ToDouble(textBoxM.Text);

            for (int i = 0; i < COUNT; i++)
            {
                R = CalculateLemer(a, R, m);
            }

            CalculateMeanValueEstimate();
            CalculateDispersionAndDeviationValueEstimates();
            CheckByIndirectSigns();
            CalculatePeriodLength();
            CalculateAperiodictyLength();
            DrawHistogram();
        }
    }
}
