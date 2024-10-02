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

    [TestCase(1)]
    [TestCase(2)]
    [TestCase(3)]
    public void Rem_MustReturnZero(int value)
    {
        Calculator c = new Calculator();
        var result = c.Rem(12, value);

        Assert.That(0, Is.EqualTo(result.b));
    }

    [Test]
    public void Sub_MustReturnCorrectAnswer()
    {
        Calculator c = new Calculator();
        var result = c.Sub(20, 10);

        Assert.That(10, Is.EqualTo(result));
    }

    [Test]
    public void Div_MustReturnCorrectAnswer()
    {
        Calculator c = new Calculator();
        var result = c.Div(100, 10);

        Assert.That(10, Is.EqualTo(result));
    }

    [Test]
    public void Mult_MustReturnCorrectAnswer()
    {
        Calculator c = new Calculator();
        var result = c.Mult(5, 2);

        Assert.That(10, Is.EqualTo(result));
    }
}
