using System;
using DoubleLinkedList.Models;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DLList<string> dlist = new();
            dlist.AddFirst("A");
            dlist.AddLast("B");
            dlist.AddLast("C");
            dlist.AddLast("D");
            dlist.AddLast("E");
            foreach (var d in dlist) { Console.WriteLine(d); }
            Console.WriteLine("--------------AND NOW SHOW REVERSE LIST---------------");
            dlist.Reverse();
            foreach (var d in dlist) { Console.WriteLine(d); }
            //Console.WriteLine(dlist.Count);
        }
    }
}
