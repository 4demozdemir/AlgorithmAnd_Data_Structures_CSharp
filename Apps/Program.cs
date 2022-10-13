using System;
using System.Collections.Generic;
using DataStructures.LinkedList.SinglyLinkedList;
namespace Apps
{
    class Program
    {
            public static void Main(string[] args)
            {
        
                UsingLinkedList();

                var list = new LinkedList<int>();
                list.AddFirst(1);
                list.AddFirst(2);
                list.AddFirst(3);
                list.AddLast(4);

                foreach (int item in list)
                {
                    Console.WriteLine(item);
                }

            }

            private static void UsingLinkedList()
            {
                var linkedList = new SinglyLinkedList<int>();
                linkedList.AddFirst(1);
                linkedList.AddFirst(2);
                linkedList.AddFirst(5);

                linkedList.AddLast(4);
                linkedList.AddLast(6);
                linkedList.AddLast(7);

                linkedList.AddAfter(linkedList.Head.Next, 21);
            }





        }
    }

