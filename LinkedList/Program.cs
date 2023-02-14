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
            Console.WriteLine("Choose the option to perform the action");
            CustomLinkedList linkedList = new CustomLinkedList();
            Console.WriteLine("1. AddLast \n2. AddFirst");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:                    
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();//56 30 70
                    break;
                case 2:                    
                    linkedList.AddFirst(70);
                    linkedList.AddFirst(30);
                    linkedList.AddFirst(56);
                    linkedList.Display();//56 30 70
                    break;
                default:
                    Console.WriteLine("Please Choose the correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
