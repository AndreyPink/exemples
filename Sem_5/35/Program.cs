// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArray()
{
    int[] array = new int[123];
    for(int i = 0; i < 123; i++)
    {
        array[i] = new Random().Next(1, 1000);
        Console.Write($"{array[i]} "); 
    }
    Console.WriteLine("\n");
    return array;
}

void FindNum(int[] Array)
{
int sum = 0;
for(int i = 0; i <123; i++)
{
    if(Array[i] >= 10 && Array[i] <= 99) sum++;
}
Console.WriteLine(sum);
}
FindNum(CreateArray());

