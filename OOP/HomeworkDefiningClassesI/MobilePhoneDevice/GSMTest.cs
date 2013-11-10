namespace MobilePhoneDevice
{
    using System;

    public class GSMTest
    {
        // The following method is executed in the Main() method which is located in the TestExecution class

        public static void Test()
        {
            GSM[] GSMArray = new GSM[6];    // Each of the elements is initialized by using all the different constructors

            GSMArray[0] = new GSM("One", "HTC");
            GSMArray[1] = new GSM("Lumia 1020", "Nokia", 1299.00);
            GSMArray[2] = new GSM("Galaxy S4", "Samsung", 899.00, "Pesho Peshov");
            GSMArray[3] = new GSM("ATIV S", "Samsung", 599.00, new Battery("I8750", 168, 8, BatteryType.LiIon));
            GSMArray[4] = new GSM("Windows Phone 8X", "HTC", 699.00, new Display(4.3, 16000000));
            GSMArray[5] = GSM.IPhone4S;

            for (int i = 0; i < GSMArray.Length; i++)  // Use the overridden ToString method to display the phone info on the console
            {
                Console.WriteLine(GSMArray[i].ToString());
                Console.WriteLine();
            }
        }
    }
}
