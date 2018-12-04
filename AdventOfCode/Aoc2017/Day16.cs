using Aoc2017.Helpers;
using System;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace Aoc2017
{

    internal class Dance
    {
        public ReadOnlySpan<char> BaseLine { get; private set; }

        public Dance(string baseLine)
        {
            BaseLine = baseLine.AsSpan();
        }

        public Dance(ReadOnlySpan<char> baseLine)
        {
            BaseLine = baseLine;
        }

        public void Step(ReadOnlySpan<char> input)
        {
            switch (input[0])
            {
                case 's':
                    Spin(input.Slice(1));
                    break;
                case 'x':
                    Exchange(input.Slice(1));
                    break;
                case 'p':
                    Partner(input.Slice(1));
                    break;
            }
        }

        public void Spin(ReadOnlySpan<char> input)
        {
            if (input.Length == 0) return;
            var amount = input.ToInt2();
            if (amount == 0 || amount == BaseLine.Length) return;
            var rev = BaseLine.ToArray();
            var p1 = rev.Skip(rev.Length - amount);
            var p2 = rev.Take(rev.Length - amount);
            BaseLine = p1.Concat(p2).ToArray().AsSpan();
        }
        public void Exchange(ReadOnlySpan<char> input)
        {
            if (input.Length == 0) return;

            var l = input.ToArray();

            var i = l.ToList().FindIndex(c => c == '/');

            var p1 = input.Slice(0, i).ToInt2();
            var p2 = input.Slice(i + 1).ToInt2();


            var xx = BaseLine.ToArray();
            var x = xx[p1];
            xx[p1] = xx[p2];
            xx[p2] = x;

            BaseLine = xx;

        }
        public void Partner(ReadOnlySpan<char> input)
        {
            if (input.Length == 0) return;

            var l = input.ToArray();

            var p1 = BaseLine.ToArray().ToList().FindIndex(f => f == l[0]);
            var p2 = BaseLine.ToArray().ToList().ToList().FindIndex(f => f == l[2]);

            var xx = BaseLine.ToArray();
            var x = xx[p1];
            xx[p1] = xx[p2];
            xx[p2] = x;

            BaseLine = xx;
        }

        public string Result()
        {
            return new string(BaseLine.ToArray());
        }
    }
    public class Day16
    {
        public string Part1(string input, string baseLIne)
        {
            if (input.IsNullOrEmpty())
                return string.Empty;

            var rawMoves = input.Split(',').Select(s => s.AsSpan());

            var dance = new Dance(baseLIne);

            foreach (var rawMove in rawMoves)
            {
                dance.Step(rawMove);
            }

            return dance.Result();
        }

        public string Part2(string input, string baseLIne, int count)
        {
            if (input.IsNullOrEmpty())
                return string.Empty;

            var rawMoves = input.Split(',').Select(s => s.AsSpan()).ToList();

            var bl = baseLIne.AsSpan();

            var sw = Stopwatch.StartNew();
            for (var i = 0; i < count; i++)
            {
                var dance = new Dance(bl);

                foreach (var rawMove in rawMoves)
                {
                    dance.Step(rawMove);
                }

                if (i % 100 == 0)
                {
                    sw.Stop();
                    TestContext.Progress.WriteLine($"{count - i} - {sw.ElapsedMilliseconds}");
                    sw.Restart();
                }
                bl = dance.BaseLine;
            }

            return new string(bl.ToArray());

        }
    }
}