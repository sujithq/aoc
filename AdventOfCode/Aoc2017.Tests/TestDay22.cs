using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]


    public class TestDay22
    {
        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD22P1))]
        public long Part1(string input, int bursts)
        {
            var sot = new Day22(input);
            for (var i = 0; i < bursts; i++)
            {
                sot.Burst();
                TestContext.Progress.WriteLine($"Burst {i + 1}  => {sot.Infected}");
            }
            return sot.Infected;
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD22P2))]
        public long Part2(string input, int bursts)
        {
            var sot = new Day22Modified(input);
            for (var i = 0; i < bursts; i++)
            {
                sot.Burst();
                if (i % 10000 == 0)
                    TestContext.Progress.WriteLine($"Burst {i + 1}  => {sot.Infected}");
            }
            return sot.Infected;
        }
    }
}