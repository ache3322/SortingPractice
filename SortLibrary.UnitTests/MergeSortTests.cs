using System;
using Xunit;

namespace SortLibrary.UnitTests
{
    public class MergeSortTests
    {
        private readonly MergeSort _sort = new MergeSort();

        [Fact]
        public void GivenEmptyArrary_ExpectEmpty()
        {
            int[] empty = Array.Empty<int>();

            var sorted = _sort.Sort(empty);

            Assert.Empty(sorted);
        }

        [Fact]
        public void GivenOneElement_ExpectEqual()
        {
            int[] unsorted = new[] { 0 };
            int[] expected = new[] { 0 };

            var sorted = _sort.Sort(unsorted);

            Assert.Equal(expected, sorted);
        }

        [Fact]
        public void GivenUnsortedArray_ExpectSortedByAsc()
        {
            int[] unsorted = new[] { 42, 33, 43, 4, 10, 89, 99 };
            int[] expected = new[] { 4, 10, 33, 42, 43, 89, 99 };

            var sorted = _sort.Sort(unsorted);

            Assert.Equal(expected, sorted);
        }

        [Fact]
        public void GivenUnsortedNegativeNumbers_ExpectedSortedByAsc()
        {
            int[] unsorted = new[] { -1, -5, -2, 0 };
            int[] expected = new[] { -5, -2, -1, 0 };

            var sorted = _sort.Sort(unsorted);

            Assert.Equal(expected, sorted);
        }
    }
}
