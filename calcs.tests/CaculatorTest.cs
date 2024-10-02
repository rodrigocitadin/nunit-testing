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
        //Verifica se o resultado é igual a 30
        Assert.That(30, Is.EqualTo(result));
    }
}
