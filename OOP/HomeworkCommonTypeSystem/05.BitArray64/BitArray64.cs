namespace BitArray64
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    class BitArray64 : IEnumerable<int>
    {
        private ulong value;
        private int[] bitArray;

        public ulong Value
        {
            get { return this.value; }
            private set { this.value = value; }
        }

        public BitArray64(ulong value)
        {
            this.Value = value;
            this.bitArray = this.ConvertToBitsArray(this.Value);
        }

        private int[] ConvertToBitsArray(ulong number)
        {
            int[] array = new int[64];

            for (int i = 0; i < array.Length; i++)
            {
                array[(array.Length - 1) - i] = (int)((number >> i) & 1);
            }

            return array;
        }

        public override int GetHashCode()
        {
            return this.bitArray.GetHashCode();
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index must be between 0 and 64.");
                }

                return this.bitArray[index];
            }
        }

        public override bool Equals(object obj)
        {
            BitArray64 other = obj as BitArray64;

            if ((object)other == null)
            {
                return false;
            }

            if (!ulong.Equals(this.Value, other.Value))
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !BitArray64.Equals(first, second);
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            foreach (var bit in this.bitArray)
            {
                toString.Append(bit);
            }

            return toString.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.bitArray.Length; i++)
            {
                yield return this.bitArray[i];
            }
        }
    }
}
