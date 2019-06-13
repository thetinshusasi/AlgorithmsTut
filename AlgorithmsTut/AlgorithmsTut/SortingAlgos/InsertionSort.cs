using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTut.SortingAlgos
{
   public class InsertionSort
    {
        public int[] InsertionSortMethod(int[] arr)
        {
            int len = arr.Length;
            for(var i = 1; i < len ; i++)
            {
                var ele = arr[i];
                var j = i - 1;

                /// just like we arrange cards in hands we push element to the right
                while (j >= 0 && arr[j] > ele)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                /// once we reach leftmost position we replace it the smallest element
                arr[j + 1] = ele;
            }

            return arr;
        }

    }
}
