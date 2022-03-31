using MyArrayLists;
using System.Collections;

namespace MyArrayList.Tests.ArrayListTestsSources
{
    internal class FindIndexOfMaxValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6, 7, 0 });
            int expected = 6;
            yield return new object[] { actualList, expected };

            actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6, 7, 90 });
            expected = 7;
            yield return new object[] { actualList, expected };

            actualList = new ArrList(new int[] {12, 1, 2, 3, 4, 5, 6, 7, 0 });
            expected = 0;
            yield return new object[] { actualList, expected };
        }
    }
}
