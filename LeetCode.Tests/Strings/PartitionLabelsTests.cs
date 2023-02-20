using LeetCode.Strings;

namespace LeetCode.Tests.Strings;

public class PartitionLabelsTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(TestCaseSource))]
    public void Test(string s, IList<int> expected)
    {
        //Arrange
        var calculator = new PartitionLabels();

        //Act
        IList<int> actual = calculator.Calculate(s);

        //Assert
        CollectionAssert.AreEqual(expected, actual);

    }

    private static IEnumerable<object> TestCaseSource()
    {
        yield return new object[] { "aacc", new[] { 2, 2 } };
        yield return new object[] { "abacdc", new[] { 3, 3 } };
        yield return new object[] { "ababcbacadefegdehijhklij", new[] { 9, 7, 8 } };
        yield return new object[] { "eccbbbbdec", new[] { 10 } };
    }
}