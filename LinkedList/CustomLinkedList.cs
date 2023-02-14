using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CustomLinkedList
    {
        public Node head;
        public void AddLast(int data)
        {
            Node new_node = new Node(data);
            if (head == null)
            {
                head = new_node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            Console.WriteLine("{0} is added", new_node.data);
        }

        public void AddFirst(int data)
        {

            Node new_node = new Node(data);
            new_node.next = head;
            head = new_node;
            Console.WriteLine("{0} is inserted into LikedList", new_node.data);
        }

        public void Append(int data)
        {
            AddLast(data);
        }

        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            else
            {
                Console.WriteLine("\nDisplaying LinkedList");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
