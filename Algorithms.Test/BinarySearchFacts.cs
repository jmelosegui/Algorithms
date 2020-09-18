// Copyright (c) to jmelosegui. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

namespace Algorithms.Test
{
    using Xunit;

    public class BinarySearchFacts
    {
        [Fact]
        public void RecursiveSearch()
        {
            // Arrange
            var collection = new[] { 1, 2, 3, 4, 5, 6 };

            // Act
            int index5 = BinarySearch.RecursiveSearch(collection, 6);
            int index4 = BinarySearch.RecursiveSearch(collection, 5);
            int index3 = BinarySearch.RecursiveSearch(collection, 4);
            int index2 = BinarySearch.RecursiveSearch(collection, 3);
            int index1 = BinarySearch.RecursiveSearch(collection, 2);
            int index0 = BinarySearch.RecursiveSearch(collection, 1);
            int indexNull7 = BinarySearch.RecursiveSearch(collection, 7);
            int indexNull0 = BinarySearch.RecursiveSearch(collection, 0);

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

        [Fact]
        public void RecursiveSearchDescendingSort()
        {
            // Arrange
            var collection = new[] { 6, 5, 4, 3, 2, 1 };

            // Act
            int index5 = BinarySearch.RecursiveSearch(collection, 1, SortDirection.Desc);
            int index4 = BinarySearch.RecursiveSearch(collection, 2, SortDirection.Desc);
            int index3 = BinarySearch.RecursiveSearch(collection, 3, SortDirection.Desc);
            int index2 = BinarySearch.RecursiveSearch(collection, 4, SortDirection.Desc);
            int index1 = BinarySearch.RecursiveSearch(collection, 5, SortDirection.Desc);
            int index0 = BinarySearch.RecursiveSearch(collection, 6, SortDirection.Desc);
            int indexNull7 = BinarySearch.RecursiveSearch(collection, 7, SortDirection.Desc);
            int indexNull0 = BinarySearch.RecursiveSearch(collection, 0, SortDirection.Desc);

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

        [Fact]
        public void IterativeSearch()
        {
            // Arrange
            var collection = new[] { 1, 2, 3, 4, 5, 6 };

            // Act
            int index5 = BinarySearch.IterativeSearch(collection, 6);
            int index4 = BinarySearch.IterativeSearch(collection, 5);
            int index3 = BinarySearch.IterativeSearch(collection, 4);
            int index2 = BinarySearch.IterativeSearch(collection, 3);
            int index1 = BinarySearch.IterativeSearch(collection, 2);
            int index0 = BinarySearch.IterativeSearch(collection, 1);
            int indexNull7 = BinarySearch.IterativeSearch(collection, 7);
            int indexNull0 = BinarySearch.IterativeSearch(collection, 0);

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

        [Fact]
        public void IterativeSearchDescendingSort()
        {
            // Arrange
            var collection = new[] { 6, 5, 4, 3, 2, 1 };

            // Act
            int index5 = BinarySearch.IterativeSearch(collection, 1, SortDirection.Desc);
            int index4 = BinarySearch.IterativeSearch(collection, 2, SortDirection.Desc);
            int index3 = BinarySearch.IterativeSearch(collection, 3, SortDirection.Desc);
            int index2 = BinarySearch.IterativeSearch(collection, 4, SortDirection.Desc);
            int index1 = BinarySearch.IterativeSearch(collection, 5, SortDirection.Desc);
            int index0 = BinarySearch.IterativeSearch(collection, 6, SortDirection.Desc);
            int indexNull7 = BinarySearch.IterativeSearch(collection, 7, SortDirection.Desc);
            int indexNull0 = BinarySearch.IterativeSearch(collection, 0, SortDirection.Desc);

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
