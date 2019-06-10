using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTut.SortingAlgos
{
    public class SelectionSort
    {
        public int[] SelectionSortMethod(int[] arr)
        {
            var len = arr.Length;

            for (var i = 0; i < len; i++)
            {
                var min = i;

                for (var j = i + 1; j < len; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }

                    var temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                }

            }
            return arr;
        }
    }
}
