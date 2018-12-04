using System;
using System.Collections.Generic;
using System.Linq;

namespace Aoc2017
{
    public class Day12 : IDay<int>
    {
        readonly Dictionary<int, bool> _linkedTo0 = new Dictionary<int, bool> { { 0, true } };

        public int Part1(string input)
        {

            var splitted = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            var d = splitted.ToList().ToDictionary(k => int.Parse(k.Split(new[] { " <-> " }, StringSplitOptions.None)[0]), v => v.Split(new[] { " <-> " }, StringSplitOptions.None)[1].Split(new[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToList());

            foreach (var x in d)
            {
                foreach (var kv in d)
                {
                    foreach (var value in kv.Value)
                    {
                        if (!_linkedTo0.ContainsKey(kv.Key)) continue;
                        if (!_linkedTo0.ContainsKey(value))
                            _linkedTo0.Add(value, true);
                    }
                }
            }


            return _linkedTo0.Count;
        }



        public int Part2(string input)
        {
            return int.MinValue;
        }
    }
}