//07. Using delegates write a class Timer that has can execute certain method at each t seconds.

namespace TimerWithDelegates
{
    using System;
    using System.Threading;

    public class Timer
    {
        public delegate void TimerDelegate();   // Delegate

        // Private fields, one of which holds methods to be executed
        private int interval;
        private TimerDelegate toDo;

        // Public properties to access the fields
        public int Interval
        {
            get { return this.interval; }
            set { this.interval = value; }
        }

        public TimerDelegate ToDo
        {
            get { return this.toDo; }
            set { this.toDo = value; }
        }

        // Constructor
        public Timer(int interval)
        {
            this.Interval = interval;
        }
    }
}