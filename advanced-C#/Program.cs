using advanced_C_.Generics;
using System.Drawing;

namespace advanced_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 3, 7, 1, 9, 12, 22, 19, 4 };

            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("\n");
            Helper<int>.BubbleSort( numbers );
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("\n");
            Pono[] points =
                {
                new Pono(5,8), 
                new Pono(10,9),
                new Pono(1,3),
                new Pono(1,7),
                new Pono(15,4),
                new Pono(2,7),
                new Pono(12,9)
                };
            foreach (Pono point in points)
            {
                Console.WriteLine(point.ToString());
            }
            Console.WriteLine("\n");

            Helper<Pono>.BubbleSort(points);
            foreach (Pono point in points)
            {
                Console.WriteLine(point.ToString());
            }
            Console.WriteLine("\n");

            int index = Helper<int>.SearchArray(numbers, 9);
            Console.WriteLine(index.ToString());    

        }
    }
}
