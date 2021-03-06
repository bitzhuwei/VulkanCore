
using Xunit;

namespace VulkanCore.Tests
{
    public class RectTest
    {
        [Fact]
        public void Rect2DEquals()
        {
            var val1 = new Rect2D(0, 1, 2, 3);
            var val2 = new Rect2D(4, 5, 6, 7);

            Assert.True(val1.Equals(val1));
            Assert.False(val1.Equals(val2));
            Assert.True(val1 == val1);
            Assert.False(val1 == val2);
            Assert.False(val1 != val1);
            Assert.True(val1 != val2);
            Assert.NotEqual(val1.GetHashCode(), val2.GetHashCode());
        }
    }
}
