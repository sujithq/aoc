using System;
using NUnit.Framework;

namespace Aoc2017.Tests
{
    [TestFixture]


    public class TestDay16
    {

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.DanceSpin))]
        public string Spin(ReadOnlySpan<char> input, string baseLine)
        {
            var target = new Dance(baseLine);
            if (input.Length > 0)
                target.Spin(input.Slice(1));
            else
            {
                target.Spin(input);
            }
            return target.Result();
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.DanceExchange))]
        public string Exchange(ReadOnlySpan<char> input, string baseLine)
        {
            var target = new Dance(baseLine);
            if (input.Length > 0)
                target.Exchange(input.Slice(1));
            else
            {
                target.Exchange(input);
            }
            return target.Result();
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.DancePartner))]
        public string Partner(ReadOnlySpan<char> input, string baseLine)
        {
            var target = new Dance(baseLine);
            if (input.Length > 0)
                target.Partner(input.Slice(1));
            else
            {
                target.Partner(input);
            }
            return target.Result();
        }



        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD16P1))]
        public string Part1(string input, string baseLine)
        {
            var target = new Day16();
            return target.Part1(input, baseLine);
        }

        /// <summary>Test stub for Execute(String)</summary>
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.TcD16P2))]
        public string Part2(string input, string baseLine, int count)
        {
            var target = new Day16();
            return target.Part2(input, baseLine, count);
        }
    }
}