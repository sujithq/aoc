using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]
    public class TestDay03
    {
        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD03P1))]
        public int Part1(string input)
        {
            var target = new Day03();
            return target.Part1(input);
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD03P2))]
        public int Part2(string input)
        {
            var target = new Day03();
            return target.Part2(input);
        }
    }
}
