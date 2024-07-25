using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced_C_
{
    internal class Helper<T> where T : IComparable<T>
    {

    
    
        public static void BubbleSort(T[] array) 
        {
            if (array is not null) 
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int k = 0; k < array.Length - i - 1; k++)
                    {
                        if (array[k].CompareTo(array[k+1])==1) 
                        {
                            Swap(ref array[k], ref array[k+1]);
                        }
                    }
                }
            }
        }
        public static int SearchArray(T[] array ,T value) 
        {
            if (array is not null) 
            {
                for (int i = 0; i < array.Length; i++) 
                {
                if(value.Equals( array[i]))
                        return i;
                }
           
            }
            return -1;
        }
        public static void Swap(ref T X , ref T Y)
        {
        T temp = X;
            X = Y;
            Y = temp;
        }
    }
}
