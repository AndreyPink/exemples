// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max +1);
    }
    return array;
}

void SumNum(int[] Array)
{
    int sumP = 0;
    int sumN = 0;
foreach(int elem in Array)
{
    if (elem <0) sumN+=elem;
    else sumP+=elem;
    Console.Write($"{elem} ");
}
Console.WriteLine($"\nCумма положительных чисел равна {sumP}, сумма отрицательных равна {sumN}");
}

SumNum(CreateArray(12, -9, 9));