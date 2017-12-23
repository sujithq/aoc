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

                    var l = new List<string>();

                    for (var j = 0; j < d; j++)
                    {
                        l.Add(str.Substring(j * d, d));
                    }
                    return RawRules[string.Join("/", l)].Replace("/", "").ToList();
                }).ToList();

                var x = new List<List<List<char>>>();
                //var x = new List<List<List<char>>>(Enumerable.Repeat(Enumerable.Repeat(Enumerable.Repeat(' ', d + 1).ToList(), d + 1).ToList(), t.Count));

                for (int l = 0; l < t.Count; l++)
                {
                    x.Add(new List<List<char>>());
                    for (int j = 0; j < d + 1; j++)
                    {
                        x[l].Add(new List<char>());
                        for (int k = 0; k < d + 1; k++)
                        {
                            x[l][j].Add(default(char));
                        }

                    }

                }

                for (var j = 0; j < x.Count; j++)
                {
                    var str = new string(t[j].ToArray()).ToList();

                    var dd = (int) Math.Sqrt(t[j].Count);

                    //for (int k = 0; k < str.Count; k++)
                    //{
                    //    int row = k / (dd);
                    //    int col = k % (dd);

                    //    x[j][row][col] = str[k];
                    //}

                    for (var k = 0; k < dd; k++)
                    {
                        for (var l = 0; l < dd; l++)
                        {
                            var index = k * dd + l;
                            x[j][k][l] = str[index];
                        }
                    }
                }

                startSpan = Combine(x, d + 1, (int)Math.Sqrt(x.Sum(s => s.Sum(ss => ss.Count))) );


                Console.WriteLine();
            }
            return startSpan.Count(c=>c=='#');
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

        private static List<T> Combine<T>(List<List<List<T>>> l, int d, int n)
        {
            var res = Enumerable.Repeat(default(T), n * n).ToList();

            var nsl = (int)Math.Sqrt(l.Count);

            for (var r = 0; r < nsl; r++)
            {
                for (var c = 0; c < nsl; c++)
                {
                    var i = r * nsl + c;

                    for (var rr = 0; rr < d; rr++)
                    {
                        for (var cc = 0; cc < d; cc++)
                        {
                            res[(r * d + rr) * n + d * c + cc] = l[i][rr][cc];
                        }
                    }
                }
            }
            return res;
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