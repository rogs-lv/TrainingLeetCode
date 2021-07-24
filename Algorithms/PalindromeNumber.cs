using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class PalindromeNumber
    {
        /// <summary>
        /// Complexity: O(N) - We use only one for, because the variant is to determine the midpoint
        /// </summary>
        /// <param name="number">value to evaluate</param>
        /// <returns>true if is palindrome or false if is not</returns>
        public bool IsPalindrome(int number)
        {
            if (number < 0) return false; //Numbers negatives never will true
            if (number <= 9 && number >= 0) return true; // Numbers with only digits always will true

            int lenghtNumber = number.ToString().Length;
            char[] arrayOfNumbers = number.ToString().ToCharArray();

            int midpoint = (lenghtNumber % 2) == 1 ? (lenghtNumber - 1) / 2 : lenghtNumber / 2; // 1 is not even number || 0 is even number
            for (int i = 0; i < midpoint; i++)
            {
                int idEnd = (lenghtNumber - i) - 1; //last value
                if (arrayOfNumbers[i] != arrayOfNumbers[idEnd]) return false;
            }
            return true;
        }
        /// <summary>
        /// Complexity: O(N^2) - We use two cycles for the process of different form the length of the matrix.
        /// </summary>
        /// <param name="number">value to evaluate</param>
        /// <returns>true if is palindrome or false if is not</returns>
        //public bool IsPalindrome(int number) {
        //    if (number < 0) return false;

        //    int leng = number.ToString().Length;
        //    char[] arr = number.ToString().ToCharArray();
        //    int par = leng % 2;

        //    if (par == 1) {// is not even number
        //        int halfImpar = (leng - 1) / 2;
        //        for (int i = 0; i < halfImpar; i++)
        //        {
        //            int idEnd = (leng - i) - 1; //ultimo valor
        //            if (arr[i] != arr[idEnd]) return false;
        //        }
        //    } else {// even number
        //        int halfPar = leng / 2;
        //        for (int j = 0; j < halfPar; j++)
        //        {
        //            int idEnd = (leng - j) - 1; //ultimo valor
        //            if (arr[j] != arr[idEnd]) return false;
        //        }
        //    }
        //    return true;
        //}
    }
}
