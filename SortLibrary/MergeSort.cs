namespace SortLibrary
{
    /// <summary>
    /// The recursive sorting algorithm, the Merge Sort, by splitting arrays in half and 
    /// merge the subarrays into a fully sorted array.
    /// 
    /// Modified from: https://www.geeksforgeeks.org/merge-sort/
    /// </summary>
    public class MergeSort
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

        /// <summary>
        /// Utilize recursion to sort and merge.
        /// </summary>
        private void Sort(int[] arr, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                // Find the middle of the array
                int middleIndex = (startIndex + (endIndex - 1)) / 2;

                // Sort first half and second half
                Sort(arr, startIndex, middleIndex);
                Sort(arr, middleIndex + 1, endIndex);

                Merge(arr, startIndex, middleIndex, endIndex);
            }
        }

        // arr[s..m]
        // arr[m+1..e]
        private void Merge(int[] arr, int s, int m, int e)
        {
            int n1 = m - s + 1;
            int n2 = e - m;

            // Create temporary arrays
            int[] left = new int[n1];
            int[] right = new int[n2];

            int i;
            for (i = 0; i < n1; i++)
            {
                left[i] = arr[s + i];
            }

            int j;
            for (j = 0; j < n2; j++)
            {
                right[j] = arr[m + 1 + j];
            }

            i = 0;
            j = 0;

            int k = s;
            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements from left array
            while (i < n1)
            {
                arr[k] = left[i];
                i++;
                k++;
            }

            // Copy remaining elements from right array
            while (j < n2)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
