using System;
using System.Collections;
using System.Collections.Generic;


namespace IteratorsAndComparators
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly List<T> elements;
        private int currentIndex;

        public ListyIterator(params T[] elements)
        {
            this.elements = new List<T>(elements);
            currentIndex = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Move()
        {
            return ++currentIndex < elements.Count;
        }

        public bool HasNext()
        {
            return currentIndex < elements.Count - 1;
        }

        public void Print()
        {
            ValidataCollection();
            Console.WriteLine(elements[currentIndex]);
        }

       public void PrintAll()
        {
            ValidataCollection();
            Console.WriteLine(string.Join(' ', elements));
        }

        private void ValidataCollection()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }
    }
}
