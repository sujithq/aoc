namespace Aoc2017
{
    public class Day01 : IDay
    {
        public int Part1(string input)
        {
            var res = 0;
            if (string.IsNullOrEmpty(input))
                return res;
            input += input.Substring(0, 1);

            for (var i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1]) continue;
                if (int.TryParse(input[i].ToString(), out var t))
                    res += t;
            }
            return res;
        }

        public int Part2(string input)
        {
            var res = 0;
            if (string.IsNullOrEmpty(input))
                return res;

            var oriSize = input.Length;
            var step = input.Length / 2;
            input += input.Substring(0, step);

            for (var i = 0; i < oriSize; i++)
            {
                if (input[i] != input[i + step]) continue;
                if (int.TryParse(input[i].ToString(), out var t))
                    res += t;
            }
            return res;
        }
    }
}
