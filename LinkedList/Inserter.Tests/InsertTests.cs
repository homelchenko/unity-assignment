using System.Collections.Generic;

using Xunit;

namespace Inserter.Tests
{
    public class InsertTests
    {
        [Fact]
        public void InsertAscending_WhenLinkedListIsEmpty_ShouldContainOnlyInsertedItem()
        {
            // Arrange
            var list = new LinkedList<int>();

            // Act
            list.InsertAscending(5);

            // Assert
            Assert.Equal(5, list.First.Value);
        }

        [Fact]
        public void InsertAscending_WhenLinkedListContainsItemSmallerThanNew_ShouldNewElementBeLast()
        {
            // Arrange
            var list = new LinkedList<int>(new[] { 3 });

            // Act
            list.InsertAscending(5);

            // Assert
            Assert.Equal(3, list.First?.Value);
            Assert.Equal(5, list.First?.Next?.Value);
        }

        [Fact]
        public void InsertAscending_WhenLinkedListContainsItemBiggerThanNew_ShouldNewElementBeFirst()
        {
            // Arrange
            var list = new LinkedList<int>(new[] { 5 });

            // Act
            list.InsertAscending(3);

            // Assert
            Assert.Equal(3, list.First?.Value);
            Assert.Equal(5, list.First?.Next?.Value);
        }

        [Fact]
        public void InsertAscending_WhenLinkedListContainsSameItemAsNew_ShouldContainTwoEqualItems()
        {
            // Arrange
            var list = new LinkedList<int>(new[] { 5 });

            // Act
            list.InsertAscending(5);

            // Assert
            Assert.Equal(5, list.First?.Value);
            Assert.Equal(5, list.First?.Next?.Value);
        }

        [Fact]
        public void InsertAscending_WhenLinkedListContainsSeveralItemsSmallerThanNew_ShouldContainNewItemAsLast()
        {
            // Arrange
            var list = new LinkedList<int>(new[] { 1, 3 });

            // Act
            list.InsertAscending(5);

            // Assert
            Assert.Equal(1, list.First?.Value);
            Assert.Equal(3, list.First?.Next?.Value);
            Assert.Equal(5, list.First?.Next?.Next?.Value);
        }

    }
}
