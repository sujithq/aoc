﻿using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]
    [Ignore("Inprogress")]

    public class TestDay23
    {
        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD23P1))]
        public int Part1(string input)
        {
            var target = new Day23();
            return target.Part1(input);
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD23P2))]
        public int Part2(string input)
        {
            var target = new Day23();
            return target.Part2(input);
        }
    }
}