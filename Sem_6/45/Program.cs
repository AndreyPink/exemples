using System;
// Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.


int[] CreateArray()
{
int[] array = new int[4];
for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"Введите {i+1} элемент массива:");
    array[i] = int.Parse(Console.ReadLine()!);
}
Console.WriteLine($"Сформированный массив: {string.Join(" ", array)}");
return array;
}

void NewArray(int[] Array)
{
    Console.Write("Новый массив почти такой же как и старый)), но он новый ;-)) ");
    int[] newArr = new int[Array.Length];
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = Array[i];
        Console.Write($"{newArr[i]} ");
    }
}
NewArray(CreateArray());