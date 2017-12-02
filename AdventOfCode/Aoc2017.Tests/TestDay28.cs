using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]
    public class TestDay28
    {
        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD28P1))]
        public int Part1(string input)
        {
            var target = new Day28();
            return target.Part1(input);
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD28P2))]
        public int Part2(string input)
        {
            var target = new Day28();
            return target.Part2(input);
        }
    }
}