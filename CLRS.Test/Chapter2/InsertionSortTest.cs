using CLRS.Chapter2;
using NUnit.Framework;

namespace CLRS.Test.Chapter2;

public class InsertionSortTest
{
    [Test]
    public void Should_Sort()
    {
        int[] input = { 5, 2, 4, 6, 1, 3 };
        int[] expected = { 1, 2, 3, 4, 5, 6 };

        InsertionSort.Sort(input);

        CollectionAssert.AreEqual(expected, input);
    }
}