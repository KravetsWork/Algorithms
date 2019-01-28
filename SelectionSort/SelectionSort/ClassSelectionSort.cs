namespace SelectionSort
{
    /// <summary>
    /// Class that uses a selection sort algorithm
    /// </summary>
    class ClassSelectionSort
    {
        public int[] SortSelection(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minimalElement = array[i];
                int minimumElementIndex = i;
                for (int y = i + 1; y < array.Length; y++)
                {
                    if (minimalElement > array[y]) // swap elements
                    {
                        minimalElement = array[y];
                        minimumElementIndex = y;
                        int temp = array[i];
                        array[i] = array[minimumElementIndex];
                        array[minimumElementIndex] = temp;
                    }
                }
            }
            return array;
        }
    }
}
