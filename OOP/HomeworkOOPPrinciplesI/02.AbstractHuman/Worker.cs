namespace AbstractHuman
{
    using System;

    class Worker : Human
    {
        private double weekSalary;
        private int workHoursPerDay;

        public double WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; }
        }

        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }

        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            double workDays = 5;

            return (this.WeekSalary / (this.WorkHoursPerDay * workDays));
        }

        public override string ToString()
        {
            return string.Concat(this.FirstName + " " + this.LastName + " (Money per hour: " + string.Format("{0:f2}", this.MoneyPerHour()) + ")");
        }
    }
}
