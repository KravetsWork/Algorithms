using System;

namespace BinarySearch
{
    /// <summary>
    /// Class that uses a binary search algorithm
    /// </summary>
    public class ClassBinarySearch
    {
        public int AlgorithmBinarySearch(int[] arr, int item, out int iter)
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
