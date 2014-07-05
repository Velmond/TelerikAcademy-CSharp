namespace PerfOfComplexMathematicalOperations
{
    using System;
    using System.Diagnostics;

    public class NaturalLogarithm
    {
        public static TimeSpan Float()
        {
            float a;
            double toLog = (double)decimal.MaxValue;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                a = (float)Math.Log(toLog);
            }
            sw.Stop();
            return sw.Elapsed;
        }

        public static TimeSpan Double()
        {
            double a;
            double toLog = (double)decimal.MaxValue;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                a = Math.Log(toLog);
            }
            sw.Stop();
            return sw.Elapsed;
        }

        public static TimeSpan Decimal()
        {
            decimal a;
            double toLog = (double)decimal.MaxValue;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                a = (decimal)Math.Log(toLog);
            }
            sw.Stop();
            return sw.Elapsed;
        }
    }
}
