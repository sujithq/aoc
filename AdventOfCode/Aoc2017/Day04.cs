using System;
using System.Collections.Generic;
using System.Linq;
using Aoc2017.Helpers;

namespace Aoc2017
{
    public class Day04 : IDay
    {
        const char separator = ' ';

        public int Part1(string input)
        {
            var res = -1;
            if (input.IsNullOrEmpty())
                return res;

            var lines = input.Split(new [] {Environment.NewLine}, StringSplitOptions.None);

            var splitted = lines.Select(s => new {Line = s, Split = s.Split(separator)});
            var groups = splitted.Select(s => new {s.Line, Group = s.Split.GroupBy(g => g)});


            return groups.Count(g=>g.Line.Split(separator).Length == g.Group.Count());
        }

        public int Part2(string input)
        {
            var res = -1;
            if (input.IsNullOrEmpty())
                return res;

            var lines = input.Split(new [] { Environment.NewLine }, StringSplitOptions.None);

            var splitted = lines.Select(s => new { Split = s.Split(separator) });

            var combine = splitted.Select(s => new {Combinations = new Combinations<string>(s.Split, 2).ToList()});

            var an = combine.Select(s => new {HasAnaGram = s.Combinations.Any(IsAnaGram)});

            return an.Count(c=>!c.HasAnaGram);
        }

        private static bool IsAnaGram(IList<string> list)
        {
            var f = list.First().ToArray();
            var l = list.Last().ToArray();

            Array.Sort(f);
            Array.Sort(l);

            return new string(f).Equals(new string(l));

        }
    }
}