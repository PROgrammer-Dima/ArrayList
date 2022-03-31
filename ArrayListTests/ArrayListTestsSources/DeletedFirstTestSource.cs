using MyArrayLists;
using System.Collections;

namespace MyArrayList.Tests.ArrayListTestsSources
{
    internal class DeletedFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList actualList = new ArrList(new int[] { 1, 2, 3, 4, 5 });
            ArrList expectedList = new ArrList(new int[] { 2, 3, 4, 5 });
            yield return new object[] { actualList, expectedList };

            actualList = new ArrList(new int[] { 0,1, 2, 3, 4, 5 });
            expectedList = new ArrList(new int[] { 1,2, 3, 4, 5 });
            yield return new object[] { actualList, expectedList };

            actualList = new ArrList(new int[] { -90,1, 2, 3, 4, 5 });
            expectedList = new ArrList(new int[] {1, 2, 3, 4, 5 });
            yield return new object[] { actualList, expectedList };
        }
    }
}
