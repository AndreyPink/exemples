using System;
// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент
// входных данных.


int[,] CreateArray(int a, int b)
{
    Console.WriteLine("\nДвумерный массив: ");
    int[,] matrix = new int[a, b];
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1, 10);
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}

int[] ConvertToSingleAndSort(int[,] array)
{
    int[] singleArray = new int[array.GetLength(0) * array.GetLength(1)];
    int index = 0;
    Console.WriteLine("Полученный одномерный массив: ");
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            singleArray[index] = array[rows, columns];
            Console.Write($"{array[rows, columns]} ");
            index++;
        }
    }
    Console.WriteLine();
    Array.Sort(singleArray);
    Console.WriteLine("\nОтсортированный одномерный массив: ");
    foreach (int elem in singleArray)
    {
        Console.Write($"{elem} ");
    }
    Console.WriteLine("\n");
    return singleArray;
}

void Frequency(int[] array)
{
    int countElem = 1;
    int j = array[0];
    Console.WriteLine("Частотность массива: ");
    for (int i = 1; i < array.Length; i++)
    {
        if (j == array[i]) countElem++;
        else
        {
            Console.WriteLine($"Число {j} встречается {countElem} раз(а)");
            j = array[i];
            countElem = 1;
        }
    }
    Console.WriteLine($"Число {j} встречается {countElem} раз(а)");
Console.WriteLine();
}

Frequency(ConvertToSingleAndSort(CreateArray(5, 6)));
