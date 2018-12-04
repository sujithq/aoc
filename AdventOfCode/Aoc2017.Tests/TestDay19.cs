using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]
    

    public class TestDay19
    {
        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD19P1))]
        public string Part1(string input)
        {
            var target = new Day19(input);
            return target.Part1();
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD19P2))]
        public int Part2(string input)
        {
            var target = new Day19(input);
            return target.Part2();
        }
    }
}