using System;
using System.Collections.Generic;
using System.Text;

namespace _01.GenericBoxOfString
{
    public class Tuple<T, V>
    {
        public Tuple()
        {

        }
        public Tuple(T first, V second)
        {
            FirstElement = first;
            SecondElement = second;
        }
        public T FirstElement { get;  set; }
        public V SecondElement { get;  set; }

        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement}";
        }
    }
}
