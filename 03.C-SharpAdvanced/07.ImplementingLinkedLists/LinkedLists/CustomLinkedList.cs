using System;


namespace LinkedLists
{
    public class CustomLinkedList
    {
        private Node head;
        private Node tail;
        public int Count { get; private set; }

        public void AddFirst(int value)
        {
            if (Count == 0)
            {
                head = tail = new Node(value, null, null);
            }
            else
            {
                Node newNode = new Node(value, head, null);
                head.Previous = newNode;
                head = newNode;
            }

            Count++;
        }

        public void AddLast(int value)
        {
            if (Count == 0)
            {
                head = tail = new Node(value, null, null);
            }
            else
            {
                Node newNode = new Node(value, null, tail);
                tail.Next = newNode;
                tail = newNode;
            }

            Count++;
        }

        public int RemoveFirst()
        {
            if (Count == 0)
            {
                throw new ArgumentException("List is empty!");
            }

            int value = head.Value;
            head = head.Next;
            if (head.Next != null)
            {
                head.Previous = null;
            }
            else
            {
                tail = null;
            }

            Count--;
            return value;
        }

        public int RemoveLast()
        {
            if (Count == 0)
            {
                throw new ArgumentException("List is empty!");
            }

            int value = tail.Value;
            tail = tail.Previous;
            if (tail.Previous != null)
            {
                tail.Next = null;
            }
            else
            {
                head = null;
            }

            Count--;
            return value;
        }

        public void ForEach(Action<int> action)
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];

            int counter = 0;
            Node currentNode = head;
            while (currentNode != null)
            {
                array[counter] = currentNode.Value;
                currentNode = currentNode.Next;
                counter++;
            }
            return array;
        }
    }
}
