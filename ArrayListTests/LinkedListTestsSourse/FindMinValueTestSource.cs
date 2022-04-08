using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.LinkedListTestsSourse
{
    internal class FindMinValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 0 });
            int expected = 0;
            yield return new object[] { actualList, expected };

            actualList = new LinkedList(new int[] { 1, 2, 3, 45, 5, 6, 7 });
            expected = 1;
            yield return new object[] { actualList, expected };


            actualList = new LinkedList(new int[] { 121, 2, 3, 45, 5, 6, 7 });
            expected = 2;
            yield return new object[] { actualList, expected };
        }
    }
}
