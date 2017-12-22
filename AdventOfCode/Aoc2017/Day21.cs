using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Aoc2017.Helpers;

namespace Aoc2017
{
    public class FractalArt
    {
        private const string Start = @".#...####";
        public Dictionary<string, string> RawRules { get; set; }
        public FractalArt(string input)
        {
            var lines = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Select(s => s.Split(new[] { " => " }, StringSplitOptions.None));

            RawRules = lines.ToDictionary(k => k[0], v => v[1]);
            var additionalRules = new Dictionary<string, string>();

            foreach (var rawRule in RawRules)
            {
                var ps = rawRule.Key.Split('/');

                var variants = new HashSet<string>();
                var @join = string.Join("", ps);


                for (var i = 0; i < (ps.Length == 2 ? 3 : 9); i++)
                {
                    @join = ps.Length == 2 ? @join.Rotate2() : @join.Rotate3();

                    var l = ps.Select((t, j) => @join.Skip(j * ps.Length).Take(ps.Length)).Select(x => new string(x.ToArray())).ToList();


                    var item = string.Join("/", l);
                    if (!RawRules.ContainsKey(item))
                        variants.Add(item);
                }

                foreach (var variant in variants)
                {
                    additionalRules.Add(variant, rawRule.Value);
                }

            }

            RawRules = RawRules.Concat(additionalRules).ToDictionary(k => k.Key, v => v.Value);
        }

        public int Iterate(int iterations)
        {
            var lights = 0;

            var startSpan = Start.ToList();


            for (var i = 0; i < iterations; i++)
            {
                var d = startSpan.Count % 2 == 0 ? 2 : 3;

                var splitted = Split(startSpan).ToList();

                var t = splitted.Select(s =>
                {
                    var str = new string(s.ToArray());

                    List<string> l = new List<string>();

                    for (int j = 0; j < d; j++)
                    {
                        l.Add(str.Substring(j * d, d));
                    }
                    return RawRules[string.Join("/", l)].Replace("/", "").ToList();
                }).ToList();

                var x = new List<List<List<char>>>(Enumerable.Repeat(Enumerable.Repeat(Enumerable.Repeat(' ', d + 1).ToList(), d + 1).ToList(), t.Count));

                for (int j = 0; j < x.Count; j++)
                {
                    var str = new string(t[j].ToArray()).ToList();

                    for (int k = 0; k < str.Count; k++)
                    {
                        int row = k / (d + 1);
                        int col = k % (d + 1);

                        x[j][row][col] = str[k];
                    }
                }


                Console.WriteLine();
            }
            return lights;
        }

        private static IEnumerable<List<T>> Split<T>(List<T> l)
        {
            var d = l.Count % 2 == 0 ? 2 : 3;
            var d2 = d * d;

            if (l.Count == d2)
                return new List<List<T>> { l };

            var n = (int)Math.Sqrt(l.Count);

            var ll = new List<List<T>>();

            var numOfSubLists = l.Count / d2;
            for (var i = 0; i < numOfSubLists; i++)
            {
                ll.Add(Enumerable.Repeat(default(T), d2).ToList());
            }

            var nsl = (int)Math.Sqrt(numOfSubLists);

            for (var r = 0; r < nsl; r++)
            {
                for (var c = 0; c < nsl; c++)
                {
                    var i = r * nsl + c;

                    for (var rr = 0; rr < d; rr++)
                    {
                        for (var cc = 0; cc < d; cc++)
                        {
                            ll[i][rr * d + cc] = l[(r * d + rr) * n + d * c + cc];
                        }
                    }
                }
            }
            return ll;
        }


    }

    public class Day21
    {
        public int Part1(string input, int iterations)
        {

            var sot = new FractalArt(input);

            return sot.Iterate(iterations);
        }

        public int Part2(string input)
        {
            return int.MinValue;
        }
    }
}