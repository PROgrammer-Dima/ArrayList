using System;
using System.Collections;

namespace MyLists.Tests.LinkedListTestsSourse
{
    public class SortLessTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList list = new LinkedList(new int[] { 1, 2, 3 });
            LinkedList expectedList = new LinkedList(new int[] { 3,2,1 });
            yield return new object[] { list, expectedList };

            list = new LinkedList(new int[] { 0 });
            expectedList = new LinkedList(new int[] { 0 });
            yield return new object[] { list, expectedList };

            list = new LinkedList(new int[] { 0,1 });
            expectedList = new LinkedList(new int[] { 1,0 });
            yield return new object[] { list, expectedList };

        }
    }
}
