using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTut.SortingAlgos
{
    public class MergeSort
    {
        public void Sort(int[] arr, int start, int last)
        {
            if (last > start)
            {
                var middle = (start + last) / 2;
                Sort(arr, start, middle);
                Sort(arr, middle + 1, last);
                Merge(arr, start, middle, last);
            }
        }

        private void Merge(int[] arr, int start, int middle, int last)
        {
            int leftArrayLen1 = middle - start + 1;
            int rightArrayLen2 = last - middle;

            int[] leftArray1 = new int[leftArrayLen1];
            int[] rightArray2 = new int[rightArrayLen2];

            /// copying the data to temp arrays

            for (int i = 0; i < leftArrayLen1; i++)
            {
                leftArray1[i] = arr[start + i];

            }

            for (int j = 0; j < rightArrayLen2; j++)
            {
                rightArray2[j] = arr[middle + 1 + j];
            }

            int startLeftIndex = 0;
            int startRightIndex = 0;
            int k = start;

            while (startLeftIndex < leftArrayLen1 && startRightIndex < rightArrayLen2)
            {

                if(leftArray1[startLeftIndex] < rightArray2[startRightIndex])
                {
                    arr[k] = leftArray1[startLeftIndex];
                    startLeftIndex++;
                }
                else
                {
                    arr[k] = rightArray2[startRightIndex];
                    startRightIndex++;
                }
                k++;
            }

            while(startLeftIndex < leftArrayLen1)
            {
                arr[k] = leftArray1[startLeftIndex];
                startLeftIndex++;
                k++;
            }

            while (startRightIndex < rightArrayLen2)
            {
                arr[k] = rightArray2[startRightIndex];
                startRightIndex++;
                k++;
            }


        }
    }
}
