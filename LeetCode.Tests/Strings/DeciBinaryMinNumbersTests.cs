using LeetCode.Strings;

namespace LeetCode.Tests.Strings;

public class DeciBinaryMinNumbersTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(TestCaseSource))]
    public void Test1(string str, int expected)
    {
        //Arrange
        var calculator = new DeciBinaryMinNumbers();

        //Act
        var actual = calculator.MinPartitions(str);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    private static IEnumerable<object> TestCaseSource()
    {
        yield return new object[] { "32", 3 };
        yield return new object[] { "82734", 8 };
        yield return new object[] { "27346209830709182346", 9 };
    }
}