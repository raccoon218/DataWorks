using DoubleLinkedList.Interfaces;

namespace DoubleLinkedList.Models
{
    public class DoubleLinkedNode<T> : IDoubleLinkedListNode<T>
    {
        public DoubleLinkedNode(T t) => Value = t;
        public T Value { get; set; }
        public DoubleLinkedNode<T> Next { get; set; }
        public DoubleLinkedNode<T> Prev { get; set; }
    }
}
