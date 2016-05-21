﻿// Copyright (c) to jmelosegui. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

using System;
using Xunit.Sdk;

namespace Algorithms.Test
{
    using Xunit;

    public class InsertionSortFacts
    {
        [Fact]
        public void ThrowNullException()
        {
            // Arrange
            int[] collection = null;

            // Act
            Action action = () => collection.Sort();

            // Assert
            Assert.Throws<ArgumentNullException>(action);
        }

        [Fact]
        public void SortDescending()
        {
            // Arrange
            var collection = new[] { 5, 2, 4, 6, 1, 3 };

            // Act
            collection.Sort(SortDirection.Desc);

            // Assert
            Assert.Equal(6, collection[0]);
            Assert.Equal(5, collection[1]);
            Assert.Equal(4, collection[2]);
            Assert.Equal(3, collection[3]);
            Assert.Equal(2, collection[4]);
            Assert.Equal(1, collection[5]);
        }

        [Fact]
        public void SortAscending()
        {
            // Arrange
            var collection = new[] { 5, 2, 4, 6, 1, 3 };

            // Act
            collection.Sort();

            // Assert
            Assert.Equal(1, collection[0]);
            Assert.Equal(2, collection[1]);
            Assert.Equal(3, collection[2]);
            Assert.Equal(4, collection[3]);
            Assert.Equal(5, collection[4]);
            Assert.Equal(6, collection[5]);
        }
    }
}
