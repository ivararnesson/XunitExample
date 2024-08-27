using XunitExample;

namespace XunitExampleTest
{
    public class MyMathTest
    {
        private MyMath myMath;

        public MyMathTest()
        {
            myMath = new MyMath();
        }
        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(11, false)]
        [InlineData(22, true)]
        public void EvenOrOdd(int nr, bool expected)
        {
            Assert.Equal(myMath.EvenOrOdd(nr), expected);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(11, 11)]
        [InlineData(22, 22)]
        public void Add(int nr, int nr2)
        {
            Assert.Equal(myMath.Add(nr, nr2), nr + nr2);
        }
    }
}