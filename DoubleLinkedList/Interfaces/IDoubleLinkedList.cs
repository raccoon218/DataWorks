using DoubleLinkedList.Models;

namespace DoubleLinkedList.Interfaces
{
    interface IDoubleLinkedList<T>
    {
        public DoubleLinkedNode<T> Next { get; set; }
        public DoubleLinkedNode<T> Prev { get; set; }
        void Reverse();
        void AddFirst(T t);
        void AddLast(T t);
    }
}
