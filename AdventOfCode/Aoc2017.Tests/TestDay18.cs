using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]
    

    public class TestDay18
    {
        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD18P1))]
        public long Part1(string input)
        {
            var target = new Day18();
            return target.Part1(input);
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Ignore("Inprogress")]
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD18P2))]
        public int Part2(string input)
        {
            var target = new Day18();
            return target.Part2(input);
        }
    }
}