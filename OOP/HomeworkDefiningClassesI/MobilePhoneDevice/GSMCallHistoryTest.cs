namespace MobilePhoneDevice
{
    using System;

    public class GSMCallHistoryTest
    {
        // The following method is executed in the Main() method which is located in the TestExecution class

        public static void CallHistoryTest()
        {
            GSM myGSM = new GSM("Galaxy Note III", "Samsung");  // Initialize a new phone

            myGSM.AddCall(DateTime.Now.AddSeconds(8432), "0888123456", 36);         // Stuff it's call history with entries
            myGSM.AddCall(DateTime.Now.AddSeconds(12415), "+359888123456", 511);
            myGSM.AddCall(DateTime.Now.AddSeconds(22425), "0877123456", 14);
            myGSM.AddCall(DateTime.Now.AddSeconds(29434), "+359888123456", 643);
            myGSM.AddCall(DateTime.Now.AddSeconds(42213), "0899123456", 186);
            myGSM.AddCall(DateTime.Now.AddSeconds(52411), "+359888123456", 152);

            myGSM.DisplayCallHistory(); // Display the call history
            Console.WriteLine();
            Console.WriteLine("Price: {0:f2}", myGSM.TotalPrice(.37));  // Display the price for all the entries
            Console.WriteLine();

            myGSM.DeleteCall(FindIndexOfLongestCall(myGSM));    // Remove the entry at the index where the longest call is kept

            myGSM.DisplayCallHistory();
            Console.WriteLine();
            Console.WriteLine("Price: {0:f2}", myGSM.TotalPrice(.37));  // Display the price for the entries that remain
            Console.WriteLine();

            myGSM.ClearHistory();       // Clear the history

            myGSM.DisplayCallHistory();
            Console.WriteLine();
            Console.WriteLine("Price: {0:f2}", myGSM.TotalPrice(.37));
            Console.WriteLine();
        }

        static int FindIndexOfLongestCall(GSM myGSM)    // Method used to find the index of the longest call in the call history
        {
            uint maxDuration = 0;
            int indexOfLongestCall = 0;

            for (int i = 0; i < myGSM.CallHistory.Count; i++)
            {
                if (myGSM.CallHistory[i].CallDuration > maxDuration)
                {
                    maxDuration = myGSM.CallHistory[i].CallDuration;
                    indexOfLongestCall = i;
                }
            }

            return indexOfLongestCall;
        }
    }
}
