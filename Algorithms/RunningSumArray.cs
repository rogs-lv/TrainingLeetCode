using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class RunningSumArray
    {
        /// <summary>
        /// Big O
        /// Complexity: O(n) - The array is only traversed once, and the new value is the current position plus the value of the previous position, with accumulated value
        /// </summary>
        /// <param name="numsArray">Numbers array</param>
        /// <returns>Return the running sum of numbers.</returns>
        public int[] RunningSum(int[] numsArray)
        {
            if (numsArray == null) return new int[] { };
            if (numsArray.Length == 0 || numsArray.Length == 1) return numsArray;

            int len = numsArray.Length;

            for (int i = 1; i < len; i++)
            {
                numsArray[i] = numsArray[i - 1] + numsArray[i];
            }
            return numsArray;
        }
        /// <summary>
        /// Big O 
        /// Complexity: O(N2) - There are two cycles going through the same matrix, the second one goes to position n-1 of the first cycle
        /// </summary>
        /// <param name="numsArray">Numbers array</param>
        /// <returns>Return the running sum of numbers.</returns>
        //public int[] RunningSum(int[] numsArray)
        //{
        //    int len = numsArray.Length;
        //    int[] newArray = new int[len];
        //    for (int i = 0; i < len; i++)
        //    {
        //        if (i > 0)
        //        {
        //            int acum = 0;
        //            for (int j = 0; j <= i; j++)
        //            {
        //                acum += numsArray[j];
        //                newArray[i] = acum;
        //            }
        //        }
        //        else
        //            newArray[i] = numsArray[i];
        //    }
        //    return newArray;
        //}
    }
}
