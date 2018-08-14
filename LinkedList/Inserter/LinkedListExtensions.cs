using System.Collections.Generic;

namespace Inserter
{
    public static class LinkedListExtensions
    {
        public static void InsertAscending(this LinkedList<int> list, int value)
        {
            if (list.First == null)
            {
                list.AddFirst(value);
            }
            else if (list.First.Value < value)
            {
                list.AddAfter(list.First, value);
            }
        }
    }
}
