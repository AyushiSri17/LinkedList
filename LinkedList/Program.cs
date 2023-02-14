using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Programs");

            Console.WriteLine("Welcome To Linked List");
            CustomLinkedList linkedlist = new CustomLinkedList();
            linkedlist.AddLast(56);
            linkedlist.AddLast(30);
            linkedlist.AddLast(70);
            linkedlist.Display();//56 30 70

            Console.ReadLine();
        }
    }
}
