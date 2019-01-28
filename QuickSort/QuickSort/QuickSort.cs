namespace QuickSort
{
    /// <summary>
    /// Class that uses a quick sort algorithm
    /// </summary>
    public class QuickSort
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="left">Bottom element</param>
        /// <param name="right">Top element</param>
        /// <returns></returns>
        public int[] algorithmQuickSort(int[] arr, int left, int right)
        {
            int temp;
            int pivot = arr[left + (right - left) / 2]; // middle element
            int i = left; 
            int j = right; 

            while (i <= j) // main sorting pass
            {
                while (arr[i] < pivot) i++; // left elements < than average
                while (arr[j] > pivot) j--; // right elements > than average
                if (i <= j) // swap items (for example {1, 2, 3, 10, 6(middle element), 7, 8, 3}) swap 10 and 3
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            // recursively
            if (i < right) // sorting the right side
                algorithmQuickSort(arr, i, right);
            if (left < j) // sorting the left side
                algorithmQuickSort(arr, left, j);
            return arr;
        }
    }
}
