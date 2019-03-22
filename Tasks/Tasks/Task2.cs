using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    class Task2<T> where T : IComparable<T>
    {
        public T findMax(T[] arr)
        {
            T max = arr[0];

            foreach (T i in arr)
                if (max.CompareTo(i) < 0)
                    max = i;
            return max;
        }
        public T findMin(T[] arr)
        {
            T min = arr[0];
            foreach (T i in arr)
                if (min.CompareTo(i) > 0)
                    min = i;
            return min;
        }
    }
}
