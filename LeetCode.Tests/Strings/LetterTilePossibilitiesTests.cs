namespace LeetCode.Tests.Strings;

public class LetterTilePossibilitiesTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(TestCaseSource))]
    public void Test(string tiles, int expected)
    {
        //Arrange
        var calculator = new LetterTilePossibilities();

        //Act
        var actual = calculator.NumTilePossibilities(tiles);

        //Assert
        That(actual, EqualTo(expected));

    }

    private static IEnumerable<object> TestCaseSource()
    {
        yield return new object[] { "AAB", 8 };
        //yield return new object[] { "AAABBC", 188 };
        //yield return new object[] { "V", 1 };
    }
}