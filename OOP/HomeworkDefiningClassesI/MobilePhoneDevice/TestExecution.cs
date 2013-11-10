namespace MobilePhoneDevice
{
    using System;

    // The following is a complete description of the solution that is meant more for the ones that couldn't do the homeworkn their 
    // ...own and not for other ones that did. Read it if you want and/or need to.
    
    // [Task 1]
    // All the classes that are required by the first task are added as separate classes. What I mean is it's not:
    /*
    class Battery
    {
         // code
    }
    class Display
    {
         // code
    }
    class GSM
    {
         // code
    }
    */
    // ... all in the same file, but are separated (you can see them on the right).
    // You can quickly add a class by using the shortcut Alt+Shift+C and giving it a name.

    // [Task 2]
    // In each of the classes (Battery, Display and GSM) their are several constructors indicated by a comment rigth before the first 
    // ...one. The following is an explanation of how I chose to go with the variations of the constructors:
    // A constructor can invoke another constructor in the same object by using the this keyword. This can be used with or without 
    // ...parameters, and any parameters in the constructor are available as parameters to this, or as part of an expression.
    // For example, the second constructor can be rewritten using this:
    //      public Employee(int weeklySalary, int numberOfWeeks)
    //       : this(weeklySalary * numberOfWeeks)
    //      {
    //      }
    // In other words in my case I use this to point to the constructor with all the parameters, with value null where one misses.
    // ...In other words with the following constructor as base:
    //      public Battery(string model, uint? hoursIdle, uint? hoursTalk, BatteryType batteryType)
    //      {
    //          this.Model = model;
    //          this.HoursIdle = hoursIdle;
    //          this.HoursTalk = hoursTalk;
    //          this.BatteryType = batteryType;
    //      }
    // ...I can make another constructor with only the battery type as input:
    //      public Battery(BatteryType batteryType)
    //          : this(null, null, null, batteryType)
    //      {
    //      }
    // You can find more about it on -> http://msdn.microsoft.com/en-us/library/vstudio/ms173115.aspx

    // [Tasks 3, 4]
    // I don't think this needs explanation. The override of ToString() is done for all three classes.

    // [Task 5]
    // The properties are all added in the classes and a check for incorrect input is made for the ones that need it.
    // They are alse indicated by a comment before the first one in all three classes.
    // It is important to note that in the following checks:
    //      if (value == null || value != string.Empty)
    //      if (value == null || value > 0)
    // ...the (value == null) has to be first because if it is it can't be compaired to either string.Empty or 0 and would cause an 
    // ...exception (NullReferanceException if I'm not mistaken). That is not really OOP material but is worth the mention.

    // [Task 6]
    // You can see the solution at rows 149 to 159. It's mighty simple so I can't think of what to explaine about it.
    // The IPhone4S propertie only has a getter as I doesn't need a setter in my oppinion.

    // [Task 7]
    // The logic is put in the GSMTest class but the Main() method is in the TestExecution class so that's both this test and the one 
    // ...in task 12 can be executed from there.
    // The array has 6 entries as is the number of the constructors for the class GSM so I can test them all.
    // The first five test the constructors that have less than all the information that can be entered in the constructor.
    // The last entry in the array is the IPhone4S which uses the last constructor that hasn't been tested (the one with all the 
    // ...values not null).

    // [Task 8]
    // There is nothing spetial about the Call class.

    // [Task 9]
    // I've included a private field and a public property List<Call>, but I'm not sure if that's what is required...

    // [Task 10]
    // The tasks are indicated in the GSM class by a comment before the first one.
    // The DeleteCall method deletes entries by their index in the call history list.

    // [Task 11]
    // I've added an additional condition that if the call is under a minute the price is as a full minute and only if it goes over
    // ...that minute it's priced for each second.

    // [Task 12]
    // Again the logic is put in the GSMCallHistoryTest class but the Main() method is in the TestExecution class so that's both this
    // ...test and the one in task 7 can be executed from there.
    // I've added a DisplayCallHistory() method in the GSM class so that it's easier to get it displayed on the console.
    // An additional private method is added to the GSMCallHistoryTest class that serves to find the index of the call with the
    // ...longest duration as that is the call that should be removed according to the task description.

    // I hope this helped clarify my solution to you (if you needed it of course)

    class TestExecution
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("GSM TEST:");
            Console.WriteLine(new string('-', 40));
            Console.ForegroundColor = ConsoleColor.Gray;

            GSMTest.Test();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("CALL HISTORY TEST:");
            Console.WriteLine(new string('-', 40));
            Console.ForegroundColor = ConsoleColor.Gray;

            GSMCallHistoryTest.CallHistoryTest();
        }
    }
}
