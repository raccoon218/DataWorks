using System;
using DoubleLinkedList.Models;

namespace DoubleLinkedList
{
    class Program
    {
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
