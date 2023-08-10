// See https://aka.ms/new-console-template for more information
using Sort.Demo;
using SortLibrary;

const bool PRINT_NUMBERS = false; // Toggle to display unsorted/sorted numbers from the array
const bool SKIP_BUBBLE_SORT = false;

var profiler = new TickProfiler();
int[] unsorted = GenerateRandomNumbers(10000, 0, 99999);

RunMergeSort(unsorted);
RunQuickSort(unsorted);
RunBubbleSort(unsorted);

void RunMergeSort(int[] unsorted)
{
    var mergeSort = new MergeSort();

    profiler.Start();
    var sorted = mergeSort.Sort(unsorted);

    Console.WriteLine($"\nMERGE SORT");
    Console.WriteLine($"Elapsed ms: {profiler.GetMilliseconds()}");
    PrintNumbers(unsorted, sorted);
}

void RunQuickSort(int[] unsorted)
{
    var quickSort = new QuickSort();

    profiler.Start();
    var sorted = quickSort.Sort(unsorted);

    Console.WriteLine($"\nQUICK SORT");
    Console.WriteLine($"Elapsed ms: {profiler.GetMilliseconds()}");
    PrintNumbers(unsorted, sorted);
}

void RunBubbleSort(int[] unsorted)
{
    if (SKIP_BUBBLE_SORT)
    {
        return;
    }

    var bubbleSort = new BubbleSort();

    profiler.Start();
    var sorted = bubbleSort.Sort(unsorted);

    Console.WriteLine($"\nBUBBLE SORT");
    Console.WriteLine($"Elapsed ms: {profiler.GetMilliseconds()}");
    PrintNumbers(unsorted, sorted);
}

int[] GenerateRandomNumbers(int n, int minRange = 0, int maxRange = 10000)
{
    var rng = new Random();
    var numbers = new List<int>();

    for (int i = 0; i <= n; i++)
    {
        numbers.Add(rng.Next(minRange, maxRange + 1));
    }

    return numbers.ToArray();
}

void PrintNumbers(int[] unsorted, int[] sorted)
{
    if (PRINT_NUMBERS)
    {
        Console.WriteLine($"Unsorted: {string.Join(',', unsorted)}");
        Console.WriteLine($"Sorted: {string.Join(',', sorted)}");
    }
}