using MyArrayLists;
using System.Collections;

namespace MyArrayList.Tests.ArrayListTestsSources
{
    internal class FindIndexOfMinValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6, 7, 0 });
            int expected = 7;
            yield return new object[] { actualList, expected };

            actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6, 7, 10 });
            expected = 0;
            yield return new object[] { actualList, expected };

            actualList = new ArrList(new int[] { 1, 2, 3, 4, 0, 5, 6, 7, 10 });
            expected = 4;
            yield return new object[] { actualList, expected };
        }
    }
}
