using System.Diagnostics;
using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]
    

    public class TestDay17
    {
        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD17P1))]
        public int Part1(int input, int count)
        {
            var target = new Day17();
            return target.Part1(input, count);
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD17P2))]
        public int Part2(int input, int count)
        {
            var spinLock = new SpinLock(input);

            var sw = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                sw.Restart();
                spinLock.MoveNext();
                sw.Stop();
                TestContext.Progress.WriteLine($"{count - i} - {sw.ElapsedMilliseconds}");
            }
            return spinLock.ValueAfter0;
        }
    }
}