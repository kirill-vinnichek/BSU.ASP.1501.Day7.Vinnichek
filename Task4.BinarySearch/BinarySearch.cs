using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.BinarySearch
{
    public static class BinarySearch
    {

        public static int Search<T>(this T[] array, T value,Comparison<T> compare)
        {
            return Search(array, value, 0, (uint)array.Length , compare);
        }

        public static int Search<T>(this T[] array, T value, IComparer<T> comparator)
        {
            return Search(array, value, 0, (uint)array.Length , comparator.Compare);
        }

        public static int Search<T>(this T[] array, T value)
        {
            return Search(array, value, 0, (uint)array.Length ,Comparer<T>.Default.Compare);
        }



        private static int Search<T>(T[] array, T value, uint left, uint rigth, Comparison<T> compare)
        {

            if (array == null)
                throw new ArgumentNullException("Array is null");
            if (array.Length == 0)
                return -1;
            if (value == null)
                throw new ArgumentNullException("Array is null");
            while (!(left >= rigth))
            {
                var mid = ((uint)left + (uint)rigth) >> 1;
                T midVal = array[mid];
                if (compare(array[left], value) == 0)
                    return (int)left;
                int result = compare(midVal, value);

                if (result == 0)
                {
                    if (mid == left + 1)
                        return (int)mid;
                    else
                        rigth = mid + 1;
                }

                else if (result > 0)
                    rigth = mid;
                else
                    left = mid + 1;

            }
            return (int)-(1+left) ;
        }

    }
}
