using System.Collections;
using System.Collections.Generic;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public class SinglyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private SinglyLinkedListNode<T> head;
        private SinglyLinkedListNode<T> _current;

        public SinglyLinkedListEnumerator(SinglyLinkedListNode<T> head)
        {
            this.head = head;
            this._current = null;
        }

        public T Current => throw new System.NotImplementedException();

        object IEnumerator.Current => throw new System.NotImplementedException();

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
}