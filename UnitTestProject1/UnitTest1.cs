using System;
using NUnit.Framework;
using Task4.BinarySearch;
using System.Collections.Generic;
namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        public class ComparableComparer<T> : IComparer<T> where T : IComparable
        {
            public int Compare(T x, T y)
            {
                return x.CompareTo(y);
            }
        }

        [TestFixture]
        public class BinarySearchTest
        {
            //Спасибо Вадиму за тесты(с меня кофе)
            private IEnumerable<TestCaseData> TestDatas
            {
                get
                {
                    yield return new TestCaseData(new[] { 15 }, 15, 0);
                    yield return new TestCaseData(new[] { 15 }, 12, -1);

                    yield return new TestCaseData(new[] { 12, 15 }, 12, 0);
                    yield return new TestCaseData(new[] { 12, 15 }, 1, -1);
                    yield return new TestCaseData(new[] { 12, 15 }, 15, 1);

                    yield return new TestCaseData(new[] { -58, -35, -28, -15, -1, 0, 2, 8, 12, 27, 35, 49, 59, 87, 98 }, 0, 5);
                    yield return new TestCaseData(new[] { -58, -35, -28, -15, -1, 0, 2, 8, 12, 27, 35, 49, 59, 87, 98 }, 1, -7);
                    yield return new TestCaseData(new[] { -58, -35, -28, -15, -1, 0, 2, 8, 12, 27, 35, 49, 59, 87, 98 }, 98, 14);
                    yield return new TestCaseData(new[] { -58, -35, -28, -15, -1, 0, 2, 8, 12, 27, 35, 49, 59, 87, 98 }, -58, 0);

                    yield return new TestCaseData(new[] { -58, -1, 0, 0, 0, 2, 98 }, 0, 2);
                    yield return new TestCaseData(new[] { -58, -1, 0, 0, 0, 2, 98 }, -100, -1);
                    yield return new TestCaseData(new[] { 0, 0, 0, 0, 0 }, 0, 0);
                    yield return new TestCaseData(new[] { -1, 0, 0, 1 }, 0, 1);
                    yield return new TestCaseData(new[] { -1, 0, 0, 0, 1 }, 0, 1);


                }
            }
            [Test, TestCaseSource("TestDatas")]
            public void BinarySearch_Delegate_Test<T>(T[] array, T value, int result)
            {
                Assert.AreEqual(array.Search(value, (a, b) => ((IComparable)a).CompareTo(b)), result);
            }

            [Test, TestCaseSource("TestDatas")]
            public void BinarySearch_IComparer_Test<T>(T[] array, T value, int result) where T : IComparable
            {
                Assert.AreEqual(array.Search(value, new ComparableComparer<T>()), result);
            }
            [Test]
            public void TestBinarySearch()
            {
                int[] ar = { -58, -1, 0, 0, 0, 2, 98 };
                int[] q = { };
                Assert.AreEqual(ar.Search(0), 2);
                Assert.AreEqual(ar.Search(9, (a, b) => a - b), -7);
                Assert.AreEqual(q.Search(19), -1);
            }
        }
    }
}
