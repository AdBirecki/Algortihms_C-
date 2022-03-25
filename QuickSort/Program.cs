// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] dataToSort = { 11, 5, 7, 4, 9, 22, 1, 3, 5, 7, 10, 34, -2 };

QuickSort(dataToSort, 0, dataToSort.Length - 1);

Console.WriteLine(string.Join(',', dataToSort));

void QuickSort(int[] array, int left, int right)
{
    if (left < right)
    {
        int partition = Partition(array, left, right);
        QuickSort(array, left, partition - 1);
        QuickSort(array, partition + 1, right);
    }
}

int Partition(int[] array, int left, int right)
{
    int pivotIndex = left;
    int pivotValue = array[right];

    for (int j = left; j < right; j++)
    {
        if (array[j] < pivotValue)
        {
            Swap(ref array[pivotIndex], ref array[j]);
            pivotIndex++;
        }
    }
    Swap(ref array[pivotIndex], ref array[right]);
    return pivotIndex;
}

void Swap(ref int x, ref int y)
{
    (x, y) = (y, x);
}