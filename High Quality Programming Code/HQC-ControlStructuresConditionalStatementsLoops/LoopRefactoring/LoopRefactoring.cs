namespace LoopRefactoring
{
    using System;

    class LoopRefactoring
    {
        static void Main()
        {
            int[] array = new int[100];

            //... initialise array values ...

            int expectedValue = 666;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

                if (i % 10 == 0 && array[i] == expectedValue)
                {
                    Console.WriteLine("Value Found");
                    break;
                }
            }
        }
    }
}
