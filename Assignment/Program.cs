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
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            Sorting<int>.BubbleSort(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            #endregion
        }
    }
}
