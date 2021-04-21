using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class ShuffleTheArray
    {
        /// <summary>
        /// O(n) - For each element from 0 to "elements". We use i value to get and determine order of elements that we'll add a new array
        /// </summary>
        /// <param name="numsArray">Numbers array</param>
        /// <param name="elements">number elements to take and combine</param>
        /// <returns>Returns array with combined values</returns>
        public int[] Shuffle(int[] numsArray, int elements)
        {
            if (numsArray == null) return new int[] { };
            if (numsArray.Length == 0) return numsArray;
            if (elements < 1 || elements > 500 || ((elements * 2) != numsArray.Length)) return new int[] { };
            int[] newArray = new int[elements * 2];

            for (int i = 0; i < elements; i++)
            {
                newArray[i + i] = numsArray[i];
                newArray[(i + i) + 1] = numsArray[elements + i];
            }
            return newArray;
        }

        /// <summary>
        /// Complexity: O(n) - For each element from 0 to n, We use flag (variable "turn") to determine order of elements that we'll add a new array
        /// </summary>
        /// <param name="numsArray">Numbers array</param>
        /// <param name="n">Items to take and combine</param>
        /// <returns>Returns the array with combined values</returns>
        //public int[] Shuffle(int[] numsArray, int elements)
        //{
        //    if (numsArray == null) return new int[] { };
        //    if (numsArray.Length == 0) return numsArray;
        //    if (elements < 1 || elements > 500 || ((elements * 2) != numsArray.Length)) return new int[] { };

        //    int lenArray = numsArray.Length;
        //    int[] newArr = new int[lenArray];
        //    bool turn = true; // true -> from index 0 (left) : false -> from index n (rigth)
        //    int indexRight = elements;
        //    int indexLeft = 0;
        //    for (int i = 0; i < lenArray; i++)
        //    {
        //        if (turn)
        //        {
        //            newArr[i] = numsArray[indexLeft];
        //            indexLeft++;
        //            turn = false;
        //        }
        //        else
        //        {
        //            newArr[i] = numsArray[indexRight];
        //            indexRight++;
        //            turn = true;
        //        }
        //    }
        //    return newArr;
        //}
    }
}
