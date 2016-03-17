using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLists
{
    class GenericList<T>
    {
        protected const byte CapacityStep = 4;
        private int capacity;
        private int currentElementIndex;
        private T[] elements;

        public GenericList(int capacity)
        {
            currentElementIndex = 0;
            Capacity = capacity;
            elements = new T[Capacity];
        }
        public int Capacity
        {
            get { return capacity; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The capacity cannot be a negative number");
                }
                capacity = value;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > currentElementIndex - 1)
                {
                    throw new ArgumentException("Invalid index");
                }

                return elements[index];
            }
            set
            {
                if (index < 0 || index > currentElementIndex - 1)
                {
                    throw new ArgumentException("Invalid index");
                }

                RemoveAt(index);
                InsertAt(index, value);
            }
        }
        public int GetPosition(T obj)
        {
            if (obj is Nullable && obj == null)
            {
                throw new ArgumentNullException();
            }

            int position = -1;
            for (int i = 0; i < currentElementIndex; i++)
            {
                if (elements[i].Equals(obj))
                {
                    position = i;
                    break;
                }
            }

            return position;
        }
        public void Add(T obj)
        {
            InsertAt(currentElementIndex, obj);
        }

        public void InsertAt(int position, T obj)
        {
            if (obj is Nullable && obj == null)
            {
                throw new ArgumentNullException();
            }

            if (position < 0 || position > currentElementIndex)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (currentElementIndex > 0 && currentElementIndex % CapacityStep == 0)
            {
                ЕxpandArray();
            }

            int rightValuesCount = currentElementIndex - position;
            if (rightValuesCount > 0)
            {
                var rightValues = new T[rightValuesCount];
                Array.Copy(elements, position, rightValues, 0, rightValuesCount); // sourceArray, sourceIndex, destinationArray, destinationIndex, length
                elements[position] = obj;
                Array.Copy(rightValues, 0, elements, position + 1, rightValuesCount);
            }
            else
            {
                elements[currentElementIndex] = obj;
            }

            currentElementIndex++;
        }

        protected void ЕxpandArray()
        {
            int newCapacity = elements.Count() + CapacityStep;
            Array.Resize(ref elements, elements.Count() - 1 + CapacityStep);
            Capacity = newCapacity;
        }
        public void RemoveAt(int position)
        {
            if (position < 0 || position > currentElementIndex)
            {
                throw new ArgumentOutOfRangeException();
            }

            int rightValuesCount = currentElementIndex - position;
            if (rightValuesCount > 0)
            {
                Array.Copy(elements, position - 1, elements, position, rightValuesCount);
            }
            else
            {
                Clear();
            }

            currentElementIndex--;
        }

        public void Clear()
        {
            elements = new T[CapacityStep];
        }

        public int Count
        {
            get { return currentElementIndex; }
        }

        public T Min()
        {
            return elements.Min();
        }

        public T Max()
        {
            return elements.Max();
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("[");

            for (int i = 0; i < currentElementIndex; i++)
            {
                result.Append(elements[i]);

                if (i < currentElementIndex - 1)
                {
                    result.Append(" ");
                }
            }

            result.Append("]");

            return result.ToString();
        }
    }
}
