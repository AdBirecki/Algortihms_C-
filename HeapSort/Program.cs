// See https://aka.ms/new-console-template for more information

int[] dataToSort = { 11, 5, 7, 4, 9, 22, 1, 3, 5, 7, 10, 34, -2 };
HeapSort(dataToSort, dataToSort.Length - 1);

Console.WriteLine(string.Join(',', dataToSort));


int[] HeapSort(int[] array, int n)
{
    int[] results = new int[n];
    for (int i = n / 2 - 1; i >= 0; i--)
        Heapify(array, n, i);
    for (int i = n; i >= 0; i--)
    {
        results.Append(array[i]);
        Swap(ref array[0], ref array[i]);
        Heapify(array, i, 0);
    }
    return results;
}

void Heapify(int[] arr, int n, int i)
{
    int largest = i;
    int left = 2 * i + 1;
    int right = 2 * i + 2;

    if (left < n && arr[left] > arr[largest])
        largest = left;

    if (right < n && arr[right] > arr[largest])
        largest = right;

    if (largest != i)
    {
        Swap(ref arr[largest], ref arr[i]);
        Heapify(arr, n, largest);
    }
}


void Swap(ref int x, ref int y)
{
    (x, y) = (y, x);
}
