using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class ShuffleTheArray
    {
        /// <summary>
        /// Complexity: O(n) - For each element from 0 to n, We use flag to determine order of elements that we'll add a new array
        /// </summary>
        /// <param name="numsArray">Numbers array</param>
        /// <param name="n">Items to take and combine</param>
        /// <returns>Returns the array with combined values</returns>
        public int[] Shuffle(int[] numsArray, int n)
        {
            if (numsArray == null) return new int[] { };
            if (numsArray.Length == 0) return numsArray;
            if (n < 1 || n > 500 || ((n * 2) != numsArray.Length)) return new int[] { };

            int lenArray = numsArray.Length;
            int[] newArr = new int[lenArray];
            bool flag = true;
            int j = n;
            int l = 0;
            for (int i = 0; i < lenArray; i++)
            {
                if (flag)
                {
                    newArr[i] = numsArray[l];
                    l++;
                    flag = false;
                }
                else
                {
                    newArr[i] = numsArray[j];
                    j++;
                    flag = true;
                }
            }
            return newArr;
        }
    }
}
