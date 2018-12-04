using System;
using System.Linq;
using Aoc2017.Helpers;

namespace Aoc2017
{
    public class Day09 : IDay<int>
    {
        public int Part1(string input)
        {
            if (input.IsNullOrEmpty())
                return int.MinValue;

            var span = input.AsSpan();

            var isGarbage = false;
            var level = 0;
            var sum = 0;
            for (var i = 0; i < span.Length; i++)
            {
                switch (span[i])
                {
                    case '{':
                        if (!isGarbage)
                            ++level;
                        continue;
                    case '}':
                        if (!isGarbage)
                            sum += level--;
                        continue;
                    case '<':
                        isGarbage = true;
                        continue;
                    case '>':
                        isGarbage = false;
                        continue;
                    case '!':
                        ++i;
                        continue;
                    default:
                        continue;
                }
            }

            return sum;
        }

        public int Part2(string input)
        {
            if (input.IsNullOrEmpty())
                return int.MinValue;

            //var g = input.Clean().Garbage().ToList();

            //return g.Select(s => s.Replace("!", "")).Select(ss => ss.Substring(1, ss.Length - 2)).Sum(s => s.Length);

            var span = input.AsSpan();

            var isGarbage = false;
            var numOfGarbageCharacters = 0;
            for (var i = 0; i < span.Length; i++)
            {
                switch (span[i])
                {
                    case '{':
                        if (isGarbage)
                            ++numOfGarbageCharacters;
                        break;
                    case '}':
                        if (isGarbage)
                            ++numOfGarbageCharacters;
                        break;
                    case '<':
                        if (isGarbage)
                            ++numOfGarbageCharacters;
                        isGarbage = true;
                        break;
                    case '>':
                        isGarbage = false;
                        break;
                    case '!':
                        ++i;
                        break;
                    default:
                        if (isGarbage)
                            ++numOfGarbageCharacters;
                        break;
                }
            }

            return numOfGarbageCharacters;
        }
    }
}