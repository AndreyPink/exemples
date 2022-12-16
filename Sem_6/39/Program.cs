// Задача 39: Напишите программу, 
// которая перевернёт одномерный массив 
// (последний элемент будет на первом месте,
//  а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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
int[] ReversArray(int[] myArray)
{
    int[] newArray = new int[myArray.Length];
    for (int i = 0; i < myArray.Length; i++)
    {
        newArray[i] = myArray[myArray.Length - 1 -i];
    }
    return newArray;
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
}

PrintArray(ReversArray(CreateArray()));