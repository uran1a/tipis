using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Task1
    {
        private static Random r = new Random();
        private int numberOfSegments;
        private long numberOfExperiments;
        public Task1(in int numberOfSegments, in long numberOfExperiments)
        {
            this.numberOfSegments = numberOfSegments;
            this.numberOfExperiments = numberOfExperiments;
        }
        public Dictionary<Double, Double> Calculate(double a, double b)
        {
            double[] f = new double[numberOfSegments];
            double d = (b - a) / numberOfSegments;
            var range = Enumerable.Range(0, numberOfSegments).Select((e) => a + e * d).ToArray();
            for (long m = 0; m < numberOfExperiments; m++)
            {
                double x = rand(a, b);
                int n = (int)((x - a) / (b - a) * numberOfSegments);
                f[n] = f[n] + 1;
            }
            var result = new Dictionary<double, double>();
            for (int i = 0; i < numberOfSegments; i++)
                result.Add(range[i], f[i] / (numberOfExperiments * d));
            return result;
        }
        double rand(double a, double b)
        {
            return a + (b - a) * (r.NextDouble());
        }
    }
}
