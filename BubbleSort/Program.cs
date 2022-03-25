// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] array = { 1, 15, 7, 2, 1, 45, 62, 11, 23, 5, 3, 17, 102 };

BubbleSort(array);
Console.WriteLine(string.Join(',', array));


void BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                Swap(ref arr[j], ref arr[j + 1]);
            }
        }
    }
}


void Swap(ref int x, ref int y)
{
    (x, y) = (y, x);
}