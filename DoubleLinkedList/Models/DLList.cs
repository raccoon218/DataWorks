using DoubleLinkedList.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace DoubleLinkedList.Models
{
    public class DLList<T> : IDoubleLinkedList<T>, IEnumerable
    {
        private DoubleLinkedNode<T> head;

        private DoubleLinkedNode<T> tail;

        public DoubleLinkedNode<T> Next { get; set; }
        
        public DoubleLinkedNode<T> Prev { get; set; }

        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            DoubleLinkedNode<T> node = new DoubleLinkedNode<T>(value);
            DoubleLinkedNode<T> temp = head;
            head = node;
            head.Next = temp;
            if (Count == 0)
            {
                tail = head;
            }
            else
            {
                temp.Prev = head;
            }
            Count++;
        }

        public void AddLast(T value)
        {
            DoubleLinkedNode<T> node = new DoubleLinkedNode<T>(value);

            if (Count == 0)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                node.Prev = tail;
            }
            tail = node;
            Count++;
        }

        public IEnumerator GetEnumerator()
        {
            DoubleLinkedNode<T> current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public void Reverse()
        {
            Prev = null;
            DoubleLinkedNode<T> current = head;
            Next = null;
            while (current != null)
            {
                Next = current.Next;
                current.Next = Prev;
                Prev = current;
                current = Next;
            }
            head = Prev;
        }
    }
}
