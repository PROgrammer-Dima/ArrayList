using MyArrayLists;
using System.Collections;

namespace MyArrayList.Tests.ArrayListTestsSources
{
    internal class ReversArrayTestSource: IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList actualList = new ArrList(new int[] { 1, 22, 3, 4, 5, 6, 7 });
            ArrList expectedList = new ArrList(new int[] {7,6,5,4,3,22,1 });
            yield return new object[] { actualList, expectedList };

            actualList = new ArrList(new int[] { 12,5,76,3,67,0,6,3 });
            expectedList = new ArrList(new int[] {3,6,0,67,3,76,5,12 });
            yield return new object[] { actualList, expectedList };

            actualList = new ArrList(new int[] { 0,0,1,0,0 });
            expectedList = new ArrList(new int[] { 0, 0, 1, 0, 0 });
            yield return new object[] { actualList, expectedList };

            actualList = new ArrList(new int[] { 0, 1, 0, 0, 0 });
            expectedList = new ArrList(new int[] { 0, 0, 0, 1, 0 });
            yield return new object[] { actualList, expectedList };
        }
    }
}
