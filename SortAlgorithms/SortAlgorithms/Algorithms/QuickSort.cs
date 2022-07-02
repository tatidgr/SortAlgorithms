namespace SortAlgorithms.Algorithms
{
    internal static class QuickSort
    {
        public static int[] QuickSortAlgorithm(int[] arr, int a, int b)
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

                if (i <= j)
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
                QuickSortAlgorithm(arr, a, j);
            }

            if (i < b)
            {
                QuickSortAlgorithm(arr, i, b);
            }

            return arr;
        }
    }
}
