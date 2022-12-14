using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.SinglyLinkedList
{

    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        public SinglyLinkedListNode<T> Head { get; set; }
        private bool isHeadNull => Head == null;
        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
              
        }
        public void AddLast(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
           
            if (isHeadNull)
            {
                Head = newNode;
                return;
            }
            var current = Head;
            while (current.Next!=null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void AddAfter(SinglyLinkedListNode<T> node,T value)
        {
            if (node==null)
            {
                throw new ArgumentNullException();
            }
            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }    

            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;
            while (current!=null)
            {
                if (current.Equals(node))
                {
                    newNode.Next=current.Next;
                    current.Next=newNode;
                    return;

                }
            }
            throw new ArgumentException("The referance node is not in this list.");
        }
   
       public   void AddAfter(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
               
         }
    }

}
