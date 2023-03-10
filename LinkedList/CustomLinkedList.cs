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
        public int count;
        public void AddLast(int data)
        {
            Node new_node = new Node(data);
            if (head == null)
            {
                head = new_node;
                count++;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
                count++;
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

        public void Insert(int data, int new_data)
        {
            Node temp = head;
            bool isFound=false;
            Node new_node = new Node(new_data);
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                while (temp!=null)
                {
                    if (temp.data==data)
                    {
                        new_node.next = temp.next;
                        temp.next = new_node;
                        Console.WriteLine("\n{0} is inserted", new_data);
                        isFound = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (isFound==false)
                    Console.WriteLine("{0} node is not present",data);
            }
        }

        public void RemoveFirst()
        {
            if (head == null)
                Console.WriteLine("LinkedList is empty");
            else
                Console.WriteLine("{0} is removed", head.data);
            head = head.next;
        }

        public void RemoveLast()
        {
            Node temp = head;
            if (temp == null)
                Console.WriteLine("LinkedList is empty");
            if (temp.next == null)
            {
                int data = temp.data;
                temp = null;
                head = temp;
                Console.WriteLine("{0} Node is deleted", data);
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }

            }
            int lastDeleteNode = temp.next.data;
            temp.next = null;
            Console.WriteLine("{0} node is deleted ",lastDeleteNode);
        }

        public void Search(int data)
        {
            bool isFound = false;
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Linked List is Empty");
            else
            {
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        Console.WriteLine("{0} node is present", temp.data);
                        isFound = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (isFound==false)
                    Console.WriteLine("{0} node is not present", data);
            }
        }

        public void Delete(int data)
        {
            bool isFound = false;
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Linked List is Empty");
            else
            {
                while (temp != null)
                {
                    if (temp.next.data == data)
                    {
                        Console.WriteLine("\n\n{0} node is found and deleted", temp.next.data);
                        temp.next = temp.next.next;
                        isFound = true;
                        count--;
                        break;
                    }
                    temp = temp.next;
                }
                if (isFound == false)
                    Console.WriteLine("{0} node is not present", data);
            }
        }
        public void SortLinkedList()
        {
            if (head == null)
                Console.WriteLine("LinkedList is Empty");
            else
            {
                int temp; 
                Node first = head;
                Node second;
                while (first.next != null)
                {
                    second = first.next;
                        if (first.data.CompareTo(second.data) > 0)
                        {
                            temp = first.data;
                            first.data = second.data;
                            second.data = temp;
                        }
                    first = first.next;
                }
            }
            Console.Write("\nAfter Sorting ");
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
                Console.WriteLine("LinkedList is Empty");
            else
            {
                Console.WriteLine("\nDisplaying LinkedList");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine("\nLength of linked list is " + count);
            }
        }
    }
}
