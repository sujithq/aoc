using System;
using System.Collections.Generic;
using System.Linq;

namespace Aoc2017.Helpers
{
    public static class MathHelper
    {
        public static IEnumerable<IEnumerable<T>>GetPermutationsWithRep<T>(IEnumerable<T> lst, int length) where T : IComparable<T>
        {
            return GetCommon(lst, length, GetPermutationsWithRep, t => lst);
        }

        public static IEnumerable<IEnumerable<T>>GetPermutations<T>(IEnumerable<T> lst, int length) where T : IComparable<T>
        {
            return GetCommon(lst, length, GetPermutations, t => lst.Where(o => !t.Contains(o)));
        }

        public static IEnumerable<IEnumerable<T>>GetKCombsWithRep<T>(IEnumerable<T> lst, int length) where T : IComparable<T>
        {
            return GetCommon(lst, length, GetKCombsWithRep, t => lst.Where(o => o.CompareTo(t.Last()) >= 0));
        }

        public static IEnumerable<IEnumerable<T>> GetKCombs<T>(IEnumerable<T> lst, int length) where T : IComparable<T>
        {
            return GetCommon(lst, length, GetKCombs, t => lst.Where(o => o.CompareTo(t.Last()) > 0));
        }

        public static IEnumerable<IEnumerable<T>>
            GetKCombs2<T>(IEnumerable<T> list, int length) where T : IComparable<T>
        {
            if (length == 1) return list.Select(t => new T[] { t });
            return GetKCombs2(list, length - 1)
                .SelectMany(t => list.Where(o => o.CompareTo(t.Last()) > 0),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }


        private static IEnumerable<IEnumerable<T>> GetCommon<T>(IEnumerable<T> lst, int length, Func<IEnumerable<T>, int, IEnumerable<IEnumerable<T>>> fct, Func<IEnumerable<T>, IEnumerable<T>> predicate)
            where T : IComparable<T>
        {
            if (length == 1) return lst.Select(t => new[] { t });
            return fct(lst, length - 1)
                .SelectMany(predicate,
                    (t1, t2) => t1.Concat(new[] { t2 }));
        }

    }


}
