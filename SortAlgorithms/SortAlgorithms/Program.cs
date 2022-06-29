
using System.Diagnostics;

int[] num = { 2, 9, 45, 100, 1, 25, 0 };

var watch = new Stopwatch();

watch.Start();

var quickSort = QuickSort(num, 0, num.Length - 1);

watch.Stop();

Console.WriteLine($"Hello, I'm quick sort and I took {watch.ElapsedMilliseconds} ms to execute!");

foreach (var i in quickSort)
{
    
    Console.WriteLine(i);
}

watch.Start();

var mergeSort = MergeSort(num, 0, num.Length - 1);

watch.Stop();

Console.WriteLine($"\nHello, I'm merge sort and I took {watch.ElapsedMilliseconds} ms to execute!!");

foreach (var i in mergeSort)
{
    Console.WriteLine(i);
}

int[] QuickSort(int[] arr, int a, int b)
{
    var pivot = arr[a];

    var i = a;
    var j = b;

    while (i <= j)
    {
        while (arr[i] < pivot)
        {
            i++;
        }

        while (arr[j] > pivot)
        {
            j--;
        }

        if(i <= j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            i++;
            j--;
        }
    }

    if (a < j)
    {
        QuickSort(arr, a, j);
    }

    if(i < b)
    {
        QuickSort(arr, i, b);
    }

    return arr; 
}

int[] MergeSort(int[] array, int left, int right)
{
    if (left < right)
    {
        int middle = left + (right - left) / 2;
        MergeSort(array, left, middle);
        MergeSort(array, middle + 1, right);
        MergeArray(array, left, middle, right);
    }
    return array;
}

void MergeArray(int[] array, int left, int middle, int right)
{
    var leftArrayLength = middle - left + 1;
    var rightArrayLength = right - middle;
    var leftTempArray = new int[leftArrayLength];
    var rightTempArray = new int[rightArrayLength];
    int i, j;

    for (i = 0; i < leftArrayLength; ++i)
        leftTempArray[i] = array[left + i];
    for (j = 0; j < rightArrayLength; ++j)
        rightTempArray[j] = array[middle + 1 + j];

    i = 0;
    j = 0;
    int k = left;

    while (i < leftArrayLength && j < rightArrayLength)
    {
        if (leftTempArray[i] <= rightTempArray[j])
        {
            array[k++] = leftTempArray[i++];
        }
        else
        {
            array[k++] = rightTempArray[j++];
        }
    }

    while (i < leftArrayLength)
    {
        array[k++] = leftTempArray[i++];
    }

    while (j < rightArrayLength)
    {
        array[k++] = rightTempArray[j++];
    }
}