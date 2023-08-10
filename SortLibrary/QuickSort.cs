namespace SortLibrary
{
    /// <summary>
    /// Quick Sort relies on pivoting on an element and partitioning.
    /// 
    /// Modified from: https://www.geeksforgeeks.org/quick-sort/
    /// </summary>
    public class QuickSort
    {
        public int[] Sort(int[] unsortedArr)
        {
            int n = unsortedArr.Length;
            if (n <= 0)
            {
                return Array.Empty<int>();
            }
            else if (n == 1)
            {
                return unsortedArr;
            }

            int[] toSort = new int[n];
            Array.Copy(unsortedArr, toSort, n);

            Sort(toSort, 0, n - 1);

            return toSort;
        }

        private void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(arr, low, high);

                Sort(arr, low, partitionIndex - 1);
                Sort(arr, partitionIndex + 1, high);
            }
        }

        /// <summary>
        /// Uses the last element as the pivot.
        /// </summary>
        /// <param name="low">The lowest index</param>
        /// <param name="high">The highest index</param>
        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = low - 1;

            for (int j = low; j <= high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);

            return i + 1;
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
