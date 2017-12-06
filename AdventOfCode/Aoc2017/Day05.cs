using Aoc2017.Helpers;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Aoc2017
{
    public class Day05 : IDay
    {
        public int Part1(string input)
        {
            var res = 0;

            if (input.IsNullOrEmpty())
                return int.MinValue;


            //Split Into Lines
            var numbers = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Select(int.Parse).ToList();

            var cIdx = 0;

            /*
            (0) 3  0  1  -3  - before we have taken any steps.
            (1) 3  0  1 - 3 - jump with offset 0(that is, don't jump at all). Fortunately, the instruction is then incremented to 1.
           
            2(3) 0  1 - 3 - step forward because of the instruction we just modified.The first instruction is incremented again, now to 2.
           
            2  4  0  1(-3) - jump all the way to the end; leave a 4 behind.
            2(4) 0  1 - 2 - go back to where we just were; increment - 3 to - 2.
            2  5  0  1 - 2 - jump 4 steps forward, escaping the maze.
            */

            while (true)
            {
                //var a = numbers.Select(s => s.ToString()).ToList();
                //a[cIdx] = "(" + a[cIdx] + ")";
                //Debug.Print("{0}", string.Join(" ", a));

                //Determine number of moves
                var step = numbers[cIdx];

                //Increase
                numbers[cIdx] += 1;

                //Next Index
                cIdx += step;

                try
                {
                    //Increase Steps
                    res++;
                    //Try move
                    var tmp = numbers[cIdx];
                }
                catch (Exception)
                {
                    //Debug.Print("{0}", string.Join(" ", numbers));
                    break;
                }

            }



            return res;
        }

        public int Part2(string input)
        {
            return int.MinValue;
        }
    }
}