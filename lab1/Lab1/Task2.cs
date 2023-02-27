using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Task2
    {
        private static Random r = new Random();
        private double[] result;
        private int numberOfSegments;
        private long numberOfExperiments;
        private List<Tuple<int, double>> pair;
        public Task2(in int numberOfSegments, in long numberOfExperiments)
        {
            this.numberOfSegments = numberOfSegments;
            this.numberOfExperiments = numberOfExperiments;
            pair = new List<Tuple<int, double>>();
        }
        public double[] Calculate()
        {
            result = new double[numberOfExperiments];
            for (long i = 0; i < numberOfExperiments; i++)
                result[i] = CalculateRes();
            return result;
        }
        public double CalculateRes()
        {
            double[] X = { 5, 25, 55, 7, 19, 21, 17 };
            double[] P = { 0.01, 0.02, 0.02, 0.05, 0.3, 0.3, 0.3 };
            Dictionary<List<double>, double> pair = new Dictionary<List<double>, double>();
            
            double e = r.NextDouble();

            double res = X[X.Length - 1];
            for (int i = 0; i < X.Length; i++)
            {
                if (e < P[i])
                {
                    res = X[i];
                    break;
                }
            }
            return res;
        }


        public Dictionary<Double, int> CalculateResult()
        {
            double[] X = { 5, 25, 55, 7, 17, 19, 21 };
            double[] P = { 0.01, 0.02, 0.02, 0.05, 0.3, 0.3, 0.3 };

            var pairs = new Dictionary<Double, int>()
            {
                {5,0 },{25,0 },{55,0},{7,0}, {17,0 },{19,0},{21,0}
            };

            double result = default;


            for (int j = 0; j < numberOfExperiments; j++)
            {
                for (int i = 0; i < X.Length; i++)
                {
                    if (r.NextDouble() < P[i])
                    {
                        if (X[i] == 55 || X[i] == 25) result = X[r.Next(1, 3)];
                        else if (X[i] == 17 || X[i] == 19 || X[i] == 21) result = X[r.Next(4, 7)];
                        else result = X[i];


                        switch (result)
                        {
                            case 5: pairs[5]++; break;
                            case 25: pairs[25]++; break;
                            case 55: pairs[55]++; break;
                            case 7: pairs[7]++; break;
                            case 17: pairs[17]++; break;
                            case 19: pairs[19]++; break;
                            case 21: pairs[21]++; break;
                        }
                    }
                    if (result == default && i >= X.Length - 1) i -= 1;
                }
            }

            return pairs;


        }
    }
}
