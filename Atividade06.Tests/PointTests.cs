using Atividade06;
using Xunit;

namespace Atividade06.Tests
{
    public class PointTests
    {
        [Fact]
        public void DistanceTo_ReturnsCorrectDistance(){
            var pointOrigin = new Point(10, 10);
            var pointFinal = new Point(13, 14);
            var distance = pointOrigin.DistanceTo(pointFinal);

            Assert.Equal(5, distance);
        }

        [Fact]
        public void DistanceTo_TwoEqualPoints_ReturnsDistanceZero()
        {
            var pointOrigin = new Point(10, 10);
            var pointFinal = new Point(10, 10);
            var distance = pointOrigin.DistanceTo(pointFinal);

            Assert.Equal(0, distance);
        }

        [Fact]
        public void DistanceTo_PositiveAndNegativePoints_ReturnsCorrectDistance()
        {
            var pointOrigin = new Point(10, 10);
            var pointFinal = new Point(-20, -30);
            var distance = pointOrigin.DistanceTo(pointFinal);

            Assert.Equal(50, distance);
        }

        [Fact]
        public void DistanceTo_TwoNegativePoints_ReturnsCorrectDistance()
        {
            var pointOrigin = new Point(-2, -2);
            var pointFinal = new Point(-7, -14);
            var distance = pointOrigin.DistanceTo(pointFinal);

            Assert.Equal(13, distance);
        }
    }
}

