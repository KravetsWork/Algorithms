using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
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
            ClassSelectionSort sort = new ClassSelectionSort();
            int[] unsortedAraay = { -1, 2, 3, -10, 40, 80, 9, 0 };
            int[] sortedArray = sort.SortSelection(unsortedAraay);
            int index = 0;
            Console.WriteLine("Sorted array: ");
            foreach (int item in sortedArray)
                Console.WriteLine($"{index++}| {item}");
        }
    }
}