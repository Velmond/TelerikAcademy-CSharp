//04.02. Create a static class PathStorage with static methods to save and load paths from a text file. 
//       Use a file format of your choice.

namespace PointStructure3D
{
    using System;
    using System.IO;

    static class PathStorage
    {
        // Method for saving a path
        public static void Save(Path path)
        {
            using (StreamWriter output = new StreamWriter(@"../../SavedPath.txt"))
            {
                foreach (Point3D point in path.PathPoints)
                {
                    output.WriteLine(point);
                }
            }
        }

        // Method for loading a path
        public static Path Load()
        {
            Path path = new Path();

            using (StreamReader input = new StreamReader(@"../../SavedPath.txt"))
            {
                string line = string.Empty;
                
                while ((line = input.ReadLine()) != null)
                {
                    string[] inputStrings = line.Split(new char[] { '[', ',', ']' }, StringSplitOptions.RemoveEmptyEntries);
                    int[] inputNumbers = new int[inputStrings.Length];

                    for (int j = 0; j < 3; j++)
                    {
                        inputNumbers[j] = int.Parse(inputStrings[j]);
                    }

                    path.Add(new Point3D(inputNumbers[0], inputNumbers[1], inputNumbers[2]));
                }
            }

            return path;
        }
    }
}
