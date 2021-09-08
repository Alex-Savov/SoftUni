using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> elements;
        public int Count { get; private set; }

        public Box()
        {
            elements = new List<T>();
            Count = 0;
        }

        public void Add(T element)
        {
            elements.Add(element);
            Count++;
        }

        public T Remove()
        {
            T lastElement = this.elements.LastOrDefault();
            elements.Remove(lastElement);
            Count--;
            return lastElement;
        }
    }
}
