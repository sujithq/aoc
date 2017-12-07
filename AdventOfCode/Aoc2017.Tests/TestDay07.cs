using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]
    

    public class TestDay07:IDay<string>
    {
        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD07P1))]
        public string Part1(string input)
        {
            var target = new Day07();
            return target.Part1(input);
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD07P2))]
        public string Part2(string input)
        {
            var target = new Day07();
            return target.Part2(input);
        }
    }
}