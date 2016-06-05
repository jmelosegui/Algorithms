namespace Algorithms.Test
{
    using Xunit;

    public class BinarySearchFacts
    {
        [Fact]
        public void Search()
        {
            // Arrange
            var collection = new[] { 1, 2, 3, 4, 5 };

            // Act
            int index5 = BinarySearch.Search(collection, 6);
            int index4 = BinarySearch.Search(collection, 5);
            int index3 = BinarySearch.Search(collection, 4);
            int index2 = BinarySearch.Search(collection, 3);
            int index1 = BinarySearch.Search(collection, 2);
            int index0 = BinarySearch.Search(collection, 1);
            int indexNull7 = BinarySearch.Search(collection, 7);
            int indexNull0 = BinarySearch.Search(collection, 0);

            // Assert
            Assert.Equal(5, index5);
            Assert.Equal(4, index4);
            Assert.Equal(3, index3);
            Assert.Equal(2, index2);
            Assert.Equal(1, index1);
            Assert.Equal(0, index0);
            Assert.Equal(-1, indexNull7);
            Assert.Equal(-1, indexNull0);
        }
    }
}
