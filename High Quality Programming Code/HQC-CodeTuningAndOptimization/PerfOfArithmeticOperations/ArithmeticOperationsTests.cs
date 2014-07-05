// 02. Write a program to compare the performance of add, subtract, increment, multiply, divide
//     for int, long, float, double and decimal values.

namespace PerfOfArithmeticOperations
{
    using System;
    using System.Text;

    public class ArithmeticOperationsTests
    {
        public static void Main()
        {
            Console.WriteLine("Running...");
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("Additions of int takes:\t\t{0} ms\n", Addition.Int().TotalMilliseconds.ToString()));
            result.Append(string.Format("Additions of long takes:\t\t{0} ms\n", Addition.Long().TotalMilliseconds.ToString()));
            result.Append(string.Format("Additions of float takes:\t{0} ms\n", Addition.Float().TotalMilliseconds.ToString()));
            result.Append(string.Format("Additions of double takes:\t{0} ms\n", Addition.Double().TotalMilliseconds.ToString()));
            result.Append(string.Format("Additions of decimal takes:\t{0} ms\n", Addition.Decimal().TotalMilliseconds.ToString()));
            result.Append(Environment.NewLine);
            result.Append(string.Format("Subtractions of int takes:\t{0} ms\n", Subtraction.Int().TotalMilliseconds.ToString()));
            result.Append(string.Format("Subtractions of long takes:\t{0} ms\n", Subtraction.Long().TotalMilliseconds.ToString()));
            result.Append(string.Format("Subtractions of float takes:\t{0} ms\n", Subtraction.Float().TotalMilliseconds.ToString()));
            result.Append(string.Format("Subtractions of double takes:\t{0} ms\n", Subtraction.Double().TotalMilliseconds.ToString()));
            result.Append(string.Format("Subtractions of decimal takes:\t{0} ms\n", Subtraction.Decimal().TotalMilliseconds.ToString()));
            result.Append(Environment.NewLine);
            result.Append(string.Format("Incrementation of int takes:\t{0} ms\n", Incrementation.Int().TotalMilliseconds.ToString()));
            result.Append(string.Format("Incrementation of long takes:\t{0} ms\n", Incrementation.Long().TotalMilliseconds.ToString()));
            result.Append(string.Format("Incrementation of float takes:\t{0} ms\n", Incrementation.Float().TotalMilliseconds.ToString()));
            result.Append(string.Format("Incrementation of double takes:\t{0} ms\n", Incrementation.Double().TotalMilliseconds.ToString()));
            result.Append(string.Format("Incrementation of decimal takes:\t{0} ms\n", Incrementation.Decimal().TotalMilliseconds.ToString()));
            result.Append(Environment.NewLine);
            result.Append(string.Format("Multiplication of int takes:\t{0} ms\n", Multiplication.Int().TotalMilliseconds.ToString()));
            result.Append(string.Format("Multiplication of long takes:\t{0} ms\n", Multiplication.Long().TotalMilliseconds.ToString()));
            result.Append(string.Format("Multiplication of float takes:\t{0} ms\n", Multiplication.Float().TotalMilliseconds.ToString()));
            result.Append(string.Format("Multiplication of double takes:\t{0} ms\n", Multiplication.Double().TotalMilliseconds.ToString()));
            result.Append(string.Format("Multiplication of decimal takes:\t{0} ms\n", Multiplication.Decimal().TotalMilliseconds.ToString()));
            result.Append(Environment.NewLine);
            result.Append(string.Format("Division of int takes:\t\t{0} ms\n", Division.Int().TotalMilliseconds.ToString()));
            result.Append(string.Format("Division of long takes:\t\t{0} ms\n", Division.Long().TotalMilliseconds.ToString()));
            result.Append(string.Format("Division of float takes:\t\t{0} ms\n", Division.Float().TotalMilliseconds.ToString()));
            result.Append(string.Format("Division of double takes:\t{0} ms\n", Division.Double().TotalMilliseconds.ToString()));
            result.Append(string.Format("Division of decimal takes:\t{0} ms", Division.Decimal().TotalMilliseconds.ToString()));

            Console.Clear();
            Console.WriteLine(result.ToString());
        }
    }
}
