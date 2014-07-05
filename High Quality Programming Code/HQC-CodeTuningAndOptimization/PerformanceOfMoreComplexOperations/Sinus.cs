namespace PerfOfComplexMathematicalOperations
{
    using System;
    using System.Diagnostics;

    public class Sinus
    {
        public static TimeSpan Float()
        {
            float a;
            double toSin = (double)decimal.MaxValue;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                a = (float)Math.Sin(toSin);
            }
            sw.Stop();
            return sw.Elapsed;
        }

        public static TimeSpan Double()
        {
            double a;
            double toSin = (double)decimal.MaxValue;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                a = Math.Sqrt(toSin);
            }
            sw.Stop();
            return sw.Elapsed;
        }

        public static TimeSpan Decimal()
        {
            decimal a;
            double toSin = (double)decimal.MaxValue;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                a = (decimal)Math.Sqrt(toSin);
            }
            sw.Stop();
            return sw.Elapsed;
        }
    }
}
