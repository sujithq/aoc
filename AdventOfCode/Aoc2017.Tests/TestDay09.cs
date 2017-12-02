﻿using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]
    [Ignore("Inprogress")]

    public class TestDay09
    {
        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD09P1))]
        public int Part1(string input)
        {
            var target = new Day09();
            return target.Part1(input);
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD09P2))]
        public int Part2(string input)
        {
            var target = new Day09();
            return target.Part2(input);
        }
    }
}