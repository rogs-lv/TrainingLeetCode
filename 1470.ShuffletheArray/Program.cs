using System;

namespace _1470.ShuffletheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int n = rd.Next(2, 10);
            //Only pair numbers
            /*while (n%2 != 0) {
                n = rd.Next(2, 20);
            }*/
            int len = n * 2;
            int[] arr = new int[len];
            for (int j = 0; j < len; j++) {
                arr[j] = rd.Next(2, 100);
            }
            Console.WriteLine("Input: n: {0}, nums: [{1}]", n, String.Join(",",arr));
            int[] result = Shuffle(arr, n);
            Console.WriteLine("Output: {0}", String.Join(",", result));
        }
        public static int[] Shuffle(int[] nums, int n)
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
