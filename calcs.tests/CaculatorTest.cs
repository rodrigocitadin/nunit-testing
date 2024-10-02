using NUnit.Framework;
using calcs;

namespace calcs.tests;

[TestFixture]
public class CalculatorTest
{
    [Test]
    public void Sum_MustReturnCorrectAnswer()
    {
        Calculator c = new Calculator();
        var result = c.Sum(10, 20);

        Assert.That(30, Is.EqualTo(result));
    }

    [Test]
    public void Rem_MustReturnCorrectAnswer()
    {
        Calculator c = new Calculator();
        var result = c.Rem(10, 3);

        Assert.Multiple(() =>
        {
            Assert.That(3, Is.EqualTo(result.a));
            Assert.That(1, Is.EqualTo(result.b));
        });
    }
}
