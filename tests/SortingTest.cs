using Algorithms.Sorting;

namespace Sorting;

[TestClass]
public class BinarySearchTest
{
    [TestMethod]
    public void Test()
    {
        var arr = new int[] {0,1,2,3,4,5,6,7,8,9,10,11};

        int i = BinarySearch.IndexOf(arr, 0);
        Assert.AreEqual(i, 0);


        int j = BinarySearch.IndexOf(arr, 11);
        Assert.AreEqual(j, 11);


    }
}