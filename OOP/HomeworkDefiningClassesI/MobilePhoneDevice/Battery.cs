namespace MobilePhoneDevice
{
    using System;
    using System.Text;

    public enum BatteryType
    {
        LiPoly,
        LiIon,
        NiMH,
        NiCd
    }

    public class Battery
    {
        // Fields:
        private string model;
        private float? hoursIdle;
        private float? hoursTalk;
        private BatteryType batteryType;

        // Constructors:
        public Battery(string model, uint? hoursIdle, uint? hoursTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public Battery(string model, uint? hoursIdle, BatteryType batteryType)
            : this(model, hoursIdle, null, batteryType)
        {
        }

        public Battery(string model, BatteryType batteryType)
            : this(model, null, null, batteryType)
        {
        }

        public Battery(BatteryType batteryType)
            : this(null, null, null, batteryType)
        {
        }

        // Properties:
        public string Model
        {
            get { return this.model; }
            set
            {
                if (value == null || value != string.Empty)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("Incorect input for battery model.");
                }
            }
        }

        public float? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value == null || value > 0)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentException("Idle hours for the battery can't be 0 or less.");
                }
            }
        }

        public float? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value == null || value > 0)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentException("Talk hours for the battery can't be 0 or less.");
                }
            }
        }

        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        // Overriding ToString() method
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append("[type: ");

            if (this.BatteryType.ToString() != string.Empty)
            {
                toString.Append(this.BatteryType);
            }
            else
            {
                toString.Append("N/A");
            }

            toString.Append("], [model: ");

            if (this.Model != string.Empty && this.Model != null)
            {
                toString.Append(this.Model);
            }
            else
            {
                toString.Append("N/A");
            }

            toString.Append("], [hours idle: ");

            if (this.HoursIdle != null)
            {
                toString.Append(this.HoursIdle);
            }
            else
            {
                toString.Append("N/A");
            }

            toString.Append("], [hours talk: ");

            if (this.HoursTalk != null)
            {
                toString.Append(this.HoursTalk);
            }
            else
            {
                toString.Append("N/A");
            }

            toString.Append("]");

            return toString.ToString();
        }
    }
}