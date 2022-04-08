using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.LinkedListTestsSourse
{
    internal class FindMaxValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actualList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            int expected = 7;
            yield return new object[] { actualList, expected };


            actualList = new LinkedList(new int[] { 1, 2, 3, 45, 5, 6, 7, 0 });
            expected = 45;
            yield return new object[] { actualList, expected };


            actualList = new LinkedList(new int[] { 121, 2, 3, 45, 5, 6, 7 });
            expected = 121;
            yield return new object[] { actualList, expected };
        }
    }
}
