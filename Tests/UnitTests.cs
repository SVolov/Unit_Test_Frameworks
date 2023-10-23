using NUnit.Framework;
using TaskOne;
using Unit_Test_Frameworks;

namespace Tests
{
    public class UnitTests
    {
        [TestCase("1111", 0)]
        [TestCase("ваппвппп", 0)]
        [TestCase("dgkjdlfkg", 0)]
        [TestCase("   ", 0)]
        [TestCase("qqqwert12ывап", 3)]
        [TestCase("", 0)]
        [TestCase("<dfff>?/", 3)]
        [TestCase("AasdFgRt", 0)]


        public void CountEqualLatinLettersTest(string input, int expectedResult)
        {
            var actualResult = StringActions.CountEqualLatinLetters(input);
            Assert.AreEqual(expectedResult, actualResult, "Error: result is wrong");
        }

        [TestCase("1111", 0)]
        [TestCase("qqqqqqq", 0)]
        [TestCase("ппппппп", 0)]
        [TestCase("   ", 0)]
        [TestCase("", 0)]
        [TestCase("рпа123qwe", 9)]
        [TestCase("<df>?/", 6)]

        public void CountUnequalSymbolsTest(string input, int expectedResult)
        {
            var actualResult = StringActions.CountUnequalSymbols(input);
            Assert.AreEqual(expectedResult, actualResult, "Error: result is wrong");
        }

        [TestCase("123456", 0)]
        [TestCase("123dfg", 0)]
        [TestCase("ппппппп", 0)]
        [TestCase("123апрqwe", 0)]
        [TestCase("qwer11234", 2)]
        [TestCase("1111", 4)]
        [TestCase("   ", 0)]
        [TestCase("", 0)]
        [TestCase("<df>?/", 0)]

        public void CountEqualFiguresTest(string input, int expectedResult)
        {
            var actualResult = StringActions.CountEqualFigures(input);
            Assert.AreEqual(expectedResult, actualResult, "Error: result is wrong");
        }
    }
}