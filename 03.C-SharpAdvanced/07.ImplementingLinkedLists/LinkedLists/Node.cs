

namespace LinkedLists
{
    public class Node
    {
        public Node(int value, Node next, Node previous)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
    }
}
