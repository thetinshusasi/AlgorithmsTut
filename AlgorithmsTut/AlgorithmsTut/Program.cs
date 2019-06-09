using AlgorithmsTut.SearchingAlgos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search");
            Console.WriteLine("search for 7 number");
            CallBinaryRecursiveSearch(7);
            Console.WriteLine("search for 10 number");
            CallBinaryRecursiveSearch(10);
            Console.WriteLine($"/////////////////////////////////////////////////////////");
            Console.ReadKey();

        }

        public static void CallBinaryRecursiveSearch(int val)
        {
            Console.WriteLine("CallBinaryRecursiveSearch");
            int[] inputArray = new int[]
            {
                1,2,3,4,5,7,8,9
            };
            var binarySearch = new BinarySearch();
            var mid = inputArray.Length / 2;
            var index = binarySearch.RecursiveBinarySearch(inputArray, 0,  inputArray.Length - 1, val);
            if (index > -1)
            {
                Console.WriteLine("value is at position : " + (index + 1));
            }
            else
            {
                Console.WriteLine("element not in the array");
            }

        }
    }
}
