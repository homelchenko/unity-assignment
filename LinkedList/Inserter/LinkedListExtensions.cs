using System.Collections.Generic;

namespace Inserter
{
    public static class LinkedListExtensions
    {
        public static void InsertAscending(this LinkedList<int> list, int value)
        {
            list.AddFirst(value);
        }
    }
}
