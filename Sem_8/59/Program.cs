// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.

int[,] CreateArray(int a, int b)
{
    Console.WriteLine("\nПервичный массив:");
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

int[] SearchMinElem(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            if (array[rows, columns] < array[minRow, minColumn])
            {
                minRow = rows;
                minColumn = columns;
            }
        }
    }
    int[] data = { minRow, minColumn };
    Console.WriteLine($"Отхреначиваем строку №{minRow}, столбец №{minColumn}\n");
    return data;
}

void CutArray(int[,] array, int[] minData)
{
    Console.WriteLine("Урезанный массив:");
    int oldRow = 0;
    int oldColumn = 0;
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int rows = 0; rows < newArray.GetLength(0); rows++)
    {
        if (oldRow == minData[0]) oldRow++;
        for (int columns = 0; columns < newArray.GetLength(1); columns++)
        {
            if (oldColumn == minData[1]) oldColumn++;
            newArray[rows, columns] = array[oldRow, oldColumn];
            Console.Write($"{newArray[rows, columns]} ");
            oldColumn++;
        }
        Console.WriteLine();
        oldColumn = 0;
        oldRow++;
    }
    Console.WriteLine();
}

int[,] mass = CreateArray(4, 4);
CutArray(mass, SearchMinElem(mass));