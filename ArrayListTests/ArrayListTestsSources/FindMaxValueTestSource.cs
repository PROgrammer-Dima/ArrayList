using MyArrayLists;
using System.Collections;

namespace MyArrayList.Tests.ArrayListTestsSources
{
    internal class FindMaxValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrList actualList = new ArrList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            int expected = 7;
            yield return new object[] { actualList, expected };


            actualList = new ArrList(new int[] { 1, 2, 3, 45, 5, 6, 7 ,0});
            expected = 45;
            yield return new object[] { actualList, expected };


            actualList = new ArrList(new int[] { 121, 2, 3, 45, 5, 6, 7 });
            expected = 121;
            yield return new object[] { actualList, expected };
        }
    }
}
