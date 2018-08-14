using System.Collections.Generic;

namespace Inserter
{
    public static class LinkedListExtensions
    {
        public static void InsertAscending(this LinkedList<int> list, int value)
        {
            if (list.First == null)
            {
                list.AddLast(value);
            }
            else if (value < list.First.Value)
            {
                list.AddBefore(list.First, value);
            }
            else
            {
                list.AddAfter(list.First, value);
            }
        }
    }
}
