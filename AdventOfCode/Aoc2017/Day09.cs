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

            var chars = input.ToList().Distinct();

            var removals = chars.Select(s => new string(new[] {'!', s}));

            var clean = input.Clean();
            //string clean = input;

            //foreach (var removal in removals)
            //{
            //    clean = clean.Replace(removal, "!");
            //}

            var garbage = clean.Garbage();

            clean 
                = garbage
                .Aggregate(clean, (current, g) => current.ReplaceFirstOccurrence(g, string.Empty))
                .Replace("{,}", "{}")
                .Replace("{,{", "{{")
                .Replace("},}", "}}")
                .Replace("{", "(")
                .Replace("}", ")");

            return clean.Score(1);

            //15559
            //17254
        }

        public int Part2(string input)
        {
            return int.MinValue;
        }
    }
}