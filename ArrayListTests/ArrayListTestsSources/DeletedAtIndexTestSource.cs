using MyArrayLists;
using System.Collections;

namespace MyArrayList.Tests.ArrayListTestsSources
{
    public class DeletedAtIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList actualList = new ArrList(new int[] { 1, 2, 3, 4, 5 });
            ArrList expectedList = new ArrList(new int[] {1, 2, 3, 5 });
            int index = 3;
            yield return new object[] { actualList, expectedList, index };

            actualList = new ArrList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ArrList(new int[] { 2, 3,4, 5 });
            index = 0;
            yield return new object[] { actualList, expectedList, index };

            actualList = new ArrList(new int[] { -1, 0, 3, 446, 57,98,3,0 });
            expectedList = new ArrList(new int[] { -1, 0, 3, 446, 57, 98, 3 });
            index = 7;
            yield return new object[] { actualList, expectedList, index };
        }
    }
}
