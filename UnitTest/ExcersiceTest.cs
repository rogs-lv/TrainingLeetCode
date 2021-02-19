using _1480.RunningSumof1dArray;
using _1470.ShuffletheArray;
using Xunit;
using System;

namespace UnitTest
{
    public class ExcersiceTest
    {

        [Fact]
        public void RunningSum()
        {
            ProgramRunning programRunning = new ProgramRunning();
            Random rd = new Random();
            int size = rd.Next(1, 10);
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rd.Next(1, 50);
            }
            var result = programRunning.RunningSum(arr);
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal(size, result.Length);
        }
        [Fact]
        public void ShuffletheArray()
        {
            ProgramShufflet programShuflet = new ProgramShufflet();
            Random rd = new Random();
            int n = rd.Next(2, 10);
            int len = n * 2;
            int[] arr = new int[len];
            for (int j = 0; j < len; j++)
            {
                arr[j] = rd.Next(2, 100);
            }
            var result = programShuflet.Shuffle(arr, n);
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal(len, result.Length);
        }
    }
}
