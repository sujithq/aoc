using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aoc2017.Helpers;

namespace Aoc2017
{
    public class Day15
    {
        public int Part1(string input, int count)
        {
            if (input.IsNullOrEmpty())
                return int.MinValue;

            var factors = new[] { 16807, 48271 };
            var prevs = input.Split(',').Select(long.Parse).ToList();

            var counter = 0;

            for (int i = 0; i < count; i++)
            {
                prevs[0] = (prevs[0] * factors[0])% int.MaxValue;
                prevs[1] = (prevs[1] * factors[1])% int.MaxValue;


                if(prevs[0].GetIntBinaryString().Substring(16) == prevs[1].GetIntBinaryString().Substring(16))
                    counter++;
            }

            return counter;
        }

        

        public int Part2(string input)
        {
            return int.MinValue;
        }
    }
}