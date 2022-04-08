using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.LinkedListTestsSourse
{
    internal class DeleteRangeHeadTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            LinkedList expectedList = new LinkedList(new int[] { 4, 5, 6, 7 });
            int num = 3;
            yield return new object[] { actualList, expectedList, num };


            actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            expectedList = new LinkedList(new int[] {5, 6, 7 });
            num = 4;
            yield return new object[] { actualList, expectedList, num };

            actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            expectedList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            num = 0;
            yield return new object[] { actualList, expectedList, num };

        }
    }
}
