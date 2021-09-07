using System;

namespace CustomStacksQueuesLists
{
    public class CustomList
    {
        private int[] data;
        private int initialCapacity = 4;

        public CustomList()
            : this(4)
        {

        }
        public CustomList(int customInitialCapacity)
        {
            this.initialCapacity = customInitialCapacity;
            this.data = new int[initialCapacity];
            Count = 0;
        }


        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < this.Count)
                {
                    return data[index];
                }

                throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < this.Count)
                {
                    data[index] = value;
                }

                throw new ArgumentOutOfRangeException();
            }
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (!(isIndexValid(firstIndex) && isIndexValid(secondIndex)))
            {
                throw new IndexOutOfRangeException();
            }

            int temp = this.data[firstIndex];
            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = temp;
        }
        public void Add(int element)
        {
            if (this.IsResizeNeeded())
            {
                this.Resize();
            }

            data[Count] = element;
            Count++;
        }
        public int RemoveAt(int index)
        {
            if (!isIndexValid(index))
            {
                throw new IndexOutOfRangeException();
            }

            int removedElement = data[index];

            this.ShiftLeft(index);
            this.data[this.Count - 1] = 0;

            this.Count--;

            if (this.isShrinkNeeded())
            {
                this.Shrink();
            }
            return removedElement;
        }
        public void InsertAt(int index, int element)
        {
            if (!isIndexValid(index))
            {
                throw new IndexOutOfRangeException();
            }

            if (this.IsResizeNeeded())
            {
                this.Resize();
            }

            this.ShftRight(index);
            this.data[index] = element;
            Count++;
        }
        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.data[i] == element)
                {
                    return true;
                }
            }

            return false;
        }

        public void Clear()
        {
            this.data = new int[initialCapacity];
            Count = 0;
        }

        private bool isIndexValid(int index)
        {
            if (index >= 0 && index < this.Count)
            {
                return true;
            }

            return false;
        }
        private void ShftRight(int endIndex)
        {
            for (int i = this.Count; i > endIndex; i--)
            {
                this.data[i] = this.data[i - 1];
            }
        }
        private void Shrink()
        {
            int newCapacity = data.Length / 2;
            int[] shrinked = new int[newCapacity];

            for (int i = 0; i < newCapacity; i++)
            {
                shrinked[i] = data[i];
            }

            data = shrinked;
        }
        private bool isShrinkNeeded()
        {
            return (this.data.Length / 2) == this.Count ? true : false;
        }
        private void ShiftLeft(int startIndex)
        {
            for (int i = startIndex; i < this.Count - 1; i++)
            {
                data[i] = data[i + 1];
            }
        }
        private bool IsResizeNeeded()
        {
            return this.Count == this.data.Length ? true : false;
        }
        private void Resize()
        {
            int newCapacity = this.data.Length * 2;
            int[] newData = new int[newCapacity];

            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i];
            }

            data = newData;
        }


    }
}
