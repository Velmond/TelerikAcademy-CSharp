//05. Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
//    Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
//    Implement methods for adding element, accessing element by index, removing element by index, inserting element at
//    given position, clearing the list, finding element by its value and ToString(). Check all input parameters to avoid
//    accessing elements at invalid positions.
//06. Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all
//    elements to it.
//07. Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
//    You may need to add a generic constraints for the type T.

namespace GenericList
{
    using System;
    using System.Text;

    public class GenericList<T>
        where T : IComparable<T>
    {
        private T[] list;                           // Array in which the elements will be kept
        private uint currentIndex;                  // Index of the element that has to be filled next
        private const uint DEFAULT_ELEMENTS = 4;    // Initial 'capacity' of the list (initial lenght of the array)

        // Property for getting the number of added elements in the list
        public uint Count
        {
            get { return this.currentIndex; }
        }

        // Property for getting the capacity of the list (the max number of elements it can accommodate before resizing)
        public uint Capacity
        {
            get { return (uint)this.list.Length; }
        }

        // Construct a GenericList with a set initial capacity
        public GenericList(uint initialElements)
        {
            this.list = new T[initialElements];
        }

        // ... or use an empty construcrtor to use the default capacity
        public GenericList()
            : this(DEFAULT_ELEMENTS)
        {
        }

        // Method for adding elements
        public void Add(T element)
        {
            if (this.currentIndex < this.list.Length)       // Check if we're still bellow the last element in the array
            {
                this.list[this.currentIndex] = element;
                this.currentIndex++;
            }
            else                                            // If we've hit the max of the elements count that can fit in the array
            {                                               // ... list the auto-grow functionality kicks in making an array that is
                T[] newList = new T[2 * this.list.Length];  // ... double the size of the original and fill it in with all the values
                //                                          // ... from the original. After that we are free to add the element we
                for (int i = 0; i < this.list.Length; i++)  // ... want to the new (bigger) array.
                {
                    newList[i] = this.list[i];
                }

                newList[this.currentIndex] = element;
                this.currentIndex++;

                this.list = newList;
            }
        }

        // Indexer for accessing element by index
        public T this[int index]
        {
            get
            {
                if (index < this.currentIndex)
                {
                    return this.list[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index < this.currentIndex)
                {
                    this.list[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        // Method for removing an element by index
        public void RemoveAt(int index)
        {
            if (index < this.currentIndex)
            {
                T[] newList;

                if (this.currentIndex - 1 < this.list.Length / 2)   // If after removing the element we need an array that is smaller
                {                                                   // ... than half the size of the original, the new array is 
                    newList = new T[this.list.Length / 2];          // ... declared with that size
                }
                else
                {
                    newList = new T[this.list.Length];              // ... Otherwise the new array is tha size of the original
                }

                for (int i = 0; i < newList.Length - 1; i++)
                {
                    if (i < index)
                    {
                        newList[i] = this.list[i];
                    }
                    else
                    {
                        newList[i] = this.list[i + 1];
                    }
                }

                this.list = newList;
                this.currentIndex--;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        // Method for inserting element at given position
        public void Insert(int index, T value)
        {
            if (index < this.currentIndex)
            {
                T[] newList;

                if (this.currentIndex + 1 < this.list.Length)   // Check if the array needs resizing (auto-growth)
                {
                    newList = new T[this.list.Length];
                }
                else
                {
                    newList = new T[2 * this.list.Length];
                }

                for (int i = 0; i < this.list.Length; i++)
                {
                    if (i < index)
                    {
                        newList[i] = this.list[i];
                    }
                    else if (i > index)
                    {
                        newList[i] = this.list[i - 1];
                    }
                    else
                    {
                        newList[i] = value;
                    }
                }

                this.list = newList;
                this.currentIndex++;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        // Method for clearing the list
        public void Clear()
        {
            this.list = new T[DEFAULT_ELEMENTS];    // Return to the default capacity
            this.currentIndex = 0;                  // Return the 'index-to-be-filled' to 0
        }

        // Method for finding element by its value
        public int Find(T soughtElement)
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (this.list[i].Equals(soughtElement)) // Since T needs to implement IComparable<T> we can be sure it will
                {                                       // ... have a .Equals() method
                    return i;   // Return the index if the element is found
                }
            }

            return -1;          // ... Otherwise return -1
        }

        // Override the ToString() method
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            for (int i = 0; i < this.currentIndex; i++)
            {
                toString.Append(this.list[i]);

                if (i != this.currentIndex - 1)
                {
                    toString.Append(" ");
                }
            }

            return toString.ToString();
        }

        // Generic methods Min<T>() and Max<T>()
        public T Min<T>()
        {
            if (this.Count > 0)
            {
                dynamic minElement = this.list[0];

                for (int i = 0; i < this.Count; i++)
                {
                    dynamic temp = this.list[i];

                    if (temp.CompareTo(minElement) < 0)
                    {
                        minElement = this.list[i];
                    }
                }

                return minElement;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public T Max<T>()
        {
            if (this.Count > 0)
            {
                dynamic maxElement = this.list[0];

                for (int i = 0; i < this.Count; i++)
                {
                    dynamic temp = this.list[i];

                    if (temp.CompareTo(maxElement) > 0)
                    {
                        maxElement = this.list[i];
                    }
                }

                return maxElement;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}