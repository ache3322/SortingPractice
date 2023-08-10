namespace SortLibrary
{
    /// <summary>
    /// The Bubble Sort algorithm demonstration.
    /// 
    /// Traverse the collection from left to right and compare the elements adjacent.
    /// Swap the elements if the left-most element is larger than the right-most element.
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// Sort by ascending order.
        /// </summary>
        public int[] Sort(int[] unsortedArr)
        {
            int n = unsortedArr.Length;
            if (n <= 0)
            {
                return Array.Empty<int>();
            }

            int[] toSort = new int[n];
            Array.Copy(unsortedArr, toSort, n);

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    int temp;
                    if (toSort[j] > toSort[j + 1])
                    {
                        // swap the elements in the arrary
                        temp = toSort[j];
                        toSort[j] = toSort[j + 1];
                        toSort[j + 1] = temp;
                    }
                }
            }

            return toSort;
        }
    }
}
