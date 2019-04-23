using System;
using System.Collections.Generic;
//TODO: System.Collections.Generic;
// where T : IComparable

namespace list
{
    public class List<T> : IList<T> where T : IComparable
    {
        private Node _head;
        private class Node
        {
            public readonly T Value;
            public Node Next;
        
            public Node(T value)
            {
                this.Value = value;
            }
        }
        
        public void AddElement(T value) => AddElement(_head, value);
        public bool FindValue(T value) => FindValue(_head, value);
        public void DeleteValue(T value) => DeleteValue(_head, value);
        public T GetValue() => GetValue(_head);

        public List(T value)
        {
            
        }
        
        private void AddElement(Node previous, T value)
                {
                    previous.Next = new Node(value);
                }

        private bool FindValue(Node first, T value)
        {
            if (first.Value.Equals(value)) // first.Value == value)
            {
                return true;
            }

            if (first.Next == null)
            {
                return false;
            }

            return FindValue(first.Next, value);
        }

        private void DeleteValue(Node root, T value)
        {
            if (FindValue(root, value) == false)
            {
                throw new ArgumentException("No such value in this list");
            }

            if (root.Next.Value.Equals(value))
            {
                root.Next = root.Next.Next;
            }
            else
            {
                DeleteValue(root.Next, value);
            }
        }

        private T GetValue(Node root)
        {
            return root.Value;
        }

        private Node GetNext(Node root)
        {
            return root.Next;
        }
    }
}