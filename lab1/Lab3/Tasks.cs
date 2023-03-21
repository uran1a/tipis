using lab1.Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Lab3
{
    internal class Tasks
    {
        private static Random random = new Random();
        public static Dictionary<double, double> Task6(int M, int MM, int L = 200, int N = 50)
        {
            double[] s = new double[N], k = new double[N], x = new double[N];
            for (int i = 0; i < N; i++) s[i] = Math.Sin(-2.0 * Math.PI * i / N);
            for (int i = 0; i < N; i++) k[i] = s[N - 1 - i];

            double porog = 0.95;
            var result = new Dictionary<double, double>();
            var d_prav = new double[MM];
            for (int n = 0; n < MM; n++)
            {
                var A = 0.2 + 0.05 * n;
                for (int j = 0; j < 200; j++)
                {
                    for (int i = 0; i < N; i++) x[i] = GaussRandom((_) => true, 0, 1) + A * s[i];
                    var z = Solg();
                    if (z >= porog) d_prav[n] += 1.0 / 200.0;
                }
                result.Add(A, d_prav[n]);
            }
            double Solg()
            {
                var sym = default(double);
                for (int i = 0; i < N; i++) sym = sym + x[i] * k[N - 1 - i];
                return sym;
            }

            return result;
        }
        public static Dictionary<double, double> Task1(int a, int b)
        {
            double[] Y_n = new double[b + 1];
            var result = new Dictionary<double, double>();
            for (int x = 0; x <= b; x++)
            {
                var t = GaussRandom((_) => true, a, b);
                Y_n[x] = Newton(t);
                if(!result.ContainsKey(t))
                    result.Add(t, Y_n[x]);
            }
            return result;

            double Newton(double t)
            {
                return Primitive(t) - Primitive(0);
            }
        }
        public static Dictionary<double, double> Task4(double a, double b, int L = 150, int N = 50)
        {
            double[] s = new double[L], k = new double[L], x = new double[N], y = new double[N];
            var result = new Dictionary<double, double>();
            int i, p, n;

            for (i = 0; i < L; i++)
            { s[i] = 1.0 * i / L; x[i] = s[i]; }

            for (i = 0; i < L; i++)
                k[i] = s[L - i - 1];
            for (i = 2 * L; i < 3 * L; i++)
                x[i] = x[i] + s[i - 2 * L];
            // Добавление шума во входную реализацию
            for (i = 0; i < N; i++)
                x[i] = x[i] + GaussRandom((_) => true, a, b);
            // Согласованная фильтрация
            for (i = 0; i < N; i++)
            {
                y[i] = 0.0;
                for (p = 0; p < L; p++)
                {
                    if ((i - p) >= 0)
                        y[i] = y[i] + x[i - p] * k[p];
                }
                result.Add(x[i], y[i]);
            }
            return result;
        }
        private static double Primitive(double x)
        {
            double tau = 6.2831853071;
            // return (double)( (8 * Math.Sin((x / 2.0) - 7) - 64 * Math.Cos((x / 2.0) - 7)) / (325.0 * Math.Pow(Math.E, 4 * x)));
            //return (4 * tau - 4 * x - 139) / (20 * Math.Pow(Math.E, 4 * tau));
            return -139.0 / (20 * Math.Pow(Math.E, 4 * tau)) + x / 5 + 139.0 / 20.0;
        }
        private static double GaussRandom(Predicate<double> state, double a, double b)
        {
            double retval = default;
            while (true)
            {
                retval = MathNet.Numerics.Distributions.Normal.Sample(random, a, b);
                if (state.Invoke(retval)) { break; }
            }
            return retval;
        }
    }
}
