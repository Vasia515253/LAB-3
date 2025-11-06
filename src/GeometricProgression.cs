using System;

namespace Lab3
{
    public class GeometricProgression
    {
        public double A1 { get; }
        public double Q { get; }
        public int N { get; }

        public GeometricProgression(double a1, double q, int n)
        {
            A1 = a1;
            Q = q;
            N = n;
        }

        public double LastTerm()
        {
            if (N <= 0)
                return double.NegativeInfinity;
            return A1 * Math.Pow(Q, N - 1);
        }

        public override string ToString()
        {
            return $"GeometricProgression(a1={A1}, q={Q}, n={N}, last={LastTerm()})";
        }
    }
}
