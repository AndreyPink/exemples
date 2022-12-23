// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

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

// создаем новый двумерный массив и в 1-ю строку нового записываем последнюю строку старого массива,
// а в последнюю строку нового - 1-ю строку старого 
void ReversFirstLastRow(int[,] array)
{
    Console.WriteLine("Массив с заменой 1-й и последней строки:");
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            if (rows == 0) newArray[0, columns] = array[array.GetLength(0) - 1, columns];
            else if (rows == array.GetLength(0) - 1) newArray[array.GetLength(0) - 1, columns] = array[0, columns];
            else newArray[rows, columns] = array[rows, columns];
            Console.Write($"{newArray[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
ReversFirstLastRow(CreateArray(5, 4));
Console.WriteLine();