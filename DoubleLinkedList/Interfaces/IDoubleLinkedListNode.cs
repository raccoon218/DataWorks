using DoubleLinkedList.Models;

namespace DoubleLinkedList.Interfaces
{
    interface IDoubleLinkedListNode<T>
    {
        public T Value { get; set; }
        public DoubleLinkedNode<T> Next { get; set; }
        public DoubleLinkedNode<T> Prev { get; set; }
    }
}
