using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Meta.Numerics;

namespace Theory_of_Probability_LAB3
{
    public static class Engine
    {
        private static Random R = new Random();

        public static double PlainRand(double a, double b)
        {
            return (R.NextDouble() - a) / (b - a);
        }

        public static double PlainDensity(double x, double a, double b)
        {
            return x >= a && x <= b ? 1 / (b - a) : 0;
        }

        public static double PlainFunc(double x, double a, double b)
        {
            return x >= a && x < b ? (x - a) / (b - a) : (x < a ? 0 : 1);
        }


        public static double[] NormalRand(double M, double D)
        {
            double G = PlainRand(0, 1);
            double R = PlainRand(0, 1);

            double COS = Math.Cos(2 * Math.PI * G);
            double SIN = Math.Sqrt(1 - COS * COS);
            double SQRT = Math.Sqrt(-2 * Math.Log(R, Math.E));

            return new double[] { COS * SQRT * D + M, 
                                  SIN * SQRT * D + M };
        }

        public static double NormalDensity(double x, double M, double D)
        {
            return Math.Pow(Math.E, -Math.Pow((x - M) / D, 2.0) / 2) / (D * Math.Sqrt(2 * Math.PI));
        }

        public static double NormalFunc(double x, double M, double D)
        {
            return (1 + Meta.Numerics.Functions.AdvancedMath.Erf((x - M) / (D * Math.Sqrt(2)))) / 2;
        }

        public static double ExpRand(double L)
        {
            return -Math.Log(1 - PlainRand(0, 1), Math.E) / L;
        }

        public static double ExpDensity(double x, double L)
        {
            return L * Math.Pow(Math.E, -L * x);
        }

        public static double ExpFunc(double x, double L)
        {
            return 1 - Math.Pow(Math.E, -L * x);
        }
    }
}
