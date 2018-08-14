using System.Collections.Generic;

namespace Inserter
{
    public static class LinkedListExtensions
    {
        public static void InsertAscending(this LinkedList<int> list, int value)
        {
            var currentNode = list.First;

            while (currentNode != null)
            {
                if (value < currentNode.Value)
                {
                    list.AddBefore(currentNode, value);
                    break;
                }

                currentNode = currentNode.Next;
            }

            if (currentNode == null)
            { 
                list.AddLast(value);
            }
        }
    }
}
