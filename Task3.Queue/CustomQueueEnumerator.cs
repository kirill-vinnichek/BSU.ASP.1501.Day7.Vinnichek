using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Queue
{
    public class CustomQueueEnumerator<T> : IEnumerator<T>
    {
        private Node<T> head;
        private Node<T> current;
        public CustomQueueEnumerator(Node<T> head)
        {
            this.head = head;
        }


        public T Current
        {
            get { return current.value; }
        }

        public void Dispose()
        {
            
        }

        object System.Collections.IEnumerator.Current
        {
            get { return current.value; }
        }

        public bool MoveNext()
        {
            current = current.next;
            if (current == null)
                return false;
            return true;

        }

        public void Reset()
        {
            current = new Node<T>(default(T));
            current.next = head;
        }
    }
}
