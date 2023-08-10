using System;
using Xunit;

namespace SortLibrary.UnitTests
{
    public class QuickSortTests
    {
        private readonly QuickSort _sort = new QuickSort();

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
            //var unsorted = new[] { 10, 80, 30, 90, 40, 50, 70 };
            var unsorted = new[] { 10, 80, 30, 70, 40, 50, 90 };
            var expected = new[] { 10, 30, 40, 50, 70, 80, 90 };

            var sorted = _sort.Sort(unsorted);

            Assert.Equal(expected, sorted);
        }
    }
}
