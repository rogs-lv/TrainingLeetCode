using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class ShuffleTheArray
    {
        /// <summary>
        /// Complejidad: O(n) - Un arreglo a retornar del mismo tipo, sin importar
        /// la condición ya que no afecta el ciclo for. 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] Shuffle(int[] nums, int n)
        {
            int lenArray = nums.Length;
            int[] newArr = new int[lenArray];
            bool flag = true;
            int j = n;
            int l = 0;
            for (int i = 0; i < lenArray; i++)
            {
                if (flag)
                {
                    newArr[i] = nums[l];
                    l++;
                    flag = false;
                }
                else
                {
                    newArr[i] = nums[j];
                    j++;
                    flag = true;
                }
            }
            return newArr;
        }
    }
}
