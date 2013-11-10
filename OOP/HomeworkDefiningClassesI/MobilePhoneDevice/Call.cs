namespace MobilePhoneDevice
{
    using System;

    public class Call
    {
        // Fields:
        public DateTime callDateTime;
        private string dialedNumber;
        private uint callDuration;

        // Constructors:
        public Call(DateTime callDateTime, string dialedNumber, uint callDuration)
        {
            this.CallDateTime = callDateTime;
            this.DialedNumber = dialedNumber;
            this.CallDuration = callDuration;
        }

        // Properties:
        public DateTime CallDateTime
        {
            get
            {
                return this.callDateTime;
            }
            set
            {
                this.callDateTime = value;
            }
        }

        public string DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }
            set
            {
                if ((value.Length == 10 && value[0] == '0') || (value.Length == 13 && value.StartsWith("+359")))
                {
                    this.dialedNumber = value;
                }
                else
                {
                    throw new ArgumentException("Incorect number format.");
                }
            }
        }

        public uint CallDuration
        {
            get
            {
                return this.callDuration;
            }
            set
            {
                this.callDuration = value;
            }
        }
    }
}