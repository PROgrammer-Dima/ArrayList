using System;
using System.Collections;

namespace MyLists.Tests.LinkedListTestsSourse
{
    internal class DeleteFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList expectedList = new LinkedList(new int[] { 2, 3, 4, 5 });
            yield return new object[] { actualList, expectedList };

            actualList = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
            expectedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { actualList, expectedList };

            actualList = new LinkedList(new int[] { -9, 1, 2, 3, 4, 5 });
            expectedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { actualList, expectedList };

            actualList = new LinkedList(new int[] {  });
            expectedList = new LinkedList(new int[] {  });
            yield return new object[] { actualList, expectedList };

            actualList = new LinkedList(new int[] {1 });
            expectedList = new LinkedList(new int[] { });
            yield return new object[] { actualList, expectedList };
        }
    }
}
