using CLRS.Chapter2;
using NUnit.Framework;

namespace CLRS.Test.Chapter2;

public class LinearSearchTest
{
    [Test]
    public void Should_Find()
    {
        int[] input = { 5, 2, 4, 6, 1, 3 };
        int x = 6;

        Assert.That(LinearSearch.Search(input, x), Is.EqualTo(x));
    }
    
    [Test]
    public void Should_Return_Null()
    {
        int[] input = { 5, 2, 4, 6, 1, 3 };
        int x = 7;

        Assert.That(LinearSearch.Search(input, x), Is.Null);
    }
}