using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
            Console.ReadKey();
        }

        static void Run()
        {
            ClassBinarySearch binarySearch = new ClassBinarySearch();
            int[] search = { 1, 3, 5, 7, 10, 12, 14, 20, 21, 22, 23, 24, 56, 100, 166, 177 }; // sorted array

            Console.Write("Enter the number to search in the array: ");
            int item = Convert.ToInt32(Console.ReadLine());
            int result = binarySearch.AlgorithmBinarySearch(search, item, out int iter);
            if (result == -1)
                Console.WriteLine("Item not found!");
            else
                Console.WriteLine($"The element is in place: {result} in the array! Number of iterations {iter}.");
        }
    }
}
