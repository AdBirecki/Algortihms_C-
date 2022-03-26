// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] arr = { 4, 12, 7, 14, 12, 66, 332, 4, 1, 3, 125 };
InsertionSort(arr, arr.Length - 1);
Console.WriteLine(string.Join(',', arr));

void InsertionSort(int[] array, int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = i + 1; j > 0; j--)
        {
            if (array[j - 1] > array[j])
            {
                Swap(ref array[j - 1], ref array[j]);
            }
        }
        Console.WriteLine(string.Join(',', array));
    }
}


void Swap(ref int x, ref int y)
{
    (x, y) = (y, x);
}
