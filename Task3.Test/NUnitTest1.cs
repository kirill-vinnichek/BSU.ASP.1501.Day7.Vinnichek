using System;
using NUnit.Framework;
using Task3.Queue;
namespace Task3.Test
{
    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        public void TestQueue()
        {
            var queue = new CustomQueue<int>();
            int[] ar = {1,2,3,4,5};
            foreach (var e in ar)
            {
                queue.Enqueue(e);
            }
            Assert.AreEqual(1, queue.Peek());
            int i = 0;
            foreach(var e in queue)
            {
                Assert.AreEqual(e, ar[i++]);
            }
            for(i=0;i<ar.Length;i++)
            {
                Assert.AreEqual(queue.Dequeue(), ar[i]);
            }
        }
        [Test, ExpectedException("System.InvalidOperationException")]
        public void TestMethod1()
        {
            var queue = new CustomQueue<int>();
            queue.Enqueue(1);
            Assert.AreEqual(queue.Dequeue(), 1);
            queue.Dequeue();
            queue.Enqueue(1);
            Assert.AreEqual(queue.Dequeue(),1);
            queue.Dequeue();
           
        }
    }
}