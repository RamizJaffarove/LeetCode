using LeetCode.Strings;

namespace LeetCode.Tests.Strings
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(nameof(TestCaseSource))]
        public void Test(string[] strs, string expectedPrefix)
        {
            //Arrange
            var calculator = new LongestCommonPrefix();

            //Act
            var actualPrefix = calculator.Calculate(strs);

            //Assert
            Assert.That(actualPrefix, Is.EqualTo(expectedPrefix));
        }

        private static IEnumerable<object> TestCaseSource()
        {
            yield return new object[] { new[] { "dog", "racecar", "car" }, "" };
            yield return new object[] { new[] { "flower", "flow", "flight" }, "fl" };
            yield return new object[] { new[] { "car", "car", "car" }, "car" };
        }
    }
}