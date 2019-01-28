using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.ReadKey();
        }

        static void Test()
        {
            QuickSort quickSort = new QuickSort();
            int[] numbers = new int[] { 1, 2, 19, -4, -1, 0, 81, -102 };
            Console.WriteLine("Unsorted array: ");
            foreach (var number in numbers)
                Console.Write($"{number}\t");

            var sortNumbers = quickSort.algorithmQuickSort(numbers, 0, numbers.Length - 1);
            Console.WriteLine("\nSorted array: ");
            foreach (var sortNum in sortNumbers)
                Console.Write($"{sortNum}\t");
        }
    }
}
