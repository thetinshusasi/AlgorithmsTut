using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTut.SortingAlgos
{
    /// <summary>
    /// https://www.youtube.com/watch?v=PgBzjlCcFvc
    /// </summary>
    public class QuickSort
    {
        public void Sort(int[] arr, int startIndex, int lastIndex)
        {
            if(startIndex< lastIndex)
            {
                var p = PartionedIndex(arr, startIndex, lastIndex);
                Sort(arr, startIndex, p - 1);
                Sort(arr, p + 1, lastIndex);
            }
        }

        
        public int PartionedIndex(int[] arr, int startIndex, int lastIndex)
        {
            var pivot = arr[lastIndex];
            var i = startIndex - 1;
            for (int j = startIndex; j <= lastIndex-1; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    var temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
            var temp1 = arr[lastIndex];
            arr[lastIndex] = arr[i + 1];
            arr[i + 1] = temp1;
            return i + 1;
        }

    }
}
