namespace Calculator.Tests;

public class Tests
{
    [Test]
    [TestCase(2, 3, 5)]
    public void AddNumbers_ShouldReturnCorrectSum(int number1, int number2, int expected)
    {
        int result = Calculate.AddNumbers(number1, number2);

        Assert.That(result, Is.EqualTo(expected));
    }
}
