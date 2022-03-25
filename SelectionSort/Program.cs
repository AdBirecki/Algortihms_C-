// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] array = { 1, 5, 7, 3, 4, 10, 22, 16, 2, -3, -18 };
SelectionSort(array, array.Length - 1);

Console.WriteLine(string.Join(',', array));

void SelectionSort(int[] array, int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = i + 1; j <= n; j++)
        {
            if (array[i] > array[j])
            {
                Swap(ref array[i], ref array[j]);
            }
        }
    }
}

void Swap(ref int x, ref int y)
{
    (x, y) = (y, x);
}