namespace PerfOfComplexMathematicalOperations
{
    using System;
    using System.Diagnostics;

    public class SquareRoot
    {
        public static TimeSpan Float()
        {
            float a;
            double toRoot = (double)decimal.MaxValue;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                a = (float)Math.Sqrt(toRoot);
            }
            sw.Stop();
            return sw.Elapsed;
        }

        public static TimeSpan Double()
        {
            double a;
            double toRoot = (double)decimal.MaxValue;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                a = Math.Sqrt(toRoot);
            }
            sw.Stop();
            return sw.Elapsed;
        }

        public static TimeSpan Decimal()
        {
            decimal a;
            double toRoot = (double)decimal.MaxValue;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                a = (decimal)Math.Sqrt(toRoot);
            }
            sw.Stop();
            return sw.Elapsed;
        }
    }
}
