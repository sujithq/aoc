using System;
using System.Collections.Generic;
using System.Linq;
using Aoc2017.Helpers;

namespace Aoc2017
{
    public class FractalArt
    {
        private const string Start = @".#...####";
        private Dictionary<string, string> Rules { get; } = new Dictionary<string, string>();
        public FractalArt(string input)
        {
            var lines = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Select(s => s.Split(new[] { " => " }, StringSplitOptions.None));

            var rawRules = lines.ToDictionary(k => k[0], v => v[1]);

            foreach (var rawRule in rawRules)
            {
                var variants = Variant(rawRule.Key);

                foreach (var variant in variants)
                {
                    if (!Rules.ContainsKey(variant))
                        Rules.Add(variant, rawRule.Value);
                }
            }
        }

        private static IEnumerable<string> Variant(string key)
        {
            var splittedKey = key.Split('/');

            var variants = new HashSet<string> { key };
            var cleanKey = key.Replace("/", string.Empty);
            
            //Get Rotated Variants
            for (var i = 0; i < 3; i++)
            {
                cleanKey = splittedKey.Length == 2 ? cleanKey.Rotate2() : cleanKey.Rotate3().Rotate3();

                var l = splittedKey.Select((t, j) => cleanKey.Skip(j * splittedKey.Length).Take(splittedKey.Length)).Select(x => new string(x.ToArray())).ToList();

                var item = string.Join("/", l);
                variants.Add(item);
            }

            var xxx = key.ToList();
            if (splittedKey.Length == 2)
            {
                variants.Add(new string(xxx.Swap(0, 1).Swap(3, 4).ToArray()));
                variants.Add(new string(xxx.Swap(0, 3).Swap(1, 4).ToArray()));
            }
            else
            {
                variants.Add(new string(xxx.Swap(0, 8).Swap(1, 9).Swap(2, 10).ToArray()));
                variants.Add(new string(xxx.Swap(0, 2).Swap(4, 6).Swap(8, 10).ToArray()));
            }


            return variants;
        }
        
        public int Iterate(int iterations)
        {
            var startSpan = Start.ToList();

            for (var i = 0; i < iterations; i++)
            {
                var d = startSpan.Count % 2 == 0 ? 2 : 3;

                var splitted = startSpan.Split(d).ToList();

                var t = splitted.Select(s =>
                {
                    var str = new string(s.ToArray());

                    var l = new List<string>();

                    for (var j = 0; j < d; j++)
                    {
                        l.Add(str.Substring(j * d, d));
                    }

                    var key = string.Join("/", l);


                    var rule = Rules.FirstOrDefault(w => w.Key == key);

                    if (rule.Key != key)
                    {
                        rule = Rules.FirstOrDefault(f => Variant(key).ToList().Contains(f.Key));
                    }
                    return rule.Value.Replace("/", "").ToList();
                }).ToList();

                var x = new List<List<List<char>>>();

                for (var l = 0; l < t.Count; l++)
                {
                    x.Add(new List<List<char>>());
                    for (var j = 0; j < d + 1; j++)
                    {
                        x[l].Add(new List<char>());
                        for (var k = 0; k < d + 1; k++)
                        {
                            x[l][j].Add(default);
                        }

                    }

                }

                for (var j = 0; j < x.Count; j++)
                {
                    var str = new string(t[j].ToArray()).ToList();

                    var dd = (int)Math.Sqrt(t[j].Count);

                    for (var k = 0; k < dd; k++)
                    {
                        for (var l = 0; l < dd; l++)
                        {
                            var index = k * dd + l;
                            x[j][k][l] = str[index];
                        }
                    }
                }

                startSpan = x.Combine(d + 1, (int)Math.Sqrt(x.Sum(s => s.Sum(ss => ss.Count))));


                Console.WriteLine();
            }
            return startSpan.Count(c => c == '#');
        }





    }

    public class Day21
    {
        public int Part1(string input, int iterations)
        {

            var sot = new FractalArt(input);

            return sot.Iterate(iterations);
        }
    }
}