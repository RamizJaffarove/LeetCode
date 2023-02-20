namespace LeetCode.Tests.Strings;

public class BankLaserBeamsTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(TestCaseSource))]
    public void Test(string[] bank, int expected)
    {
        //Arrange
        var calculator = new BankLaserBeams();

        //Act
        int actual = calculator.NumberOfBeams(bank);

        //Assert
        That(actual, EqualTo(expected));
    }

    private static IEnumerable<object> TestCaseSource()
    {
        yield return new object[] { new[] { "011001", "000000", "010100", "001000" }, 8 };
        yield return new object[] { new[] { "000", "111", "000" }, 0 };
    }
}