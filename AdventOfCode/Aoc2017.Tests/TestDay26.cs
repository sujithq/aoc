﻿using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]
    

    public class TestDay26
    {
        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD26P1))]
        public int Part1(string input)
        {
            var target = new Day26();
            return target.Part1(input);
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD26P2))]
        [Ignore("Not Applicable")]
        public int Part2(string input)
        {
            var target = new Day26();
            return target.Part2(input);
        }
    }
}