using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Sorting<T>:IComparable<T>
    {
        public static void BubbleSort(T[] array)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int modified = 0;
                    for (int k = 0; k < array.Length - i - 1; k++)
                    {
                        //if (array[k].CompareTo(array[k + 1]) == 1)
                        //{
                        //    Swap(ref array[k], ref array[k + 1]);
                        //    modified = 1;
                        //}
                    }
                    if (modified == 0)
                        break;
                }
            }
        }
        public static void Swap(ref T X, ref T Y)
        {
            T temp = X;
            X = Y;
            Y = temp;
        }

        public int CompareTo(T? other)
        {
            throw new NotImplementedException();
        }
    }
}

