using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Lab1
{
    internal class Task3
    {
        private static Random random = new Random();
        private int numberOfSegments;   
        private long numberOfExperiments;
        public Task3(in int numberOfSegments, in long numberOfExperiments)
        {
            this.numberOfSegments = numberOfSegments;
            this.numberOfExperiments = numberOfExperiments;
        }
        public Dictionary<Double, Double> Calculate(double a, double b, double disp, double wait)
        {
            var points_graph = new Task1(numberOfSegments, numberOfExperiments).Calculate(a, b);
            double d = (b - a) / numberOfSegments;
            double[] result = new double[numberOfSegments];
            for (int i = 0; i < numberOfExperiments; i++)
            {
                double x = Task3.GaussianRandomValues(a, b, disp, wait);
                int n = (int)((x - a) / (b - a) * numberOfSegments);
                result[n] = result[n] + 1;
            }
            for (int i = 0; i < numberOfSegments; i++)
            {
                result[i] = result[i] / (numberOfExperiments * d);
                points_graph[points_graph.ElementAt(i).Key] += result[i];
            }
            return points_graph;
        }


        public static double GaussianRandomValues(double a, double b, double disp, double wait)
        {
            double x = 0;
            while (true)
            {
                x = MathNet.Numerics.Distributions.Normal.Sample(random, wait, disp);
                if (x <= b && x >= a) break;
            }
            return x;
        }
        public static double GaussianRandomOneValue(double disp, double wait)
        {
            double x = 0;
            while (true)
            {
                x = MathNet.Numerics.Distributions.Normal.Sample(random, wait, disp);
                break;
            }
            return x;
        }
    }
}
