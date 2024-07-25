using System;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1.The Bubble Sort algorithm has a time complexity of O(n ^ 2) in its worst and average cases,
            //  which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm
            //  And implement the code of this optimized bubble sort algorithm.
            //=============================================
            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //Sorting<int>.BubbleSort(numbers);
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Q2
            //2.create a generic Range < T > class that represents a range of values from a minimum value to a maximum value.
            //      The range should support basic operations such as checking if a value is within the range 
            //      and determining the length of the range.
            //Requirements:
            //  1.	Create a generic class named Range<T> where T represents the type of values.
            //  2.	Implement a constructor that takes the minimum and maximum values to define the range.
            //  3.	Implement a method IsInRange(T value) that returns true 
            //    if the given  value is within the range, otherwise false.
            //  4.	Implement a method Length() that returns the length of the range 
            //    (the difference between the maximum and minimum values).
            //  5.	Note: You can assume that the type T used in the Range<T> class implements 
            //    the IComparable<T> interface to allow for comparisons.
            Console.Write("Enter the min number: ");
             int.TryParse(Console.ReadLine(), out int min);
            Console.Write("Enter the max number: ");
            int.TryParse(Console.ReadLine(), out int max);
            range<int> range = new range<int>(min, max);

            int l = range.Length();
            Console.WriteLine($"Length of the range: {l}");

            Console.Write("Enter a number to check if it's in the range or not: ");
            int.TryParse(Console.ReadLine(), out int num);
           bool   result = range.IsInRange(num);
            if (result) 
                Console.WriteLine("it's in");
           else Console.WriteLine("it is not in");
            #endregion

        }
}
}
