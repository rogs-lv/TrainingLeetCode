using System;

namespace _1480.RunningSumof1dArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int size = rd.Next(1,10);
            int[] arr = new int[size];
            for (int i = 0; i < size; i++) {
                arr[i] = rd.Next(1, 50);
            }
            Console.WriteLine("Input : " +  String.Join(",", arr));
            int[] result = RunningSum(arr);
            Console.WriteLine("Output : " + String.Join(",", result));
        }
        public static int[] RunningSum(int[] nums)
        {
            int len = nums.Length;
            int[] newArray = new int[len];
            for (int i = 0; i < len; i++)
            {
                if (i > 0)
                {
                    int acum = 0;
                    for (int j = 0; j <= i; j++)
                    {
                        acum += nums[j];
                        newArray[i] = acum;
                    }
                }
                else
                    newArray[i] = nums[i];
            }
            return newArray;
        }
    }
}
