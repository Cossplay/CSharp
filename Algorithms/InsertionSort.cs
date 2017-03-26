using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class InsertionSort
    {
        static int[] array = { 2, -5, 16, 8, -10, 3, 250 };
        public static void Main(string[] args)
        {
            // before sort
            printArray();

            Sort();

            //after sort
            printArray();

            Console.ReadKey();
        }
        public static void Sort()
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j] < array[j - 1])
                {
                    swap(j, j - 1);
                    j--;
                }
            }
        }
        public static void swap(int lIndex, int rIndex)
        {
            int temp = array[lIndex];
            array[lIndex] = array[rIndex];
            array[rIndex] = temp;
        }
        public static void printArray()
        {
            foreach (int elem in array)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }
    }
}
