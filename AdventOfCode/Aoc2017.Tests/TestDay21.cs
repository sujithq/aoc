using Aoc2017.Helpers;
using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]


    public class TestDay21
    {
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TestRotate2))]
        public string Rotate2(string input)
        {
            return input.Rotate2();
        }
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TestRotate3))]
        public string Rotate3(string input)
        {
            return input.Rotate3();
        }



        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD21P1))]
        public int Part1(string input, int iterarions)
        {
            var target = new Day21();
            return target.Part1(input, iterarions);
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Ignore("Inprogress")]
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD21P2))]
        public int Part2(string input)
        {
            var target = new Day21();
            return target.Part2(input);
        }
    }
}