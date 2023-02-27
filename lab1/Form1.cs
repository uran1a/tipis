using lab1.Lab1;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            chartUniform1.Series.Clear();
            Series seriesFirst = new Series()
            {
                Color = Color.Red,
                Name = "График 1",
                ChartType = SeriesChartType.Line,
                BorderWidth = 1,
            };

            Series seriesSecond = new Series()
            {
                Color = Color.Blue,
                Name = "График 2",
                ChartType = SeriesChartType.Line,
                BorderWidth = 1,
            };
            int N = (int)numericUpDownSegmentsTask1.Value;
            long M1 = (long)numericUpDownExperimentsTask1_1.Value, M2 = (long)numericUpDownExperimentsTask1_2.Value;
            
            Task1 task1 = new Task1(N, M1);
            Task1 task2 = new Task1(N, M2);

            int start = -2;
            int end = 7;

            var pointsFirstGraph = task1.Calculate(start, end);
            var pointsSecondGraph = task2.Calculate(start, end);

            foreach (var item in pointsFirstGraph)
                seriesFirst.Points.Add(new DataPoint(item.Key, item.Value));
            foreach (var item in pointsSecondGraph)
                seriesSecond.Points.Add(new DataPoint(item.Key, item.Value));

            chartUniform1.Series.Add(seriesFirst);
            chartUniform1.Series.Add(seriesSecond);
        }

        private void buttonTaks2_Click(object sender, EventArgs e)
        {
            const int COUNT = 7;
            chartUniform2.Series.Clear();
            Series series = new Series()
            {
                Color = Color.Coral,
                Name = "График",
                BorderWidth = 2,
            };
            long M = (long)numericUpDownExperimentsTask2.Value;
            var pointsGraph = new Task2(COUNT, M);

            var val = pointsGraph.CalculateResult().Values.ToList();
            var key = pointsGraph.CalculateResult().Keys.ToList();

            for (int i = 0; i < 7; i++)
                series.Points.Add(new DataPoint(key[i], val[i]));
            chartUniform2.Series.Add(series);
        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            chartUniform3.Series.Clear();
            Series series = new Series()
            {
                Color = Color.ForestGreen,
                Name = "График",
                ChartType = SeriesChartType.Line,
                BorderWidth = 1,
            };
            int N = (int)numericUpDownSegmentsTask3.Value;
            long M = (long)numericUpDownExperimentsTask3.Value;
            var task = new Task3(N, M);
            var pointsGraph = task.Calculate(5, 7, 2, 1);
            foreach (var point in pointsGraph) 
                series.Points.Add(point.Value, point.Key);
            chartUniform3.Series.Add(series);
        }
    }
}
