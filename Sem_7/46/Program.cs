// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] CreateArray(int a, int b)
{
int[,] matrix = new int[a, b];
for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        matrix[rows, columns] = new Random().Next(-10,10);
        Console.Write($"{matrix[rows, columns]} ");
    }
    Console.WriteLine("");
}
return matrix;
}
Console.WriteLine("Введите размер массива M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите размер массива N: ");
int n = int.Parse(Console.ReadLine()!);
CreateArray(m,n);
Console.WriteLine("");

