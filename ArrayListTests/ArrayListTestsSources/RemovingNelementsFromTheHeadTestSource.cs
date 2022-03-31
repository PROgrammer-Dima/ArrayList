using System.Collections;
using MyArrayLists;


namespace MyArrayList.Tests.ArrayListTestsSources
{
    internal class RemovingNelementsFromTheHeadTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            ArrList expectedList = new ArrList(new int[] { 4,5,6,7 });
            int num = 3;
            yield return new object[] { actualList, expectedList, num };


            actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            expectedList = new ArrList(new int[] { 6, 7 });
            num = 5;
            yield return new object[] { actualList, expectedList, num };

            actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            expectedList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            num = 0;
            yield return new object[] { actualList, expectedList, num };

        }
    }
}
