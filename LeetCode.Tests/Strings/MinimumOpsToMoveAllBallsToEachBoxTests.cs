using LeetCode.Strings;

namespace LeetCode.Tests.Strings;

public class MinimumOpsToMoveAllBallsToEachBoxTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(TestCaseSource))]
    public void Test(string boxes, int[] expected)
    {
        //Arrange
        var calculator = new MinimumOpsToMoveAllBallsToEachBox();

        //Act
        int[] actual = calculator.MinOperations(boxes);

        //Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    private static IEnumerable<object> TestCaseSource()
    {
        yield return new object[] { "110", new[]{1,1,3} };
        yield return new object[] { "001011", new[] { 11, 8, 5, 4, 3, 4 } };
    }
}