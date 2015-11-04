using System;
using NUnit.Framework;
using Task3.Queue;
namespace Task3.Test
{
    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var queue = new CustomQueue<int>();
            int[] ar = {1,2,3,4,5};
            foreach (var e in ar)
            {
                queue.Enqueue(e);
            }
            Assert.AreEqual(1, queue.Peek());

        }
    }
}