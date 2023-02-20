using LeetCode.Strings;

namespace LeetCode.Tests.Strings;

public class MakeParenthesesValidTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(TestCaseSource))]
    public void Test(string s, int expected)
    {
        //Arrange
        var calculator = new MakeParenthesesValid();

        //Act
        var actual = calculator.MinAddToMakeValid(s);

        //Assert
        Assert.AreEqual(expected, actual);

    }

    private static IEnumerable<object> TestCaseSource()
    {
        yield return new object[] { "())", 1 };
        yield return new object[] { "(((", 3 };
        yield return new object[] { "())", 1 };
        yield return new object[] { ")))(", 4 };
    }
}