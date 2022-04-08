using System;
using System.Collections;
using System.Collections.Generic;

namespace MyLists.Tests.LinkedListTestsSourse
{
    internal class DeletedLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            LinkedList expectedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { actualList, expectedList };

            actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 10 });
            expectedList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            yield return new object[] { actualList, expectedList };

            actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 23, 44, -32 });
            expectedList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 23, 44 });
            yield return new object[] { actualList, expectedList };
        }
    }
}
