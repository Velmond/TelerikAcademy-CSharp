namespace MobilePhoneDevice
{
    using System;
    using System.Text;

    public class Display
    {
        // Fields:
        private double screenSize;
        private uint? numberOfColors;

        // Constructors:
        public Display(double screenSize, uint? numberOfColors)
        {
            this.ScreenSize = screenSize;
            this.NumberOfColors = numberOfColors;
        }

        public Display(double screenSize)
            : this(screenSize, null)
        {
        }

        // Properties:
        public double ScreenSize
        {
            get { return this.screenSize; }
            set
            {
                if (value > 0)
                {
                    this.screenSize = value;
                }
                else
                {
                    throw new ArgumentException("Screen size can only be a positive number above 0.");
                }
            }
        }

        public uint? NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value == null || value > 0)
                {
                    this.numberOfColors = value;
                }
                else
                {
                    throw new ArgumentException("No display can have 0 colors.");
                }
            }
        }

        // Overriding ToString() method
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append("[screen size: " + this.ScreenSize + "], [colors: ");

            if (this.NumberOfColors != null)
            {
                toString.Append(this.NumberOfColors);
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