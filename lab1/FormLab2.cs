using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab1
{
    public partial class FormLab2 : Form
    {
        public FormLab2()
        {
            InitializeComponent();
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            chartTask1.Series.Clear();
            Series seriesFirst = new Series()
            {
                Color = Color.Red, 
                Name = "График 1",
                ChartType = SeriesChartType.Line,
                BorderWidth = 1,
            };
            int N = (int)numericUpDownTask1.Value;
            foreach (var ob in CalculateTask1(-2, 7, Math.Log(0.95), N))
                seriesFirst.Points.Add(new DataPoint(ob.Key, ob.Value));
            chartTask1.Series.Add(seriesFirst);
        }

        Random RND = new Random();
        double mean = 2;
        double std = 5;
        public Dictionary<double, double> CalculateTask1(double a, double b, double k, int N)
        {

            //double p_1 = 0.95;
            double e, k1, k2; int n;
            double[] x = new double[N];
            var d = (b - a) / N;
            k2 = Math.Exp(k);
            k1 = Math.Sqrt(std * (1.0 - k2 * k2));
            x[0] = GaussRandom(0, std);
            for (n = 1; n < N; n++)
            {
                e = GaussRandom(0, 1);
                x[n] = k1 * e + k2 * x[n - 1];
            }

            var range = Enumerable.Range(0, N).Select((ee) => a + ee * d).ToArray();

            var result = new Dictionary<double, double>();
            for (int i = 0; i < N; i++)
                result.Add(range[i], x[i] / (d));
            return result;



        }
        private double GaussRandom(double a, double b)
        {
            double retval = default;
            while (true)
            {
                retval = MathNet.Numerics.Distributions.Normal.Sample(RND, mean, std);
                if (retval <= b && retval >= a) { break; }
            }
            return retval;
        }

        private void buttonTask4_Click(object sender, EventArgs e)
        {
            chartTask4.Series.Clear();
            Series seriesFirst = new Series()
            {
                Color = Color.Blue,
                Name = "График 2",
                ChartType = SeriesChartType.Line,
                BorderWidth = 1,
            };
            int N = (int) numericUpDownTask4.Value;

            foreach (var item in CalculateTask2(1, N))
                seriesFirst.Points.Add(item);
            chartTask4.Series.Add(seriesFirst);
        }

        public List<double> CalculateTask2(double b, int N)
        {
            Dictionary<double, double> Xn = this.CalculateTask1(0, 1, Math.Log(0.02), N);
            List<double> Yn = new List<double>();
            for (int n = 1; n < N; n++) 
                Yn.Add(2 * Xn.ElementAt(n).Value + b * Xn.ElementAt(n-1).Value);
            return Yn;
        }
    }
}
