namespace TimerWithDelegates
{
    using System;
    using System.Threading;

    class TestApplication
    {
        static void Main()
        {
            Timer timer = new Timer(1);                 // Create a timer that executes something each 1 second
            timer.ToDo = GenerateRandomNumber;          // Assign a method to the ToDo property that is of type TimerDelegate

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key at any point to stop the program!");
            Console.ForegroundColor = ConsoleColor.Gray;

            while (!Console.KeyAvailable)               // Unless a key is pressed the program will keep running
            {
                timer.ToDo();                           // Execute the methods assigned to ToDo
                Thread.Sleep(timer.Interval * 1000);    // Skip a second (to avoid spamming the same message on the console)
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static void GenerateRandomNumber()       // Some method to be assigned to the ToDo property of the timer
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Random number [1 to 100]: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new Random().Next(1, 101));
        }
    }
}