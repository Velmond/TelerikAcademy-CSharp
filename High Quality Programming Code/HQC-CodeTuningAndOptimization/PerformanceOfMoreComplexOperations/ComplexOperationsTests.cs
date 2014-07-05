// 03. Write a program to compare the performance of square root, natural logarithm, sinus
//     for float, double and decimal values.

namespace PerfOfComplexMathematicalOperations
{
    using System;
    using System.Text;

    public class ComplexOperationsTests
    {
        public static void Main()
        {
            Console.WriteLine("Running...");
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("Square root of float takes:\t{0} ms\n", SquareRoot.Float().TotalMilliseconds.ToString()));
            result.Append(string.Format("Square root of double takes:\t{0} ms\n", SquareRoot.Double().TotalMilliseconds.ToString()));
            result.Append(string.Format("Square root of decimal takes:\t{0} ms\n", SquareRoot.Decimal().TotalMilliseconds.ToString()));
            result.Append(Environment.NewLine);
            result.Append(string.Format("Natural logarithm of float takes:\t{0} ms\n", NaturalLogarithm.Float().TotalMilliseconds.ToString()));
            result.Append(string.Format("Natural logarithm of double takes:\t{0} ms\n", NaturalLogarithm.Double().TotalMilliseconds.ToString()));
            result.Append(string.Format("Natural logarithm of decimal takes:\t{0} ms\n", NaturalLogarithm.Decimal().TotalMilliseconds.ToString()));
            result.Append(Environment.NewLine);
            result.Append(string.Format("Sinus of float takes:\t{0} ms\n", Sinus.Float().TotalMilliseconds.ToString()));
            result.Append(string.Format("Sinus of double takes:\t{0} ms\n", Sinus.Double().TotalMilliseconds.ToString()));
            result.Append(string.Format("Sinus of decimal takes:\t{0} ms", Sinus.Decimal().TotalMilliseconds.ToString()));
            
            Console.Clear();
            Console.WriteLine(result.ToString());
        }
    }
}
