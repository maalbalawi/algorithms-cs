namespace Sorting;

[TestClass]
public class InsertSortTest
{
    [TestMethod]
    public void AlreadySorted()
    {
        var arr = new int[] {4,5, 0, 3, 8, 92, 45};

        int[] copy = new int[arr.Length];
        arr.CopyTo(copy, 0);

        Array.Sort(arr);
       Sorting.InsertSort.Sort(copy);

       for (int i =0; i < arr.Length; i++) 
            Assert.AreEqual(arr[i] , copy[i]);

    }
}