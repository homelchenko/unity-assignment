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
        public void InsertAscending_WhenLinkedListContainSameItemAsNew_ShouldContainTwoEqualItems()
        {
            // Arrange
            var list = new LinkedList<int>(new[] { 5 });

            // Act
            list.InsertAscending(5);

            // Assert
            Assert.Equal(5, list.First?.Value);
            Assert.Equal(5, list.First?.Next?.Value);
        }
    }
}
