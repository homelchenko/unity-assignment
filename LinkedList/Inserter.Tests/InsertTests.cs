using System.Collections.Generic;

using Xunit;

namespace Inserter.Tests
{
    public class InsertTests
    {
        [Fact]
        public void Insert_WhenLinkedListIsEmpty_ShouldContainOnlyInsertedItem()
        {
            // Arrange
            var list = new LinkedList<int>();

            // Act
            list.InsertAscending(5);

            // Assert
            Assert.Equal(5, list.First.Value);
        }
    }
}
