using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
    class Program
    {
        static (int index, double value) FindIndexWithMaxLast(List<GeometricProgression> progs)
        {
            if (progs == null || progs.Count == 0)
                throw new ArgumentException("Progression list must not be empty.");

            double maxVal = progs.Max(p => p.LastTerm());
            int idx = progs.FindIndex(p => p.LastTerm() == maxVal);
            return (idx + 1, maxVal); // 1-based index
        }

        static void Main(string[] args)
        {
            // Example progressions. Change or read from input as needed.
            var progs = new List<GeometricProgression>
            {
                new GeometricProgression(2, 3, 4),    // last = 54
                new GeometricProgression(5, 2, 3),    // last = 20
                new GeometricProgression(1, 10, 2),   // last = 10
                new GeometricProgression(100, 0.5, 3) // last = 25
            };

            var (idx, val) = FindIndexWithMaxLast(progs);
            Console.WriteLine($"Index with largest last term (1-based): {idx}, last term = {val}");
            Console.WriteLine($"Chosen progression: {progs[idx - 1]}");
        }
    }
}
