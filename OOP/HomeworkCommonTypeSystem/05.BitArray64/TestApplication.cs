//05. Define a class BitArray64 to hold 64 bit values inside an ulong value.
//    Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace BitArray64
{
    using System;

    class TestApplication
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            BitArray64[] array = {
                                     new BitArray64(6148914691236517205),
                                     new BitArray64(9223372036854775807),
                                     new BitArray64(18446744073709551615),
                                     new BitArray64(1234567890123456789),
                                     new BitArray64(1),
                                     new BitArray64(4611686018427387904),
                                     new BitArray64(9223372036854775808),
                                     new BitArray64(4294967295),
                                     new BitArray64(9223372032559808512),
                                     new BitArray64(18446744069414584320)
                                 };

            foreach (var number in array)
            {
                Console.WriteLine("Value: {0}", number.Value);
                Console.WriteLine("Binary: {0}", number);
                Console.WriteLine();
            }

            // Expected results:
            // Value: 6148914691236517205
            // Binary: 0101010101010101010101010101010101010101010101010101010101010101
            // Value: 9223372036854775807
            // Binary: 0111111111111111111111111111111111111111111111111111111111111111
            // Value: 18446744073709551615
            // Binary: 1111111111111111111111111111111111111111111111111111111111111111
            // Value: 1234567890123456789
            // Binary: 0001000100100010000100001111010001111101111010011000000100010101
            // Value: 1
            // Binary: 0000000000000000000000000000000000000000000000000000000000000001
            // Value: 4611686018427387904
            // Binary: 0100000000000000000000000000000000000000000000000000000000000000
            // Value: 9223372036854775808
            // Binary: 1000000000000000000000000000000000000000000000000000000000000000
            // Value: 4294967295
            // Binary: 0000000000000000000000000000000011111111111111111111111111111111
            // Value: 9223372032559808512
            // Binary: 0111111111111111111111111111111100000000000000000000000000000000
            // Value: 18446744069414584320
            // Binary: 1111111111111111111111111111111100000000000000000000000000000000

            Console.ForegroundColor = ConsoleColor.White;

            BitArray64 someNumber = array[9];
            // array[9] = 18446744069414584320 (1111111111111111111111111111111100000000000000000000000000000000)
            // Check some of the bits of the 9-th entry in the array of BitArray64s
            if (someNumber[0] == 1 && someNumber[15] == 1 && someNumber[31] == 1 && someNumber[47] == 0 && someNumber[63] == 0)
            {
                Console.WriteLine("Program works properly.");
            }
            else
            {
                Console.WriteLine("Program doesn't work properly.");
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Testing Equals(), == and !=
            Console.WriteLine(array[0].Equals(array[1]));           // False
            Console.WriteLine(array[0] == array[1]);                // False
            Console.WriteLine(array[0] != array[1]);                // True
            Console.WriteLine(array[4] == new BitArray64(1));       // True
            Console.WriteLine(array[4].Equals(new BitArray64(1)));  // True

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
