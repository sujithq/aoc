using Aoc2017.Helpers;

namespace Aoc2017
{
    public class Day01 : IDay<int>
    {
        public int Part1(string input)
        {
            var res = 0;
            if (input.IsNullOrEmpty())
                return res;
            //Append Last Character
            input += input.Substring(0, 1);

            for (var i = 0; i < input.Length - 1; i++)
            {
                var current = input[i];
                if (current != input[i + 1]) continue;
                if (int.TryParse(current.ToString(), out var t))
                    res += t;
            }
            return res;
        }

        public int Part2(string input)
        {
            var res = 0;
            if (input.IsNullOrEmpty())
                return res;

            var oriSize = input.Length;
            var step = oriSize / 2;

            //Append Half Input
            input += input.Substring(0, step);

            for (var i = 0; i < oriSize; i++)
            {
                var current = input[i];
                if (current != input[i + step]) continue;
                if (int.TryParse(current.ToString(), out var t))
                    res += t;
            }
            return res;
        }
    }
}
