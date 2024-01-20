using CLRS.Misc;
using NUnit.Framework;

namespace CLRS.Test.Misc;

public class EuclidsAlgorithmTest
{
    [Test]
    public void Test()
    {
        const int expectedGcd = 31;
        
        var gcd = EuclidsAlgorithm.GCD(1147, 899);
        
        Assert.That(gcd, Is.EqualTo(expectedGcd));
    }
}