using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class BubbleSort
    {
        static int[] array = { 5, 0, -110, 25, 14, 81, 2, -15 };
        public static void Main(string[] args)
        {
            //Before sort
            printArray();
            sort();
            //After sort
            printArray();

            Console.ReadKey();
        }
      
        public static void sort()
        {
            for(int i = array.Length - 1; i > 0; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        swap(j, j + 1);
                    }
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
            foreach(int elem in array)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }
    }
}
