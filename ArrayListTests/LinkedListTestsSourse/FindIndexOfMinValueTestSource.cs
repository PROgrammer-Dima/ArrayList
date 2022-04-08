using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.LinkedListTestsSourse
{
    internal class FindIndexOfMinValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 0 });
            int expected = 7;
            yield return new object[] { actualList, expected };

            actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 10 });
            expected = 0;
            yield return new object[] { actualList, expected };

            actualList = new LinkedList(new int[] { 1, 2, 3, 4, 0, 5, 6, 7, 10 });
            expected = 4;
            yield return new object[] { actualList, expected };
        }
    }
}
