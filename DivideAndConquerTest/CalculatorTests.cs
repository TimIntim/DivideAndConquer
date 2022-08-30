using DivideAndConquer;

namespace DivideAndConquerTest
{
    public class CalculatorTests
    {
        [Fact]
        public void SumUsingLoop_EmptyArray_ReturnZero()
        {
            var list = new List<int>();
            var result = Calculator.SumUsingLoop(list);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 1 , 2}, 3)]
        [InlineData(new[] { 1, 2, 3 }, 6)]
        public void SumUsingLoop_NumsArray_ReturnSumOfNums(int[] input, int expected)
        {
            var list = input.ToList();
            var result = Calculator.SumUsingLoop(list);
            Assert.Equal(expected, result);
        }
    }
}