using System;
using System.Collections.Generic;

namespace reverse_linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedlist = new LinkedList<String>();
            linkedlist.AddLast("as");
            linkedlist.AddLast("as1");
            linkedlist.AddLast("as2");
            linkedlist.AddLast("as3");

            var x = linkedlist.Find("as");

            foreach (var item in linkedlist)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
