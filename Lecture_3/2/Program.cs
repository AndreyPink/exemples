//сортировка массива

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 3, 4, 8, 19 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
SelectSort(arr);
PrintArray(arr);

// Array.Sort(arr);
// for (int i=0; i< arr.Length; i++) Console.Write(arr[i]+ " ");
