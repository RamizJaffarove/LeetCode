namespace LeetCode.Tests.Strings;

public class StringAnagramTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(TestCaseSource))]
    public void Test(string s, string t, int expected)
    {
        //Arrange
        var calculator = new StringAnagram();

        //Act
        var actual = calculator.MinSteps(s, t);

        //Assert
        That(actual, EqualTo(expected));

    }

    private static IEnumerable<object> TestCaseSource()
    {
        yield return new object[] { "bab", "aba", 1 };
        yield return new object[] { "leetcode", "practice", 5 };
        yield return new object[] { "anagram", "mangaar", 0 };
    }
}