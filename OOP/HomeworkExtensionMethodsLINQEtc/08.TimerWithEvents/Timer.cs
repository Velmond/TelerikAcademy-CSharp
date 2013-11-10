//08.*Read in MSDN about the keyword event in C# and how to publish events.
//    Re-implement the above using .NET events and following the best practices.

namespace TimerWithEvents
{
    using System;
    using System.Threading;

    public class Timer
    {
        private int interval;

        public int Interval
        {
            get { return this.interval; }
            set { this.interval = value; }
        }

        public Timer(int interval)
        {
            this.Interval = interval;
        }

        public delegate void TimerEventHandler();

        // Declare the event using TimerEventHandler
        public event TimerEventHandler RaiseEvent;

        public void Do()
        {
            TimerEventHandler handler = RaiseEvent;

            if (handler != null)    // If subscribed to the event execute the following code
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Random number [1 to 100]: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(new Random().Next(1, 101) + " ");
            }
        }
    }
}