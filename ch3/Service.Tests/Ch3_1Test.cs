using Xunit;

namespace Service.Tests
{
    public class Ch3_1Test
    {
        private readonly Ch3_1 _ch3_1;

        public Ch3_1Test()
        {
            _ch3_1 = new Ch3_1();
        }

        [Fact]
        public void Count3_1_1Test()
        {
            var result = _ch3_1.Count3_1_1(5);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Count3_1_2Test()
        {
            int[] numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            var result = _ch3_1.Count3_1_2(numbers, 5);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Count3_1_3Test()
        {
            int[] numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            var result = _ch3_1.Count3_1_3(numbers, IsEven);
            Assert.Equal(5, result);
        }

        public bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        [Fact]
        public void Count3_1_6Test()
        {
            int[] numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            var result = _ch3_1.Count3_1_6(numbers, delegate (int n) { return n % 2 == 0; });
            Assert.Equal(5, result);
        }
    }
}