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
                prevs[0] = (prevs[0] * factors[0]) % int.MaxValue;
                prevs[1] = (prevs[1] * factors[1]) % int.MaxValue;


                if (new string(prevs[0].GetIntBinaryString().Slice(16).ToArray()) == new string(prevs[1].GetIntBinaryString().Slice(16).ToArray()))
                    counter++;
            }

            return counter;
        }



        public int Part2(string input, int count)
        {
            if (input.IsNullOrEmpty())
                return int.MinValue;

            var factors = new[] { 16807, 48271 };
            var prevs = input.Split(',').Select(long.Parse).ToList();

            var counter = 0;
            for (int i = 0; i < count; i++)
            {

                while (true)
                {
                    prevs[0] = (prevs[0] * factors[0]) % int.MaxValue;
                    if(prevs[0]%4==0)
                        break;
                }
                while (true)
                {
                    prevs[1] = (prevs[1] * factors[1]) % int.MaxValue;
                    if (prevs[1] % 8 == 0)
                        break;

                }

                if (new string(prevs[0].GetIntBinaryString().Slice(16).ToArray()) == new string(prevs[1].GetIntBinaryString().Slice(16).ToArray()))
                    counter++;
            }

            return counter;
        }
    }
}