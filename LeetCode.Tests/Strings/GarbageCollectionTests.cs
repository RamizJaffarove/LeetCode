using LeetCode.Strings;

namespace LeetCode.Tests.Strings;

public class GarbageCollectionTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(TestCaseSource))]
    public void Test(string[] garbages, int[] travel, int expected)
    {
        //Arrange
        var collection = new GarbageCollection();

        //Act
        int actual = collection.MinTimeToCollect(garbages, travel);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    private static IEnumerable<object> TestCaseSource()
    {
        yield return new object[] { new[] { "G", "P", "GP", "GG" }, new[] { 2, 4, 3 }, 21 };
        yield return new object[] { new[] { "MMM", "PGM", "GP" }, new[] { 3, 10 }, 37 };
    }
}