
using SortAlgorithms.Algorithms;
using System.Diagnostics;

int swaps = 0;

int[] num = { 1, 3, 5, 2, 4, 6, 7 };

int[] num2 = { 1, 3, 5, 2, 4, 6, 7 };

var watch = new Stopwatch();

watch.Start();

var quickSort = QuickSort.QuickSortAlgorithm(num, 0, num.Length - 1);

watch.Stop();

Console.WriteLine($"Swaps: {swaps}\n");

Console.WriteLine($"Hello, I'm quick sort and I took {watch.ElapsedMilliseconds} ms to execute!");

foreach (var i in quickSort)
{
    
    Console.WriteLine(i);
}

watch.Start();

var mergeSort = MergeSort.MergeSortAlgorithn(num2, 0, num.Length - 1);

watch.Stop();

Console.WriteLine($"\nHello, I'm merge sort and I took {watch.ElapsedMilliseconds} ms to execute!!");

foreach (var i in mergeSort)
{
    Console.WriteLine(i);
}

