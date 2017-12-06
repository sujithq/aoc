using Aoc2017.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace Aoc2017
{
    public class Day06 : IDay
    {
        public int Part1(string input)
        {
            var res = 0;

            if (input.IsNullOrEmpty())
                return int.MinValue;

            //Split Into Lines
            var numbers = input.Split('\t').Select(int.Parse).ToArray();

            LinkedList<int> ll = new LinkedList<int>(numbers);

            var usedCfg = new List<string> {string.Join("|", ll)};


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

                    currentNode.Value += 1;
                }
                if (usedCfg.Contains(string.Join("|", ll)))
                {
                    return res;
                }
                usedCfg.Add(string.Join("|", ll));
            }
        }

        public int Part2(string input)
        {
            var res = 0;

            if (input.IsNullOrEmpty())
                return int.MinValue;

            //Split Into Lines
            var numbers = input.Split('\t').Select(int.Parse).ToArray();

            LinkedList<int> ll = new LinkedList<int>(numbers);

            var usedCfg = new List<string> { string.Join("|", ll) };


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

                    currentNode.Value += 1;
                }
                if (usedCfg.Contains(string.Join("|", ll)))
                {
                    return usedCfg.Count - usedCfg.FindIndex(f => f == string.Join("|", ll));
                }
                usedCfg.Add(string.Join("|", ll));
            }
        }
    }
}