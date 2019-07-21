using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTut.SortingAlgos
{
   public class HeapSort
    {

        public void Sort(int [] arr)
        {
            var len = arr.Length;
            for (int i = (len/2)-1; i >= 0; i--)
            {
                Heapify(arr, len, i);
            }
            for (int i = len-1; i >=0; i--)
            {
                var temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                Heapify(arr, i, 0);
            }
        }

        public void Heapify(int [] arr, int arrSize, int nodeIndex)
        {
            var largest = nodeIndex;
            var left = 2 * nodeIndex;
            var right = (2 * nodeIndex) + 1;

            if(left<arrSize && arr[largest] < arr[left])
            {
                largest = left;
            }

            if (right < arrSize && arr[largest] < arr[right])
            {
                largest = right;
            }

            if(largest!= nodeIndex)
            {
                var temp = arr[nodeIndex];
                arr[nodeIndex] = arr[largest];
                arr[largest] = temp;
                Heapify(arr, arrSize, largest);
            }
        }
    }
}
