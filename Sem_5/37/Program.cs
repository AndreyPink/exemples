// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArray()
{
    Console.WriteLine("Введите длину массива:");
    int len = int.Parse(Console.ReadLine()!);
    int[] array = new int[len];
    for(int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]} "); 
    }
    Console.WriteLine("\n");
    return array;
}

void Func(int[] Array)
{
    int j = Array.Length - 1;
    int i = 0;
    int lenNewArray = 0;
    if(Array.Length%2 == 0) lenNewArray = Array.Length/2;
    else lenNewArray = Array.Length/2 + 1;
    int[] newArray = new int[lenNewArray];
    
    while (i < Array.Length/2)
    {
        newArray[i] = Array[i] * Array[j];
        Console.Write($"{newArray[i]} ");
        i++;
        j--;
    }
    if(Array.Length%2 != 0) 
    {
        newArray[Array.Length/2] = Array[Array.Length/2];
        Console.Write(newArray[newArray.Length -1]);
    }
}
Func(CreateArray());