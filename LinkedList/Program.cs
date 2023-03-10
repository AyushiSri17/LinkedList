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
            Console.WriteLine("1. AddLast \n2. AddFirst \n3. Append \n4. Instert new node in between \n5. Remove first node \n6. Remove Last node \n7. Search Node \n8. Insert Node \n9. Delete particular node \n10. Sorting Linked List");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.Clear();
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();//56 30 70
                    break;
                case 2:
                    Console.Clear();
                    linkedList.AddFirst(70);
                    linkedList.AddFirst(30);
                    linkedList.AddFirst(56);
                    linkedList.Display();//56 30 70
                    break;
                case 3:
                    Console.Clear();
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(70);
                    linkedList.Display();//56 30 70
                    break;
                case 4:
                    Console.Clear();
                    linkedList.AddLast(56);
                    linkedList.AddLast(70);
                    linkedList.Insert(56, 30);
                    linkedList.Display();//56 30 70
                    break;
                case 5:
                    Console.Clear();
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.RemoveFirst();
                    linkedList.Display();//30 70
                    break;
                case 6:
                    Console.Clear();
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.RemoveLast();
                    linkedList.Display();//56 30
                    break;
                case 7:
                    Console.Clear();
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Search(70);
                    break;
                case 8:
                    Console.Clear();
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    linkedList.Insert(30, 40);
                    linkedList.Display();//56 30 40 70
                    break;
                case 9:
                    Console.Clear();
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(40);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    linkedList.Delete(40);
                    linkedList.Display();
                    break;
                case 10:
                    Console.Clear();
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(40);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    linkedList.SortLinkedList();
                    linkedList.Display();
                    break;
                default:
                    Console.WriteLine("Please Choose the correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
