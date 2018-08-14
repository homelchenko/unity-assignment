using System.Collections.Generic;

namespace Inserter
{
    public static class LinkedListExtensions
    {
        public static void InsertAscending(this LinkedList<int> list, int value)
        {
            var currentNode = list.First;

            if (currentNode == null)
            {
                list.AddLast(value);
            }
            else if (value < currentNode.Value)
            {
                list.AddBefore(currentNode, value);
            }
            else
            {
                list.AddLast(value);
            }
        }
    }
}
