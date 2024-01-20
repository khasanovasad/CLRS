using CLRS.Chapter2;
using NUnit.Framework;

namespace CLRS.Test.Chapter2;

public class BinarySearchTest
{
    [Test]
    public void Should_Find_Increasing()
    {
        int[] input = { 1, 2, 3, 4, 5, 6, 7 };
        int x = 6;

        Assert.That(BinarySearch.Search(input, x, 0, input.Length - 1), Is.EqualTo(5));
    }
    
    [Test]
    public void Should_Return_Null_Increasing()
    {
        int[] input = { 1, 2, 3, 4, 5, 6, 7 };
        int x = 11;

        Assert.That(BinarySearch.Search(input, x, 0, input.Length - 1), Is.Null);
    }
    
    [Test]
    public void Should_Find_Decreasing()
    {
        int[] input = { 1, 2, 3, 4, 5, 6, 7 };
        int x = 2;

        Assert.That(BinarySearch.Search(input, x, 0, input.Length - 1), Is.EqualTo(1));
    }
    
    [Test]
    public void Should_Return_Null_Decreasing()
    {
        int[] input = { 1, 2, 3, 4, 5, 6, 7 };
        int x = -11;

        Assert.That(BinarySearch.Search(input, x, 0, input.Length - 1), Is.Null);
    }
}