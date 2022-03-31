using MyArrayLists;
using System.Collections;

namespace MyArrayList.Tests.ArrayListTestsSources
{
    public class DeletingByIndexNelementsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList actualList = new ArrList(new int[] { 1, 2, 3, 4, 5 ,6,7});
            ArrList expectedList = new ArrList(new int[] { 1, 5,6,7 });
            int index = 1;
            int count = 3;
            yield return new object[] { actualList, expectedList, index, count };

            actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            expectedList = new ArrList(new int[] { 1,2, 7 });
            index = 2;
            count = 4;
            yield return new object[] { actualList, expectedList, index, count };
        }
    }
}
