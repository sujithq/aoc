using System;
using System.Linq;

namespace Aoc2017
{
    public class Day02 : IDay
    {
        public int Part1(string input)
        {
            var res = 0;
            if (string.IsNullOrEmpty(input))
                return res;
            //Split Into Lines
            var lines = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            //Process Each Line
            foreach (var line in lines)
            {
                //Convert Line Into Array
                var c = line.Split(null).Select(int.Parse).ToArray();

                //Sort Array To Take Easily The First And Last Item
                Array.Sort(c);

                var last = c.Last();
                var first = c.First();

                //Add To Result
                res += last - first;

            }

            return res;
        }

        public int Part2(string input)
        {
            var res = 0;
            if (string.IsNullOrEmpty(input))
                return res;
            //Split Into Lines
            var lines = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            //Process Each Line
            foreach (var line in lines)
            {
                //Split Into Array
                var c = line.Split(null).Select(int.Parse).ToArray();

                //Get Combinations
                var ks = MathHelper.GetKCombs(c, 2);

                //Sort Combinations
                var kst = ks.Select(s =>
                {
                    var arr = s.ToArray();
                    Array.Sort(arr);
                    Array.Reverse(arr);
                    return arr;
                }).ToList();

                //Get First Item Where Remainder Is Zero
                var item = kst.First(w => w.First() % w.Last() == 0);

                res += item.First() / item.Last();
            }
            return res;
        }
    }
}