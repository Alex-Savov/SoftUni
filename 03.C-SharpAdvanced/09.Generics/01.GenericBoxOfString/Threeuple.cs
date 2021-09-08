
namespace _01.GenericBoxOfString
{
    public class Threeuple<T,V,U> : Tuple<T, V>
    {

        public Threeuple(T first, V second, U third)
        {
            FirstElement = first;
            SecondElement = second;
            ThirdItem = third;
        }
        public U ThirdItem { get; private set; }

        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement} -> {ThirdItem}";
        }

    }
}
