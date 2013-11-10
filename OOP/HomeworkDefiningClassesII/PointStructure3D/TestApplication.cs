namespace PointStructure3D
{
    using System;

    class TestApplication
    {
        static void Main()
        {
            //Task 01 test
            /*=======================================================================================*/
            Console.Write("Declare point A with empty constructor and add coords later: ");
            
            Point3D A = new Point3D();  // Declairing a point with an empty constructor (initial coords are [0, 0, 0])
            A.XCoord = 1;               // Add the coords after declairing the point
            A.YCoord = 2;
            A.ZCoord = -1;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(A.ToString());    // Use the overridden ToString() method
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();
            /*=======================================================================================*/
            Console.Write("Declare point B: ");

            Point3D B = new Point3D(-1, 4, -2); // Declairing a point with a non-empty constructor

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(B);
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();

            //Task 02 test
            /*=======================================================================================*/
            Console.Write("Point O (0, 0, 0): ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Point3D.Zero);
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();

            //Task 03 test
            /*=======================================================================================*/
            Console.WriteLine("Distances: ");

            Console.Write("A to B: ");
            double distance = Distance3D.Distance(A, B);    // Distance between two points

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0:f2}", distance);
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("O to A: ");
            distance = Distance3D.Distance(A);              // Distance to point A (from O)

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0:f2}", distance);
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();

            //Task 04 test
            /*=======================================================================================*/
            Console.WriteLine("Add points to path and print it using overridden ToString method for the path: ");

            Point3D C = new Point3D(-1, -1, -1);
            Point3D D = new Point3D(2, 3, -5);
            Point3D E = new Point3D(4, -2, -1);
            Point3D F = new Point3D(-2, 1, 4);

            Path path = new Path(); // Create a path

            path.Add(Point3D.Zero); // ... and add points to it
            path.Add(A);
            path.Add(B);
            path.Add(C);
            path.Add(D);
            path.Add(E);
            path.Add(F);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(path.ToString());             // Print the path on the console
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();
            /*=======================================================================================*/
            Console.WriteLine("Saving path to file (SavedPath.txt): ");

            PathStorage.Save(path);     // Save the path to a .txt file

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Done!");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();
            /*=======================================================================================*/
            Console.WriteLine("Loading path from file (SavedPath.txt): ");

            Path newPath = PathStorage.Load();      // Create a new path from the points with coordinates saved in the .txt file

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(newPath.ToString());  // Print the new path on the console
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();
        }
    }
}