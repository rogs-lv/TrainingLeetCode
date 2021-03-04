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
    }
}
