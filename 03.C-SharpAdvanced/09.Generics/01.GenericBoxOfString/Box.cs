using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.GenericBoxOfString
{
    public class Box<T> where T : IComparable
    {
        private T item;
        private List<T> elements;

        public Box()
        {

        }
        public Box(T item)
        {
            this.item = item;
        }

        public Box(List<T> elements)
        {
            this.elements = elements;
        }

        public void Swap(List<T> elements, int firstIndex, int seconIndex)
        {
            T temp = elements[firstIndex];
            elements[firstIndex] = elements[seconIndex];
            elements[seconIndex] = temp;
        }
       
        public int CountCompare<V>(List<V> elements, V elementToCompare) where V : IComparable
        {
            return elements.Count(e => e.CompareTo(elementToCompare) > 0);
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            foreach (var element in elements)
            {
                output.AppendLine($"{element.GetType()}: {element}");
            }
            return output.ToString();
        }
    }
}
