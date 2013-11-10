namespace InvalidRangeException
{
    using System;

    public class InvalidRangeException<T> : SystemException
        where T : IComparable
    {
        private T startValue;
        private T endValue;

        public T StartValue
        {
            get { return startValue; }
            set { startValue = value; }
        }

        public T EndValue
        {
            get { return endValue; }
            set { endValue = value; }
        }

        public InvalidRangeException(T startValue, T endValue)
        {
            this.StartValue = startValue;
            this.EndValue = endValue;
        }

        public override string Message
        {
            get
            {
                return string.Format("Value is outside of the range [{0}; {1}]", this.StartValue, this.EndValue);
            }
        }
    }
}