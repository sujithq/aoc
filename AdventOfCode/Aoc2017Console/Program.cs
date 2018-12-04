using System;
using System.Collections.Generic;
using System.Linq;

namespace Aoc2017Console
{
    class Program
    {



        static void Main(string[] args)
        {

            var splitted = Split(@".#...####".ToList()).ToList();

            //var back = Combine(splitted, 4, 4);

            Console.ReadKey();

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


        /* Index To Row/Col
         * int row = index/n;
         * int col = index%n 
         */

        /* Row/Col To Index
         * int index = row * n + col
         */
    }
}
