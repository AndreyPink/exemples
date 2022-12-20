// Задача 48. Задайте двумерный массив размером m×n, 
// каждый элемент в массиве находится по формуле: A = m+n. Выведете полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

void CreateMatrix(int a, int b)
{
int[,] matrix = new int[a, b];
for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        matrix[rows, columns] = rows + columns;;
        Console.Write($"{matrix[rows, columns]} ");
    }
    Console.WriteLine("");
}
Console.WriteLine("");
}
CreateMatrix(3,4);

