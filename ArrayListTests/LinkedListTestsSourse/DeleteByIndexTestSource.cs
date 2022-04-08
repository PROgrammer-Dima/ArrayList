using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.LinkedListTestsSourse
{
    public class DeleteByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList expectedList = new LinkedList(new int[] { 1, 2, 3, 5 });
            int index = 3;
            yield return new object[] { actualList, expectedList, index };

            actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new LinkedList(new int[] { 2, 3, 4, 5 });
            index = 0;
            yield return new object[] { actualList, expectedList, index };

            actualList = new LinkedList(new int[] { -1, 0, 3, 446, 57, 98, 3, 0,7 });
            expectedList = new LinkedList(new int[] { -1, 0, 3, 446, 57, 98, 3,0 });
            index = 8;
            yield return new object[] { actualList, expectedList, index };
        }
    }
}
