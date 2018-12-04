using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]
    
    public class TestDay23
    {
        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD23P1))]
        public long Part1(string input)
        {
            var target = new Day23(input);

            while (target.Burst())
            {
                
            }
            return target.Muls;
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD23P2))]
        public long Part2(string input)
        {
            var target = new Day23(input, 1);

            while (target.Burst())
            {

            }
            return target.Register['h'];
        }
    }
}