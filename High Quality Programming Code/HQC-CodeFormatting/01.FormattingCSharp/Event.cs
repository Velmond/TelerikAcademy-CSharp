namespace FormattingCSharp
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        public int CompareTo(object obj)
        {
            Event otherEvent = obj as Event;
            int comparedByDate = this.Date.CompareTo(otherEvent.Date);
            int comparedByTitle = this.Title.CompareTo(otherEvent.Title);
            int comparedByLocation = this.Location.CompareTo(otherEvent.Location);

            if (comparedByDate == 0)
            {
                if (comparedByTitle == 0)
                {
                    return comparedByLocation;
                }
                else
                {
                    return comparedByTitle;
                }
            }
            else
            {
                return comparedByDate;
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            toString.Append(this.Date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.Title);
            if (this.Location != null && this.Location != string.Empty)
            {
                toString.Append(" | " + this.Location);
            }

            return toString.ToString();
        }
    }
}
