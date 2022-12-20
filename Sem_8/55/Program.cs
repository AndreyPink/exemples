// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это невозможно6
// программа должна вывести сообщение для пользователя.

int[,] CreateArray(int a, int b)
{
    Console.WriteLine("Первичный массив:");
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

void ReversMatrix(int[,] array)
{
    Console.WriteLine("Перевернутый массив:");
    int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];
    for (int column = 0; column < array.GetLength(1); column++)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            newArray[column, row] = array[row, column];
            Console.Write($"{newArray[column, row]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
ReversMatrix(CreateArray(3, 4));
Console.WriteLine();