using System;

namespace Algorithms
{
    public class BinarySearch
    {
        static int[] array = { 2, 9, 11, 15, 28, 33, 40, 47, 51, 64, 76, 77, 82, 85, 94 };
        public static void Main(string[] args)
        {
            int searchKey = 76;

            int? index = find(array, searchKey);

            if (index != null)
                Console.WriteLine($"SearchKey {searchKey} is found. Index of array is {index}");
            else
                Console.WriteLine($"SearchKey {searchKey} is not found.");
            Console.ReadKey();
        }
        public static int? find(int[] _array, int searchKey)
        {
            int size = _array.Length;
            int first = 0;
            int last = size - 1;
            int middle;

            while (true)
            {
                middle = (first + last) / 2;
                if (_array[middle] == searchKey)
                    return middle; // searchKey is found
                else if (first > last)
                    return null; // array isnt contain searchKey
                else // Dividing
                {
                    if (_array[middle] < searchKey)
                        first = middle + 1; // right half
                    else
                        last = middle - 1; // left half
                }
            }
        }
    }
}

