using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTut.SearchingAlgos
{
    public class BinarySearch
    {

        public int RecursiveBinarySearch(int[] arr, int startIndex, int endIndex, int val)
        {

            if (endIndex >= startIndex)
            {
                int mid = (startIndex + endIndex) / 2;
                // If the element is present at the 
                // middle itself 
                if (arr[mid] == val)
                {
                    return mid;
                }

                // If element is smaller than mid, then 
                // it can only be present in left subarray
                if (arr[mid] > val)
                {
                    return RecursiveBinarySearch(arr, startIndex, mid - 1, val);

                }

                // Else the element can only be present 
                // in right subarray
                return RecursiveBinarySearch(arr, mid + 1, endIndex, val);

            }

            // We reach here when element is not present 
            // in array 
            return -1;
        }


    }

}
