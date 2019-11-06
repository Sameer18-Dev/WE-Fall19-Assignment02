using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {

                                    /*   Assignment#02   */

            Console.WriteLine("The Link-List is  : ");

            LinkedList myList2 = new LinkedList();

            myList2.Add(1);
            myList2.Add(45);
            myList2.Add(89);
            myList2.Add(36);
            myList2.Add(21);
            myList2.Add(45);
            myList2.Add(70);
            myList2.Add(90);
            myList2.Add(10);
            myList2.Add(99);

            myList2.printAllNodes();

            Console.WriteLine();

            Console.ReadLine();

        }
    }


    public class Node
    {
        public Node next;
        public Object data;
    }



    public class LinkedList
    {
        private Node head;

        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
        }



        public void Add(Object data)
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;
                Node current = head;

                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }
    }
 }
