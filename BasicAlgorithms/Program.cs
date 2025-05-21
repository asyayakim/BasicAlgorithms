using System.Diagnostics;

namespace BasicAlgorithms;

class Program
{
    static async Task Main(string[] args)
    {
        //int[] numbers = { 5, 3, 8, 4, 2, 7, 1, 6 };
        Random rand = new Random();
        //int[] numbers = Enumerable.Range(0, 1000000).Select(x => rand.Next(0, 100)).ToArray();
        int[] numbers = Enumerable.Range(0, 1000).Select(x => rand.Next(0, 1000)).ToArray();
        Console.WriteLine("Original Array:");
        //Console.WriteLine(string.Join(", ", numbers));
        Stopwatch stopwatch = Stopwatch.StartNew();
        int[] quicksortArray = (int[])numbers.Clone();
        // QuickSort: Space Complexity O(log n) average - Recursion stack depth
        QuickSort(quicksortArray, 0, quicksortArray.Length - 1);
        stopwatch.Stop();
        Console.WriteLine("Quicksort Time: " + stopwatch.ElapsedMilliseconds + " ms");
        stopwatch.Restart();
        // Merge Sort: Space Complexity O(n) - Requires temporary arrays for merging
        int[] mergeSortArray = (int[])numbers.Clone();
        MergeSort(mergeSortArray, 0, mergeSortArray.Length - 1);
        stopwatch.Stop();
        Console.WriteLine("Merge Sort Time: " + stopwatch.ElapsedMilliseconds + " ms");
        stopwatch.Restart();
        // Bubble Sort: Space Complexity O(1) - In-place sorting
        int[] bubbleSortArray = (int[])numbers.Clone();
        BubbleSort(bubbleSortArray);
        stopwatch.Stop();
        Console.WriteLine("Bubble Sort Time: " + stopwatch.ElapsedMilliseconds + " ms");
        
        // Space Complexity: O(1) - Only uses constant extra space for temporary swaps
        void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }
        }
    }
    
    // Space Complexity: O(log n) average - Recursion stack depth
    // Worst case O(n) for unbalanced partitions
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivot = Partition(arr, low, high);
            QuickSort(arr, low, pivot - 1);
            QuickSort(arr, pivot + 1, high);
        }
    }
    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }
        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }
    
    // Merge Sort: Space Complexity O(n) - Requires temporary arrays
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] leftArr = arr[left..(mid + 1)];
        int[] rightArr = arr[(mid + 1)..(right + 1)];
        int i = 0, j = 0, k = left;
        while (i < leftArr.Length && j < rightArr.Length)
        {
            if (leftArr[i] <= rightArr[j])
                arr[k++] = leftArr[i++];
            else
                arr[k++] = rightArr[j++];
        }
        while (i < leftArr.Length) arr[k++] = leftArr[i++];
        while (j < rightArr.Length) arr[k++] = rightArr[j++];
    }
}