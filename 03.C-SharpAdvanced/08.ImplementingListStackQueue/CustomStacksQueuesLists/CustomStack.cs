using System;

namespace CustomStacksQueuesLists
{
    public class CustomStack
    {
        private int[] internalArray;
        private int initialCapacity;

        public CustomStack()
            : this(4)
        {

        }

        public CustomStack(int customInitialCapacity)
        {
            this.initialCapacity = customInitialCapacity;
            internalArray = new int[this.initialCapacity];
            this.Count = 0;
        }

        public int Count { get; private set; }

        public void Clear()
        {
            internalArray = new int[initialCapacity];
            Count = 0;
        }

        public void Push(int element)
        {
            if (this.IsResizeNeeded())
            {
                this.Resize();
            }

            this.internalArray[Count] = element;
            Count++;
        }

        public int Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty!");
            }

            int lastElement = this.internalArray[Count - 1];
            this.internalArray[Count - 1] = default(int);
            Count--;

            if (this.isShrinkNeeded())
            {
                this.Shrink();
            }

            return lastElement;
        }

        public int Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty!");
            }

            int peeked = this.internalArray[Count - 1];
            return peeked;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                action(this.internalArray[i]);
            }
        }
        private void Shrink()
        {
            int newCapacity = this.internalArray.Length / 2;
            int[] shrinked = new int[newCapacity];

            for (int i = 0; i < newCapacity; i++)
            {
                shrinked[i] = internalArray[i];
            }

            internalArray = shrinked;
        }
        private bool isShrinkNeeded()
        {
            return (this.internalArray.Length / 2) == this.Count ? true : false;
        }
        private bool IsResizeNeeded()
        {
            return this.Count == internalArray.Length ? true : false;
        }

        private void Resize()
        {
            int newCapacity = this.internalArray.Length * 2;
            int[] newData = new int[newCapacity];

            for (int i = 0; i < internalArray.Length; i++)
            {
                newData[i] = internalArray[i];
            }

            internalArray = newData;
        }
    }
}
