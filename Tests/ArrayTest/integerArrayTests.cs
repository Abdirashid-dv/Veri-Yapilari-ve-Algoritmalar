using DataStructures.Array;
using Xunit;

namespace Tests.ArrayTests
{
    public class IntegerArrayTests
    {
        [Fact]
        public void Mean_Test()
        {
            // Arrange
            var array = new integerArray();
            array.Add(10);
            array.Add(15);
            array.Add(25);
            array.Add(40);

            // Act
            var mean = array.Mean();

            // Assert
            Assert.Equal(22.5, mean);
        }
    }
}