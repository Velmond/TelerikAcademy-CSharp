namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        // Fields:
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;

        public Battery Battery = new Battery(BatteryType.LiIon);
        public Display Display = new Display(1);

        // Constructors:
        public GSM(string model, string manufacturer, double? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public GSM(string model, string manufacturer, double? price, Display display)
            : this(model, manufacturer, price, null, null, display)
        {
        }

        public GSM(string model, string manufacturer, double? price, Battery battery)
            : this(model, manufacturer, price, null, battery, null)
        {
        }

        public GSM(string model, string manufacturer, double? price, string owner)
            : this(model, manufacturer, price, owner, null, null)
        {
        }

        public GSM(string model, string manufacturer, double? price)
            : this(model, manufacturer, price, null, null, null)
        {
        }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, null, null)
        {
        }

        // Properties:
        public string Model
        {
            get { return this.model; }
            set
            {
                if (value == null || value.Length != 0)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("Model must be at least 1 character long.");
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value == null || value.Length >= 2)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException("Manufacturer must be at least 2 character long.");
                }
            }
        }

        public double? Price
        {
            get { return this.price; }
            set
            {
                if (value == null || value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException("Price must be a positive number.");
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value == null || value.Length > 0)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentException("Manufacturer must be at least 1 character long.");
                }
            }
        }

        // Overriding ToString() method:
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append("Model: " + this.model);
            toString.Append("\nManufacturer: " + this.manufacturer);

            if (this.Price != null)
            {
                toString.Append("\nPrice: " + this.price.ToString());
            }

            if (this.owner != null)
            {
                toString.Append("\nOwner: " + this.owner);
            }

            if (this.Battery != null)
            {
                toString.Append("\nBattery: " + this.Battery.ToString());
            }

            if (this.Display != null)
            {
                toString.Append("\nDisplay: " + this.Display.ToString());
            }

            return toString.ToString();
        }

        // Static field and propertie iPhone 4s (task 6):
        static private GSM iPhone4S = new GSM("iPhone 4S", "Apple", 1299, "Pesho", new Battery(BatteryType.LiIon), new Display(4));

        static public GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        // List<Call> (task 9):
        private List<Call> callHistory = new List<Call>();

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        //Methods (task 10):
        public void AddCall(DateTime callDateTime, string dialedNumber, uint callDuration)
        {
            Call call = new Call(callDateTime, dialedNumber, callDuration);
            CallHistory.Add(call);
        }

        public void DeleteCall(int callIndex)
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                if (i == callIndex)
                {
                    CallHistory.RemoveAt(i);
                    return;
                }
            }
        }

        public void ClearHistory()
        {
            CallHistory.Clear();
        }

        public double TotalPrice(double pricePerMinute)
        {
            double totalPrice = 0;

            for (int i = 0; i < CallHistory.Count; i++)
            {
                if (CallHistory[i].CallDuration <= 60)  //Calls under 1 minute get priced as a full minute
                {
                    totalPrice += pricePerMinute;
                }
                else    //Above 1 minute you pay for each second
                {
                    totalPrice += (pricePerMinute * CallHistory[i].CallDuration / 60.0);
                }
            }

            return totalPrice;
        }

        public void DisplayCallHistory()
        {
            StringBuilder callHistory = new StringBuilder();
            int entryNumber = 1;

            Console.WriteLine("CALL HISTORY");
            if (CallHistory.Count != 0)
            {
                foreach (Call call in CallHistory)
                {
                    callHistory.Append(entryNumber);
                    callHistory.Append(". Time: " + call.CallDateTime);
                    callHistory.Append(", Number: " + call.DialedNumber);
                    callHistory.Append(", Duration: " + call.CallDuration);
                    Console.WriteLine(callHistory.ToString());
                    callHistory.Clear();
                    entryNumber++;
                }
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }
    }
}