using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Queue
{
    internal sealed class Node<T>
    {
        public Node<T> next;
        public T value;
        public Node(T value)
        {
            this.value = value;
        }
    }

    public sealed class CustomQueue<T>:IEnumerable<T>
    {

        private Node<T> head;
        private Node<T> tail;
        public CustomQueue()
        {
            head = tail = null;
        }

        public void Enqueue(T value)
        {
            var n = new Node<T>(value);
            if (head == null)
            {
                head = n;
                tail = head;
            }
            else
            {
                tail.next = n;
                tail = n;
            }
        }
        public T Dequeue()
        {
            if (head == null)
                throw new InvalidOperationException("Queue is empty");
            else
            {
                var n = head;
                head = head.next;
                if (head == null)
                    tail = null;
                return n.value;
            }
        }

        public T Peek()
        {
            if (head == null)
                throw new InvalidOperationException("Queue is empty");
            else return head.value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CustomQueueEnumerator<T>(head);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
