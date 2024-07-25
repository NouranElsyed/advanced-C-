using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class range<T> where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }
        public range(T min, T max)
        {
            Min = min;
            Max = max;
        }
     
        public bool IsInRange(T num)
        {
            
            for (int i =0 ; i.CompareTo(Max) !=  1 || i.Equals(Max); i++)
                if ((Max.CompareTo(num) == 1 || Max.Equals(num) )&& (num.CompareTo(Min) == 1 || Min.Equals(num))) return true;
            return false;
            //for (T i = Min; i.CompareTo(Max) == 1 || i.Equals(Max); i++)
            //    if (i.CompareTo(num) == 1) return true;
            //return false;
        }
        public int Length()
        {
            int length = 0;
            for (int i = 0; i.CompareTo(Max) != 1 || i.Equals(Max); i++)
            {
                if (i.CompareTo(Min) == 1 || Min.Equals(i))
                {
                    length++;
                }
            }
            return length;
        }
       


    }

}
