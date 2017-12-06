using Aoc2017.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace Aoc2017
{
    public class Day06 : IDay
    {
        private const char Separator = '\t';
        private const string ConfigSeparator = "|";
        public int Part1(string input)
        {
            var res = 0;

            if (input.IsNullOrEmpty())
                return int.MinValue;

            //Split Into Lines
            var numbers = input.Split(Separator).Select(int.Parse).ToArray();

            var ll = new LinkedList<int>(numbers);

            var usedCfg = new List<string> { string.Join(ConfigSeparator, ll) };


            while (true)
            {
                //Get Max Block
                var maxBlock = ll.Max();

                //Find first Node With Max Value
                var currentNode = ll.Find(maxBlock);

                // ReSharper disable once PossibleNullReferenceException
                currentNode.Value = 0;

                res++;
                for (var i = 0; i < maxBlock; i++)
                {
                    currentNode = currentNode.Next ?? ll.First;

                    currentNode.Value++;
                }
                var cfg = string.Join(ConfigSeparator, ll);
                if (usedCfg.Contains(cfg))
                {
                    return res;
                }
                usedCfg.Add(cfg);
            }
        }

        public int Part2(string input)
        {
            if (input.IsNullOrEmpty())
                return int.MinValue;

            //Split Into Lines
            var numbers = input.Split(Separator).Select(int.Parse).ToArray();

            var ll = new LinkedList<int>(numbers);

            var usedCfg = new List<string> { string.Join(ConfigSeparator, ll) };


            while (true)
            {
                //Get Max Block
                var maxBlock = ll.Max();

                //Find first Node With Max Value
                var currentNode = ll.Find(maxBlock);

                // ReSharper disable once PossibleNullReferenceException
                currentNode.Value = 0;

                for (var i = 0; i < maxBlock; i++)
                {
                    currentNode = currentNode.Next ?? ll.First;

                    currentNode.Value++;
                }
                var cfg = string.Join(ConfigSeparator, ll);
                if (usedCfg.Contains(cfg))
                {
                    return usedCfg.Count - usedCfg.FindIndex(f => f == cfg);
                }
                usedCfg.Add(cfg);
            }
        }
    }
}