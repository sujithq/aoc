using System.Collections.Generic;
using System.Linq;
using Aoc2017.Helpers;
using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]
    [Ignore("Inprogress")]

    public class TestDay31
    {
        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD31P1))]
        public int Part1(string input)
        {
            var target = new Day31();
            return target.Part1(input);
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD31P2))]
        public int Part2(string input)
        {
            var target = new Day31();
            return target.Part2(input);
        }
    }
    [TestFixture]
    public class TestStringHelper
    {
        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.StringHelperClean))]
        public string Clean(string input, char escape = '!')
        {
            return input.Clean(escape);
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.StringHelperGarbage))]
        public IEnumerable<string> Garbage(string input, char start = '<', char end = '>')
        {
            return input.Garbage(start, end);
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.StringHelperScore))]
        public int Score(string input, int level)
        {
            var clean = input.Clean();
            var garbage = clean.Garbage();
            clean = garbage.Aggregate(clean, (current, g) => current.ReplaceFirstOccurrence(g, "<>")).Replace("{", "(").Replace("}", ")");
            return clean.Score(level);
        }


    }
}