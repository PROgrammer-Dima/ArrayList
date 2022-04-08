using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.LinkedListTestsSourse
{
    internal class FindIndexOfMaxValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actualList = new LinkedList(new int[] { 1, 2, 3, 49, 5, 6, 7, 0 });
            int expected = 3;
            yield return new object[] { actualList, expected };

            actualList = new LinkedList(new int[] { 11, 2, 3, 4, 5, 6, 7, 9 });
            expected = 0;
            yield return new object[] { actualList, expected };

            actualList = new LinkedList(new int[] { 12, 1, 2, 3, 4, 5, 6, 7, 90 });
            expected = 8;
            yield return new object[] { actualList, expected };
        }
    }
}
