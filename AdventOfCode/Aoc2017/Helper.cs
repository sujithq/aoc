using System;
using System.Collections.Generic;
using System.Linq;

namespace Aoc2017
{
    static class MathHelper
    {
        public static IEnumerable<IEnumerable<T>>
            GetPermutationsWithRept<T>(IEnumerable<T> lst, int length)
        {
            var list = lst.ToList();
            if (length == 1) return list.Select(t => new[] { t });
            return GetPermutationsWithRept(list, length - 1)
                .SelectMany(t => list,
                    (t1, t2) => t1.Concat(new[] { t2 }));
        }

        public static IEnumerable<IEnumerable<T>>
            GetPermutations<T>(IEnumerable<T> lst, int length)
        {
            var list = lst.ToList();
            if (length == 1) return list.Select(t => new[] { t });
            return GetPermutations(list, length - 1)
                .SelectMany(t => list.Where(o => !t.Contains(o)),
                    (t1, t2) => t1.Concat(new[] { t2 }));
        }

        public static IEnumerable<IEnumerable<T>>
            GetKCombsWithRept<T>(IEnumerable<T> lst, int length) where T : IComparable
        {
            var list = lst.ToList();
            if (length == 1) return list.Select(t => new[] { t });
            return GetKCombsWithRept(list, length - 1)
                .SelectMany(t => list.Where(o => o.CompareTo(t.Last()) >= 0),
                    (t1, t2) => t1.Concat(new[] { t2 }));
        }

        public static IEnumerable<IEnumerable<T>>
            GetKCombs<T>(IEnumerable<T> lst, int length) where T : IComparable
        {
            var list = lst.ToList();
            if (length == 1) return list.Select(t => new[] { t });
            return GetKCombs(list, length - 1)
                .SelectMany(t => list.Where(o => o.CompareTo(t.Last()) > 0),
                    (t1, t2) => t1.Concat(new[] { t2 }));
        }
    }
}
