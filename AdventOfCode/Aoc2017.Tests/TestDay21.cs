using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]
    public class TestDay21
    {
        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD21P1))]
        public int Part1(string input)
        {
            var target = new Day21();
            return target.Part1(input);
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD21P2))]
        public int Part2(string input)
        {
            var target = new Day21();
            return target.Part2(input);
        }
    }
}