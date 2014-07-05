using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMinMaxAndAverage
{
    class StatisticsPrinter
    {
        /// <summary>
        /// StatisticsPrinter.Print prints the maximum, minimum and avarage values of an array of numbers
        /// </summary>
        /// <param name="values"></param>
        public void Print(double[] values)
        {
            int count = values.Length;
            double maxValue = double.MinValue;

            for (int i = 0; i < count; i++)
            {
                if (values[i] > maxValue)
                {
                    maxValue = values[i];
                }
            }

            PrintValue(maxValue);
            
            double minValue = double.MaxValue;

            for (int i = 0; i < count; i++)
            {
                if (values[i] < minValue)
                {
                    minValue = values[i];
                }
            }

            PrintValue(minValue);

            double sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += values[i];
            }

            PrintValue(sum / count);
        }

        private void PrintValue(double value)
        {
            Console.WriteLine(value.ToString());
        }
    }
}
