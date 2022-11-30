//генерация массива и вывод его на экран 
//с помощью созданных методов:
//1.метод генерации массива FillArray
//2.метод печати массива PrintArray
using System;
using System.Collections.ObjectModel;

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);