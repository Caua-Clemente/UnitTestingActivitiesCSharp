namespace Atividade08.Tests
{
    public class StatisticsTests
    {
        [Fact]
        public void CalculateAverage_ReturnsCorrectAverage()
        {
            var statistics = new Statistics();
            var numberList = new List<int> {1, 2, 3, 4, 5};

            Assert.Equal(3, statistics.CalculateAverage(numberList));
        }

        [Fact]
        public void CalculateAverage_NegativeNumbers_ReturnsCorrectAverage()
        {
            var statistics = new Statistics();
            var numberList = new List<int> {-1, -2, -3, -4, -5};

            Assert.Equal(-3, statistics.CalculateAverage(numberList));
        }

        [Fact]
        public void CalculateAverage_SameNumbers_ReturnsCorrectAverage()
        {
            var statistics = new Statistics();
            var numberList = new List<int> {10, 10, 10, 10, 10};

            Assert.Equal(10, statistics.CalculateAverage(numberList));
        }

        [Fact]
        public void CalculateAverage_ListWithOnlyZero_ReturnsCorrectAverage()
        {
            var statistics = new Statistics();
            var numberList = new List<int> {0};

            Assert.Equal(0, statistics.CalculateAverage(numberList));
        }

        [Fact]
        public void CalculateAverage_VariousNumbers_ReturnsCorrectAverage()
        {
            var statistics = new Statistics();
            var numberList = new List<int> {-1, 10, -3, 20, 50, -100, 2, 77, -45, 0};

            Assert.Equal(1, statistics.CalculateAverage(numberList));
        }

        [Fact]
        public void CalculateAverage_ZeroCountList_ReturnsException()
        {
            var statistics = new Statistics();
            var numberList = new List<int> {};

            Assert.Throws<ArgumentException>(() => statistics.CalculateAverage(numberList));
        }

        [Fact]
        public void CalculateAverage_NullList_ReturnsException()
        {
            var statistics = new Statistics();

            Assert.Throws<ArgumentException>(() => statistics.CalculateAverage(null));
        }
    }
}

