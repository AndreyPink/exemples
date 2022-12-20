// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали
// с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] CreateArray(int a, int b)
{
int[,] matrix = new int[a, b];
for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        matrix[rows, columns] = new Random().Next(1,10);
        Console.Write($"{matrix[rows, columns]} ");
    }
    Console.WriteLine("");
}
Console.WriteLine("");
return matrix;
}

void SumLine(int[,] array)
{
    int sumElem = 0;
    for (int column = 0; column < array.GetLength(1); column++)
    {
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            if(rows == column) sumElem += array[rows, column];
        }
    }
    Console.WriteLine($"Сумма элементов главной диагонали равна {sumElem}");
}
SumLine(CreateArray(3,4));

