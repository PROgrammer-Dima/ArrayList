using System;
using System.Collections;

namespace MyLists.Tests.LinkedListTestsSourse
{
    internal class DeleteRangeEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            LinkedList expectedList = new LinkedList(new int[] { 1, 2, 3, 4 ,5,6});
            int range = 1;
            yield return new object[] { actualList, expectedList, range };

            actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            expectedList = new LinkedList(new int[] { 1, 2 });
            range = 5;
            yield return new object[] { actualList, expectedList, range };

            actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            expectedList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            range = 0;
            yield return new object[] { actualList, expectedList, range };
        }
    }
}
