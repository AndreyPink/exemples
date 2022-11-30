//Лекция_2
//Задача_1 
//Нахождение максимально числа из 9-ти указанных

using System;
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 3, b1 = 4, c1 = 6,
a2 = 5, b2 = 12, c2 = 20,
a3 = 15, b3 = 9, c3 = 10;

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);