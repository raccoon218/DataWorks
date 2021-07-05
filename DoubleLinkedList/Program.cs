using System;
using DoubleLinkedList.Models;

namespace DoubleLinkedList
{
    class Program
    {
        /*
         Реализовать двусвязный список и написать функцию, переворачивающую его, т.е. изменяющую порядок элементов на обратный.
         public interface DoubleLinkedListNode<T>
         {
         T Value { get; set; }
         DoubleLinkedNode<T> Next { get; set; }
         DoubleLinkedNode<T> Prev { get; set; }
         }

         public interface DoubleLinkedList<T>
         {
         DoubleLinkedNode<T> First { get; set; }
         DoubleLinkedNode<T> Last { get; set; }
         void Reverse();
         //insert new DoubleLinkedListNode with given value at the start of the list
         void AddFirst(T value);
         //insert new DoubleLinkedListNode with given value at the end of the list
         void AddLast(T value);
         }
         */
        static void Main(string[] args)
        {
            DLList<int> dlist = new();
            dlist.AddFirst(1);
            dlist.AddLast(2);
            dlist.AddLast(3);
            dlist.AddLast(4);
            dlist.AddLast(5);
            foreach (var d in dlist) { Console.WriteLine(d); }
            Console.WriteLine("--------------AND NOW SHOW REVERSE LIST---------------");
            dlist.Reverse();
            foreach (var d in dlist) { Console.WriteLine(d); }
            //Console.WriteLine(dlist.Count);
        }
    }
}
