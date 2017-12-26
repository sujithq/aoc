using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]


    public class TestDay25
    {
        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD25P1))]
        public int Part1(string input, int checkSumAfterSteps)
        {
            var target = new Day25(input);
            for (var i = 0; i < checkSumAfterSteps; i++)
            {
                //if (i % 10000 == 0)
                //    TestContext.Progress.WriteLine($"Step {i + 1}");
                target.Step();
            }
            return target.CheckSum;
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Ignore("Inprogress")]
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD25P2))]
        public int Part2(string input, int checkSumAfterSteps)
        {
            var target = new Day25(input);
            for (var i = 0; i < checkSumAfterSteps; i++)
            {
                target.Step();
            }
            return target.CheckSum;
        }
    }
}