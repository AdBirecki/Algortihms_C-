// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] array = new int[20] { 1, 4, 5, 6, 5, 43, 13, 13, 53, 51, 74, 61, 421, 34, 32, 31, 53, 15, 60, 15 };
int length = array.Length;

QuckSort(array, 0, length - 1);

foreach (int i in array)
{
    Console.WriteLine(i);
}

static void QuckSort(int[] array, int low, int high)
{
    if (low < high)
    {
        int pi = Partition(array, low, high);

        QuckSort(array, low, pi - 1);
        QuckSort(array, pi + 1, high);
    }
}

static int Partition(int[] array, int low, int high)
{
    int pivot = array[high];
    int index = low - 1;
    for (int j = low; j < high; j++)
    {
        if (array[j] <= pivot)
        {
            index++;
            Swap(ref array[index], ref array[j]);
        }
    }
    Swap(ref array[index + 1], ref array[high]);
    return index + 1;
}

static void Swap(ref int x, ref int y)
{
    (x, y) = (y, x);
}

