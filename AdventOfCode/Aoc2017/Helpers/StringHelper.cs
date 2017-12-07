using System;
using System.Collections.Generic;
using System.Linq;

namespace Aoc2017.Helpers
{
    public static class StringHelper
    {
        public static bool IsNullOrEmpty(this string input)
        {
            return string.IsNullOrEmpty(input);
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
}