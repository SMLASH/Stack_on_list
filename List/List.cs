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
        
        public void AddElementToEnd(T value) => AddElementToEnd(_head, value);
        public bool FindValue(T value) => FindValue(_head, value);
        public void DeleteValue(T value) => DeleteValue(_head, value);
        public T GetValue() => GetValue(_head);

        private void AddElement(T value)
        {
            var NewNode = new Node(value);
            NewNode.Next = _head;
            _head = NewNode;
        }
        
        private void AddElementToEnd(Node root, T value)
                {
                    if (root.Equals(null))
                    {
                        return;
                    }
                    if (root.Next.Equals(null))
                    {
                        root.Next = new Node(value);
                        return;
                    }
                    AddElementToEnd(root.Next, value);
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