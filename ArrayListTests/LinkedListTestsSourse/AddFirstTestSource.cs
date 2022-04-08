using System;
using System.Collections;

namespace MyLists.Tests.LinkedListTestsSourse
{
    public class AddFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            LinkedList expectedList = new LinkedList(new int[] { 7, 1, 2, 3, 4, 5, 6 });
            int num = 7;
            yield return new object[] { actualList, expectedList, num };

            actualList = new LinkedList(new int[] { });
            expectedList = new LinkedList(new int[] { 7 });
            num = 7;
            yield return new object[] { actualList, expectedList, num };

            actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            expectedList = new LinkedList(new int[] { -77, 1, 2, 3, 4, 5, 6 });
            num = -77;
            yield return new object[] { actualList, expectedList, num };
        }
    }
}
