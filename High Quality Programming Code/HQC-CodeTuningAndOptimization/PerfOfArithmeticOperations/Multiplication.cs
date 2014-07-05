namespace PerfOfArithmeticOperations
{
    using System;
    using System.Diagnostics;

    public class Multiplication
    {
        public static TimeSpan Int()
        {
            int a = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                a *= 2;
            }
            sw.Stop();
            return sw.Elapsed;
        }
        
        public static TimeSpan Long()
        {
            long a = 0L;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                a *= 2;
            }
            sw.Stop();
            return sw.Elapsed;
        }
        
        public static TimeSpan Float()
        {
            float a = 0F;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                a *= 2;
            }
            sw.Stop();
            return sw.Elapsed;
        }
        
        public static TimeSpan Double()
        {
            double a = 0D;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                a *= 2;
            }
            sw.Stop();
            return sw.Elapsed;
        }

        public static TimeSpan Decimal()
        {
            decimal a = 0M;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                a *= 2;
            }
            sw.Stop();
            return sw.Elapsed;
        }
    }
}
