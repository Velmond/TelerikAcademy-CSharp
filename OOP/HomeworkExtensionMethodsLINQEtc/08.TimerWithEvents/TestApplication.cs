// http://msdn.microsoft.com/en-us/library/aa645739(v=vs.71).aspx
// http://msdn.microsoft.com/en-us/library/w369ty8x.aspx

namespace TimerWithEvents
{
    using System;
    using System.Threading;

    class TestApplication
    {
        // This solution to the task might be wrong since I didn't really get events... I'll be sure to dig more into them but there
        // ... won't be time to do this exercise over.

        static void Main()
        {
            Timer timer = new Timer(1);     // Create a timer that does something each second

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key at any point to stop the program!");
            Console.ForegroundColor = ConsoleColor.Gray;

            while (!Console.KeyAvailable)   // Unless key is pressed the program will keep running
            {
                if (DateTime.Now.Second % 3 == 0)
                {
                    RaiseEventMethod();
                    timer.RaiseEvent += RaiseEventMethod;   // Subscribing to an event
                }
                else
                {
                    timer.RaiseEvent -= RaiseEventMethod;   // Unsubscribing from an event
                }

                timer.Do();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("({0})", DateTime.Now.Second);
                Thread.Sleep(timer.Interval * 1000);            // Skip a second to avoid spaming the same information on the console
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static void RaiseEventMethod()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Event was raised by this method.");
        }
    }
}