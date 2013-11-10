namespace StringBuilderSubstringExtension
{
    using System;
    using System.Text;

    class TestApplication
    {
        static void Main()
        {
            // Check the Unit testing project (01.02.StringBuilderSubstringExtensionTests) for the real tests.

            StringBuilder sb = new StringBuilder();

            sb.Append("12345");

            // Testing the overload for method 'Substring' that takes 2 arguments
            for (int startIndex = 0; startIndex < sb.Length; startIndex++)
            {
                for (int length = 1; length <= sb.Length - startIndex; length++)
                {
                    Console.WriteLine(sb.Substring(startIndex, length));
                }
            }

            // Testing the overload for method 'Substring' that takes 1 arguments
            for (int i = 0; i < sb.Length; i++)
            {
                Console.WriteLine(sb.Substring(i));
            }
        }
    }
}
