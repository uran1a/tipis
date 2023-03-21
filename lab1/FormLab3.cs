using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;
using lab1.Lab3;

namespace lab1
{
    public partial class FormLab3 : Form
    {
        public FormLab3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Series seriesOne =
              new Series()
              {
                  Color = Color.BlueViolet,
                  Name = "График",
                  ChartType = SeriesChartType.Spline,
                  BorderWidth = 4,
              };

            var result = Tasks.Task1(0, 5);

            foreach (var item in result)
            {
                seriesOne.Points.Add(new DataPoint(item.Key, item.Value));
            }
            chart1.Series.Add(seriesOne);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            Series seriesTwo = new Series()
            {
                Color = Color.BlueViolet,
                Name = "График",
                ChartType = SeriesChartType.Spline,
                BorderWidth = 4,
            };
            int N = (int)(numericUpDown1.Value);
            int L = (int)(numericUpDown2.Value);
            var result = Tasks.Task4(0, 0.5, L, N);

            foreach (var item in result)
            {
                seriesTwo.Points.Add(new DataPoint(item.Key, item.Value));
            }
            chart2.Series.Add(seriesTwo);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            chart3.Series.Clear();
            Series seriesOne = new Series()
            {
                Color = Color.BlueViolet,
                Name = "График",
                ChartType = SeriesChartType.Spline,
                BorderWidth = 4,
            };
            int N = (int)(numericUpDown4.Value);
            int L = (int)(numericUpDown3.Value);
            var result = Tasks.Task6(20, 15, L, N);

            foreach (var item in result)
            {
                seriesOne.Points.Add(new DataPoint(item.Key, item.Value));
            }
            chart3.Series.Add(seriesOne);
        }
    }
}
