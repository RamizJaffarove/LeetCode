using LeetCode.Strings;

namespace LeetCode.Tests.Strings;

public class GridSuffixInstructionsTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(TestCaseSource))]
    public void Test(int n, int[] startPos, string s, int[] expected)
    {
        //Arrange
        var collection = new GridSuffixInstructions();

        //Act
        var actual = collection.Execute(n, startPos, s);

        //Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    private static IEnumerable<object> TestCaseSource()
    {
        yield return new object[] { 3, new[]{0,1}, "RRDDLU", new[]{ 1, 5, 4, 3, 1, 0} };
        yield return new object[] { 2, new[] { 1, 1 }, "LURD", new[] { 4, 1, 0, 0 } };
    }
}