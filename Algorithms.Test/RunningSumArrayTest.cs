using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Algorithms.Test
{
    public class RunningSumArrayTest
    {
        RunningSumArray _runningSumArray;
        public RunningSumArrayTest() {
            _runningSumArray = new RunningSumArray();
        }
        [Fact]
        public void RunningSum_SmallArray_ReturnRunningSumOfNumbers()
        {
            int[] numsArray = new int[] { 1, 2, 3, 4 };
            int[] outputArray = new int[] { 1, 3, 6, 10 };

            var result = _runningSumArray.RunningSum(numsArray);
            Assert.Equal(outputArray, result);
        }
        [Fact]
        public void RunningSum_ArrayEmpty_ReturnArrayEmpty()
        {
            int[] numsArray = new int[] { };

            var result = _runningSumArray.RunningSum(numsArray);
            Assert.Empty(result);
        }
        [Fact]
        public void RunningSum_ArrayNull_ReturnArraryEmpty() {
            int[] numsArray = null;

            var result = _runningSumArray.RunningSum(numsArray);
            Assert.Empty(result);
        }
        [Fact]
        public void RunningSum_ArrayWithOneElement_ReturnSameArray()
        {
            int[] numsArray = new int[] { 3 };

            var result = _runningSumArray.RunningSum(numsArray);
            Assert.Equal(numsArray, result);
        }
        [Fact]
        public void RunningSum_ArrayWithOneNegativeNumber_ReturnSameArray() {
            int[] numsArray = new int[] { -1000001, 2, 1 };

            var result = _runningSumArray.RunningSum(numsArray);
            Assert.Equal(numsArray, result);
        }
        [Fact]
        public void RunningSum_ArrayWithValuesNegatives_ReturnRunningSumOfNumbers() {
            int[] numsArray = new int[] { -1, -2, -3, 5 };
            int[] outputArray = new int[] { -1, -3, -6, -1 };

            var result = _runningSumArray.RunningSum(numsArray);
            Assert.Equal(outputArray, result);
        }
        [Fact]
        public void RunningSum_ArrayWithAllValuesNegatives_ReturnRunningSumOfNumbers()
        {
            int[] numsArray = new int[] { -9, -7, -4, -15 };
            int[] outputArray = new int[] { -9, -16, -20, -35 };

            var result = _runningSumArray.RunningSum(numsArray);
            Assert.Equal(outputArray, result);
        }
        [Fact]
        public void RunningSum_ArrayWithNumberMoreThan_ReturnSameArray()
        {
            int[] numsArray = new int[] { 1000001, 4, 1 };

            var result = _runningSumArray.RunningSum(numsArray);
            Assert.Equal(numsArray, result);
        }
    }
}
