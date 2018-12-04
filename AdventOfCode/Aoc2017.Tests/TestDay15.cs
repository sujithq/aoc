using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]
    

    public class TestDay15
    {
        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD15P1))]
        public int Part1(string input, int count)
        {
            var target = new Day15();
            return target.Part1(input, count);
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD15P2))]
        public int Part2(string input, int count)
        {
            var target = new Day15();
            return target.Part2(input, count);
        }
    }
}