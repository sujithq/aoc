using System;
using System.Collections;
using System.Collections.Generic;
using Aoc2017.Helpers;
using NUnit.Framework;

namespace Aoc2017.Tests.Helpers
{
    public class TestDataClass
    {
        public static IEnumerable KCombs
        {
            get
            {
                yield return new TestCaseData(new List<int> { 1, 2, 3 }, 2).Returns(new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 1, 3 }, new List<int> { 2, 3 } });
                yield return new TestCaseData(new List<int> { 1, 2, 3, 4 }, 2).Returns(new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 1, 3 }, new List<int> { 1, 4 }, new List<int> { 2, 3 }, new List<int> { 2, 4 }, new List<int> { 3, 4 } });
            }
        }
        public static IEnumerable KCombsWithRep
        {
            get
            {
                yield return new TestCaseData(new List<int> { 1, 2, 3 }, 2).Returns(new List<List<int>> { new List<int> { 1, 1 }, new List<int> { 1, 2 }, new List<int> { 1, 3 }, new List<int> { 2, 2 }, new List<int> { 2, 3 }, new List<int> { 3, 3 } });
                yield return new TestCaseData(new List<int> { 1, 2, 3, 4 }, 2).Returns(new List<List<int>> { new List<int> { 1, 1 }, new List<int> { 1, 2 }, new List<int> { 1, 3 }, new List<int> { 1, 4 }, new List<int> { 2, 2 }, new List<int> { 2, 3 }, new List<int> { 2, 4 }, new List<int> { 3, 3 }, new List<int> { 3, 4 }, new List<int> { 4, 4 } });
            }
        }
        public static IEnumerable Permutations
        {
            get
            {
                yield return new TestCaseData(new List<int> { 1, 2, 3 }, 2).Returns(new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 1, 3 }, new List<int> { 2, 1 }, new List<int> { 2, 3 }, new List<int> { 3, 1 }, new List<int> { 3, 2 } });
                yield return new TestCaseData(new List<int> { 1, 2, 3, 4 }, 2).Returns(new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 1, 3 }, new List<int> { 1, 4 }, new List<int> { 2, 1 }, new List<int> { 2, 3 }, new List<int> { 2, 4 }, new List<int> { 3, 1 }, new List<int> { 3, 2 }, new List<int> { 3, 4 }, new List<int> { 4, 1 }, new List<int> { 4, 2 }, new List<int> { 4, 3 } });
            }
        }

        public static IEnumerable PermutationsWithRep
        {
            get
            {
                yield return new TestCaseData(new List<int> { 1, 2, 3 }, 2).Returns(new List<List<int>> { new List<int> { 1, 1 }, new List<int> { 1, 2 }, new List<int> { 1, 3 }, new List<int> { 2, 1 }, new List<int> { 2, 2 }, new List<int> { 2, 3 }, new List<int> { 3, 1 }, new List<int> { 3, 2 }, new List<int> { 3, 3 } });
                yield return new TestCaseData(new List<int> { 1, 2, 3, 4 }, 2).Returns(new List<List<int>> { new List<int> { 1, 1 }, new List<int> { 1, 2 }, new List<int> { 1, 3 }, new List<int> { 1, 4 }, new List<int> { 2, 1 }, new List<int> { 2, 2 }, new List<int> { 2, 3 }, new List<int> { 2, 4 }, new List<int> { 3, 1 }, new List<int> { 3, 2 }, new List<int> { 3, 3 }, new List<int> { 3, 4 }, new List<int> { 4, 1 }, new List<int> { 4, 2 }, new List<int> { 4, 3 }, new List<int> { 4, 4 } });
            }
        }
    }

    [TestFixture]

    public class TestMathHelper
    {
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.KCombs))]
        public IEnumerable<IEnumerable<T>> KCombs<T>(IEnumerable<T> lst, int length) where T : IComparable
        {
            return MathHelper.GetKCombs(lst, length);
        }

        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.KCombsWithRep))]
        public IEnumerable<IEnumerable<T>> KCombsWithRep<T>(IEnumerable<T> lst, int length) where T : IComparable
        {
            return MathHelper.GetKCombsWithRep(lst, length);
        }

        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.Permutations))]
        public IEnumerable<IEnumerable<T>> Permutations<T>(IEnumerable<T> lst, int length) where T : IComparable
        {
            return MathHelper.GetPermutations(lst, length);
        }

        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.PermutationsWithRep))]
        public IEnumerable<IEnumerable<T>> PermutationsWithRep<T>(IEnumerable<T> lst, int length) where T : IComparable
        {
            return MathHelper.GetPermutationsWithRep(lst, length);
        }
    }
}
