using System;

namespace BinarySearch
{
    /// <summary>
    /// Class that uses a binary search algorithm
    /// </summary>
    public class ClassBinarySearch
    {
        public void Run()
        {
            int[] search = { 1, 3, 5, 7, 10, 12, 14, 20, 21, 22, 23, 24, 56, 100, 166, 177 }; // sorted array

            Console.Write("Enter the number to search in the array: ");
            int item = Convert.ToInt32(Console.ReadLine());
            int result = AlgorithmBinarySearch(search, item, out int iter);
            if (result == -1)
                Console.WriteLine("Item not found!");
            else
                Console.WriteLine($"The element is in place: {result} in the array! Number of iterations {iter}.");

            Console.ReadKey();
        }

        private int AlgorithmBinarySearch(int[] arr, int item, out int iter)
        {
            iter = 1;
            int low = 0, high = arr.Length - 1, mid, guess;
            while (low <= high)
            {
                mid = (low + high) / 2;
                guess = arr[mid];
                if (guess == item)
                    return mid;
                else if (guess > item)
                    high = mid - 1;
                else
                    low = mid + 1;
                iter++;
            }
            return -1;
        }
    }
}
