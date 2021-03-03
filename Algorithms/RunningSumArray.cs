using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class RunningSumArray
    {
        /// <summary>
        /// Big O
        /// Complejidad: O(n) - El arreglo solo se recorre una unica vez y se le resta la posición 
        /// anterior que ya tiene el ultimo valor acumulado
        /// </summary>
        /// <param name="nums">Array de enteros</param>
        /// <returns>Array de enteros</returns>
        public int[] RunningSum(int[] nums)
        {
            int len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                if (i > 0)
                    nums[i] = nums[i - 1] + nums[i];
                else
                    nums[i] = nums[i];
            }
            return nums;
        }
        /// <summary>
        /// Big O 
        /// Complejidad: O(N2) - Se tienen dos ciclos recorriendo el mismo arreglo, y el segundo lo recorre
        /// hasta la posicion n-1 del primer ciclo
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        //public int[] RunningSum(int[] nums)
        //{
        //    int len = nums.Length;
        //    int[] newArray = new int[len];
        //    for (int i = 0; i < len; i++)
        //    {
        //        if (i > 0)
        //        {
        //            int acum = 0;
        //            for (int j = 0; j <= i; j++)
        //            {
        //                acum += nums[j];
        //                newArray[i] = acum;
        //            }
        //        }
        //        else
        //            newArray[i] = nums[i];
        //    }
        //    return newArray;
        //}
    }
}
