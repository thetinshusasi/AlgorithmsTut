using AlgorithmsTut.SearchingAlgos;
using AlgorithmsTut.SortingAlgos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTut
{
    class Program
    {
        public static int[] arr = new int[]{
            9,8,7,6,5,4            };
        static void Main(string[] args)
        {
            //Console.WriteLine("Binary Search");
            //Console.WriteLine("search for 7 number");
            //CallBinaryRecursiveSearch(7);
            //Console.WriteLine("search for 10 number");
            //CallBinaryRecursiveSearch(10);
            //Console.WriteLine($"/////////////////////////////////////////////////////////");

            //Console.WriteLine("Sorting Algos");
            //Console.WriteLine($"/////////////////////////////////////////////////////////");
            //Console.WriteLine("Selection Sort");
            //CallSelectionSort();
            //Console.WriteLine($"/////////////////////////////////////////////////////////");

            //Console.WriteLine($"/////////////////////////////////////////////////////////");
            //Console.WriteLine("Insertion Sort");
            //CallInsertionSort();
            //Console.WriteLine($"/////////////////////////////////////////////////////////");


            //Console.WriteLine($"/////////////////////////////////////////////////////////");
            //Console.WriteLine("Merge Sort");
            //CallMergeSort();
            //Console.WriteLine($"/////////////////////////////////////////////////////////");
            //Console.WriteLine($"/////////////////////////////////////////////////////////");
            //Console.WriteLine("Quick Sort");
            //CallQuickSort();
            //Console.WriteLine($"/////////////////////////////////////////////////////////");

            //Console.WriteLine($"/////////////////////////////////////////////////////////");
            //Console.WriteLine("Heap Sort");
            //CallHeapSort();
            //Console.WriteLine($"/////////////////////////////////////////////////////////");

            Console.WriteLine($"/////////////////////////////////////////////////////////");
            Console.WriteLine("Radix Sort");
            CallRadixSort();
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
            var index = binarySearch.RecursiveBinarySearch(inputArray, 0, inputArray.Length - 1, val);
            if (index > -1)
            {
                Console.WriteLine("value is at position : " + (index + 1));
            }
            else
            {
                Console.WriteLine("element not in the array");
            }

        }
        public static void CallSelectionSort()
        {
            Console.WriteLine("Input arr");

            var selSort = new SelectionSort();
            var arr = Program.arr;
            DispayArr(arr);
            var outputArr = selSort.SelectionSortMethod(arr);
            Console.WriteLine("Selection Sort  sorted array");
            DispayArr(outputArr);


        }

        public static void CallInsertionSort()
        {
            Console.WriteLine("Input arr");

            var insSort = new InsertionSort();
            var arr = Program.arr;
            DispayArr(arr);
            var outputArr = insSort.InsertionSortMethod(arr);
            Console.WriteLine("Insertion Sort  sorted array");
            DispayArr(outputArr);


        }

        public static void CallMergeSort()
        {
            var mergeSort = new MergeSort();
            var arr = Program.arr;
            DispayArr(arr);
            mergeSort.Sort(arr, 0, arr.Length - 1);
            DispayArr(arr);
        }

        public static void CallQuickSort()
        {
            var quickSort = new QuickSort();
            var arr = Program.arr;
            DispayArr(arr);
            quickSort.Sort(arr, 0, arr.Length - 1);
            DispayArr(arr);
        }

        public static void CallHeapSort()
        {
            var heapSort = new HeapSort();
            var arr = Program.arr;
            DispayArr(arr);
            heapSort.Sort(arr);
            DispayArr(arr);

        }

        public static void CallRadixSort()
        {
            var arr = Program.arr;
            DispayArr(arr);
            RadixSort.CallRadixsort(arr, arr.Length);
            DispayArr(arr);
        }

        public static void DispayArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " - >");
            }
            Console.WriteLine(" Done ");
        }
    }
}
