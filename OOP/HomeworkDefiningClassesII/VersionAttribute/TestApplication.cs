//11.02. Apply the version attribute to a sample class and display its version at runtime.

namespace VersionAttribute
{
    using System;

    [Version(2.11)]
    public class TestApplication
    {
        static void Main()
        {
            Type type = typeof(TestApplication);

            object[] allAttributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attribute in allAttributes)
            {
                Console.Write("Version: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(attribute.Version);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}