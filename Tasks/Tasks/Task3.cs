using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task3<T> where T : IComparable<T>
    {
        public T[] filterArray(T[] arr, T minValue, T maxValue)
        {
            List<T> res = new List<T>();
            foreach (T i in arr)
                if (i.CompareTo(minValue) > 0 && i.CompareTo(maxValue) < 0)
                { 
                    res.Add(i);
                }
            return res.ToArray<T>();

          
          
        }
    }
}