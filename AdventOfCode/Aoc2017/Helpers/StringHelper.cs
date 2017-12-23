using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace Aoc2017.Helpers
{
    public static class StringHelper
    {
        public static bool IsNullOrEmpty(this string input)
        {
            return string.IsNullOrEmpty(input);
        }

        public static string Clean(this string input, char escape = '!')
        {
            var newString = new List<char>();

            for (var i = 0; i < input.Length; i++)
            {
                newString.Add(input[i]);
                if (input[i] == escape)
                {
                    i++;
                    continue;
                }

            }
            return new string(newString.ToArray());
        }

        public static List<string> Garbage(this string input, char start = '<', char end = '>')
        {
            if (input == string.Empty)
                return new List<string> { input };
            var result = new List<string>();
            var newString = new List<char>();

            var inputString = input;

            for (var i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == start)
                {
                    var idx = inputString.ToArray().ToList().FindIndex(i, p => p == end);
                    result.Add(inputString.Substring(i, idx - i + 1));
                    i = idx;
                }
            }
            return result;
        }

        public static List<string> Garbage2(this string input)
        {
            var result = new List<string>();
            var matchCollection = Regex2.Matches(input);
            if (matchCollection.Count != 0)
            {
                //foreach (Match c in matchCollection)
                //{
                //    var s = c.Value.Substring(1, c.Value.Length - 2);//;

                //    if (s.IsSurrounded())
                //    {
                //        sum += Score(s, level + 1);
                //    }
                //    else
                //    {
                //        int start = 0;

                //        for (int j = 0; start + j < s.Length; j++)
                //        {
                //            if (s.Substring(start, j + 1).IsSurrounded())
                //            {
                //                sum += Score(s.Substring(start, j + 1), level + 1);
                //                start += j + 2;
                //                j = 0;
                //                Console.WriteLine();
                //            }
                //            else
                //            {
                //                Console.WriteLine();
                //            }
                //        }
                //        //foreach (var s1 in s.Split(','))
                //        //{
                //        //    sum += Score(s1, level + 1);
                //        //}
                //    }

                //    //
                //}
            }
            return result;
        }

        public static string ReplaceFirstOccurrence(this string source, string find, string replace)
        {
            var place = source.IndexOf(find, StringComparison.Ordinal);
            var result = source.Remove(place, find.Length).Insert(place, replace);
            return result;
        }
        static readonly Regex Regex = new Regex(@"
    \(                    # Match (
    (
        [^()]+            # all chars except ()
        | (?<Level>\()    # or if ( then Level += 1
        | (?<-Level>\))   # or if ) then Level -= 1
    )+                    # Repeat (to go from inside to outside)
    (?(Level)(?!))        # zero-width negative lookahead assertion
    \)                    # Match )",
            RegexOptions.IgnorePatternWhitespace);

        static readonly Regex Regex2 = new Regex(@"
    \<                    # Match (
    (
        [^<>]+            # all chars except ()
        | (?<Level>\<)    # or if ( then Level += 1
        | (?<-Level>\>)   # or if ) then Level -= 1
    )+                    # Repeat (to go from inside to outside)
    (?(Level)(?!))        # zero-width negative lookahead assertion
    \>                    # Match )",
            RegexOptions.IgnorePatternWhitespace);

        public static int Score(this string input, int level)
        {
            var matchCollection = Regex.Matches(input);
            if (matchCollection.Count != 0)
            {
                var sum = 0;
                foreach (Match c in matchCollection)
                {
                    var s = c.Value.Substring(1, c.Value.Length - 2);//;

                    if (s.IsSurrounded())
                    {
                        sum += Score(s, level + 1);
                    }
                    else
                    {
                        int start = 0;

                        for (int j = 0; start + j < s.Length; j++)
                        {
                            if (s.Substring(start, j + 1).IsSurrounded())
                            {
                                sum += Score(s.Substring(start, j + 1), level + 1);
                                start += j + 2;
                                j = 0;
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine();
                            }
                        }
                        //foreach (var s1 in s.Split(','))
                        //{
                        //    sum += Score(s1, level + 1);
                        //}
                    }

                    //
                }
                return level + sum;
            }
            return level;

        }
        public static bool IsSurrounded(this string value, char start = '(', char end = ')')
        {
            bool isValid = value[0] == start && value[value.Length - 1] == end;
            int i = 1;
            int c = 0;
            for (; isValid && c >= 0 && i < value.Length - 1; i++)
            {
                if (value[i] == start)
                    c++;
                else if (value[i] == end)
                    c--;
            }

            return (isValid && i == (value.Length - 1) && c == 0);
        }

        public static ReadOnlySpan<char> GetIntBinaryString(this long value, int totalWidth = 32)
        {
            // Use Convert class and PadLeft.

            return Convert.ToString(value, 2).PadLeft(totalWidth, '0').AsSpan();
        }


    }

    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Recursive<T>(this IEnumerable<T> source, Func<T, IEnumerable<T>> childSelector, Func<T, bool> condition = null)
        {
            foreach (var item in source)
            {
                var shouldAdd = true;
                if (condition != null)
                {
                    var matched = condition(item);
                    if (!matched) shouldAdd = false;
                }
                if (shouldAdd) yield return item;
                var childEnumerable = childSelector(item).ToList();
                if (childEnumerable.Any())
                {
                    // Call recursive
                    var childsMatching = childEnumerable.Recursive(childSelector, condition).ToList();
                    if (childsMatching.Any())
                    {
                        foreach (var childMatch in childsMatching)
                        {
                            yield return childMatch;
                        }
                    }
                }
            }
        }
    }


    public static class NumberHelper
    {
        public static int ToInt(this string input)
        {
            return int.Parse(input);
        }

        public static int ToInt(this char[] input)
        {
            return int.Parse(new string(input));
        }
        public static int ToInt(this ReadOnlySpan<char> input)
        {
            return int.Parse(Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(input.ToArray())));
        }

        public static int ToInt2(this ReadOnlySpan<char> input)
        {
            var mp = 1;
            var res = 0;
            foreach (var i in input.ToArray().Reverse().Select(s => s - '0'))
            {
                res += mp * i;
                mp *= 10;
            }
            return res;
        }


        public static string Rotate3(this string input)
        {
            var span = input.ToList();

            return new string(span.Swap(0, 1)
                .Swap(0, 2)
                .Swap(0, 5)
                .Swap(0, 8)
                .Swap(0, 7)
                .Swap(0, 6)
                .Swap(0, 3)
                .ToArray());
        }

        public static IEnumerable<List<T>> Split<T>(this List<T> l, int d)
        {
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

        public static List<T> Combine<T>(this List<List<List<T>>> l, int d, int n)
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



        public static string Rotate2(this string input)
        {
            var span = input.ToList();

            return new string(span.Swap(0, 1)
                .Swap(0, 3)
                .Swap(0, 2)
                .ToArray());
        }

        public static List<char> Swap(this List<char> input, int x, int y)
        {

            var t = input[x];
            input[x] = input[y];
            input[y] = t;
            return input;
        }

    }
}