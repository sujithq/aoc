using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]


    public class TestDay20
    {
        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD20P1))]
        public long Part1(string input, int count)
        {
            var target = new Day20();
            var ps = target.Part1(input);

            var i = 0;
            while (true)
            {

                Parallel.ForEach(ps, a => a.Tick());

                var gr = ps.GroupBy(g => g.ManDistance).ToList();
                var min = gr.Min(m=>m.Key);

                if (gr.First(f => f.Key == min).Count() == 1 && i >= 5*count)
                {
                    TestContext.Progress.WriteLine($"Round {i} - ({min}, {gr.First(f => f.Key == min).Count()})");
                    return ps.First(f => f.ManDistance == min).Index;
                }

                var d = string.Join(",", gr.First(f => f.Key == min).Select(s => $"[{s.Index},{s.ManDistance}]"));
                TestContext.Progress.WriteLine($"Round {i} - ({min}, {gr.First(f => f.Key == min).Count()} ({d}))");

                i++;

            }

        }

        /// <summary>Test stub for Execute(String)</summary>
        [Ignore("Inprogress")]
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD20P2))]
        public int Part2(string input, int count)
        {
            var target = new Day20();
            return target.Part2(input, count);
        }
    }
}