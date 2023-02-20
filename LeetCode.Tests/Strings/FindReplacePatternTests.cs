using LeetCode.Strings;

namespace LeetCode.Tests.Strings;

public class FindReplacePatternTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(TestCaseSource))]
    public void Test(string[] words, string pattern, IList<string> expected)
    {
        //Arrange
        var calculator = new FindReplacePattern();

        //Act
        IList<string> actual = calculator.FindAndReplace(words, pattern);

        //Assert
        CollectionAssert.AreEqual(expected, actual);

    }

    private static IEnumerable<object> TestCaseSource()
    {
        yield return new object[] { new[] {"ccc" }, "abb", new List<string>() };
        yield return new object[] { new[] { "abc", "deq", "mee", "aqq", "dkd", "ccc" }, "abb", new[] { "mee", "aqq" } };
        yield return new object[] { new[] { "a", "b", "c" }, "a", new[] { "a", "b", "c" } };
    }
}