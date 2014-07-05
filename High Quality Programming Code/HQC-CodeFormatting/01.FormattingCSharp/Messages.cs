namespace FormattingCSharp
{
    using System;
    using System.Text;

    public static class Messages
    {
        private static readonly StringBuilder outputSB = new StringBuilder();

        public static string Output
        {
            get
            {
                return outputSB.ToString();
            }
        }

        public static void EventAdded()
        {
            outputSB.Append("Event added\n");
        }

        public static void EventDeleted(int count)
        {
            if (count == 0)
            {
                NoEventsFound();
            }
            else
            {
                outputSB.AppendFormat("{0} events deleted\n", count);
            }
        }

        public static void NoEventsFound()
        {
            outputSB.Append("No events found\n");
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                outputSB.Append(eventToPrint + "\n");
            }
        }
    }
}
