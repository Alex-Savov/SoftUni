using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private readonly List<T> elements;

        public CustomStack()
        {
            elements = new List<T>();
        }

        public void Push(params T[] elements)
        {
            if (elements.Length == 1)
            {
                this.elements.Add(elements[0]);
            }
            else
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    this.elements.Add(elements[i]);
                }
            }
        }

        public T Pop()
        {
            try
            {
                T lastElement = elements.Last();
                elements.Remove(elements.Last());
                return lastElement;
            }
            catch (Exception)
            {
                throw new Exception("No elements");
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = elements.Count - 1; i >= 0; i--)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}
