﻿using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]
    

    public class TestDay24
    {
        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD24P1))]
        public int Part1(string input)
        {
            var target = new Day24(input, TestContext.Progress);
            return target.Part1();
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Ignore("Inprogress")]
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD24P2))]
        public int Part2(string input)
        {
            var target = new Day24(input, TestContext.Progress);
            return target.Part2(input);
        }
    }
}