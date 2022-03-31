using MyArrayList.Tests.ArrayListTestsSources;
using MyArrayLists;
using NUnit.Framework;
using System;

namespace MyArrayList.Tests
{
    public class ArrayListNegativeTests
    {
        [Test]
        public void DeletedEndTest_WhenListEmpty_ShouldThrowException()
        {
            ArrList arrayList = new ArrList();
            Assert.Throws<Exception>(() => arrayList.DeletedEnd());
        }

    }
}
