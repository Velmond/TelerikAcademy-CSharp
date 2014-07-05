namespace StatisticsPrinter
{
    using System;
    
    public class StatisticsPrinter
    {
        /// <summary>
        /// StatisticsPrinter.Print prints the maximum, minimum and avarage values of an array of numbers
        /// </summary>
        /// <param name="values">An array of numbers out of which the minimum, maximum and average should be printed</param>
        public void Print(double[] values)
        {
            double maxValue = GetMaxValue(values);
            PrintValue(maxValue);

            double minValue = GetMinValue(values);
            PrintValue(minValue);
            
            double averageValue = GetAverageValue(values);
            PrintValue(averageValue);
        }

        /// <summary>
        /// Finds the maximum from the values in an array of numbers
        /// </summary>
        /// <param name="values">Array of numbers</param>
        /// <returns>The maximum value from all the numbers in the array</returns>
        private double GetMaxValue(double[] values)
        {
            int valuesCount = values.Length;
            double maxValue = double.MinValue;

            for (int i = 0; i < valuesCount; i++)
            {
                if (values[i] > maxValue)
                {
                    maxValue = values[i];
                }
            }

            return maxValue;
        }

        /// <summary>
        /// Finds the minimum from the values in an array of numbers
        /// </summary>
        /// <param name="values">Array of numbers</param>
        /// <returns>The minimum value from all the numbers in the array</returns>
        private double GetMinValue(double[] values)
        {
            int valuesCount = values.Length;
            double minValue = double.MaxValue;

            for (int i = 0; i < valuesCount; i++)
            {
                if (values[i] < minValue)
                {
                    minValue = values[i];
                }
            }

            return minValue;
        }

        /// <summary>
        /// Finds the average of the values in an array of numbers
        /// </summary>
        /// <param name="values">Array of numbers</param>
        /// <returns>The average value from all the numbers in the array</returns>
        private double GetAverageValue(double[] values)
        {
            int valuesCount = values.Length;
            double sum = 0;

            for (int i = 0; i < valuesCount; i++)
            {
                sum += values[i];
            }

            double average = sum / valuesCount;
            return average;
        }

        /// <summary>
        /// Outputs a value to the console
        /// </summary>
        /// <param name="value">Value to be printed</param>
        private void PrintValue(double value)
        {
            Console.WriteLine(value.ToString());
        }
    }
}
