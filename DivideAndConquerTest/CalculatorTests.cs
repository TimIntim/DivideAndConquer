using DivideAndConquer;

namespace DivideAndConquerTest
{
    public class CalculatorTests
    {
        [Fact]
        public void SumUsingLoop_EmptyList_ReturnZero()
        {
            var list = new List<int>();
            var result = Calculator.SumUsingLoop(list);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 1 , 2}, 3)]
        [InlineData(new[] { 1, 2, 3 }, 6)]
        public void SumUsingLoop_NumsList_ReturnSumOfNums(int[] inputs, int expected)
        {
            var list = inputs.ToList();
            var result = Calculator.SumUsingLoop(list);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SumUsingRecursion_EmptyList_ReturnZero()
        {
            var list = new List<int>();
            var result = Calculator.SumUsingRecursion(list);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 1, 2 }, 3)]
        [InlineData(new[] { 1, 2, 3 }, 6)]
        public void SumUsingRecursion_NumsList_ReturnSumOfNums(int[] inputs, int expected)
        {
            var list = inputs.ToList();
            var result = Calculator.SumUsingRecursion(list);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Count_EmptyList_ReturnZero()
        {
            var list = new List<int>();
            var result = Calculator.Count(list);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 1, 2 }, 2)]
        [InlineData(new[] { 1, 2, 3 }, 3)]
        public void Count_NumsList_ReturnCountOfNums(int[] inputs, int expected)
        {
            var list = inputs.ToList();
            var result = Calculator.Count(list);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindBiggest_EmptyList_ReturnZero()
        {
            var list = new List<int>();
            var result = Calculator.FindBiggest(list);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 2, 3, 55, 64, 154, 153 }, 154)]
        public void FindBiggest_NumsList_ReturnBiggestNum(int[] inputs, int expected)
        {
            var list = inputs.ToList();
            var result = Calculator.FindBiggest(list);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void BinarySearch_EmptyArray_ReturnMinusOne()
        {
            var arr = Array.Empty<int>();
            var result = Calculator.BinarySearch(arr, 1);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void BinarySearch_ContainedNum_ReturnExpectedIndex()
        {
            var arr = new int[] { 2, 3, 55, 64, 153, 154 };
            const int NUM_OF_ARRAY = 64;
            int expected = 3;

            var result = Calculator.BinarySearch(arr, NUM_OF_ARRAY);
            
            Assert.Equal(expected, result);
        }

        [Fact]
        public void BinarySearch_NotContainedNum_ReturnMinusOne()
        {
            var arr = new int[] { 2, 3, 55, 64, 153, 154 };
            const int NUM_OF_ARRAY = 99;
            int expected = -1;

            var result = Calculator.BinarySearch(arr, NUM_OF_ARRAY);

            Assert.Equal(expected, result);
        }
    }
}