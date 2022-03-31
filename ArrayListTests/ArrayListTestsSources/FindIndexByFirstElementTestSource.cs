using MyArrayLists;
using System.Collections;

namespace MyArrayList.Tests.ArrayListTestsSources
{
    internal class FindIndexByFirstElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            int expectedIndex = 4;
            int value = 5;
            yield return new object[] { actualList, expectedIndex, value };

            actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            expectedIndex = 6;
            value = 7;
            yield return new object[] { actualList, expectedIndex, value };

            actualList = new ArrList(new int[] {0, 1, 2, 3, 4, 5, 6, 7 });
            expectedIndex = 0;
            value = 0;
            yield return new object[] { actualList, expectedIndex, value };
        }
    }
}
