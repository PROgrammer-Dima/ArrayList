using System.Collections;
using MyArrayLists;

namespace MyArrayList.Tests.ArrayListTestsSources
{
    public class AddTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6 });
            ArrList expectedList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            int num = 7;
            yield return new object[] { actualList, expectedList, num };

            actualList = new ArrList(new int[] { });
            expectedList = new ArrList(new int[] { 7 });
            num = 7;
            yield return new object[] { actualList, expectedList, num };

        }
    }
    
}
