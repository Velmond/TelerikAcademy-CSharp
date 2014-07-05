// Task 01. Refactor the following examples to produce code with well-named C# identifiers:

namespace BooleanWriter
{
    using System;
    using System.Linq;

    public class BooleanWriter
    {
        public const int MaxCount = 6;

        public static void WriteTrue()
        {
            Writer writer = new Writer();
            writer.WriteBooleanOnConsole(true);
        }

        private class Writer
        {
            public void WriteBooleanOnConsole(bool variable)
            {
                string variableAsString = variable.ToString();
                Console.WriteLine(variableAsString);
            }
        }
    }
}
