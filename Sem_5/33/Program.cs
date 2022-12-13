// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArray()
{
    int[] array = new int[5];
    for(int i = 0; i < 5; i++)
    {
        array[i] = new Random().Next(1, 1000);
        Console.Write($"{array[i]} "); 
    }
    Console.WriteLine("\n");
    return array;
}

void FindNum(int[] Array, int Num)
{
bool find = false;
for(int i = 0; i <5; i++)
{
    if(Array[i] == Num) 
    {
        Console.WriteLine("Да");
        find = true;
        break;
    }
}
if(find == false) Console.WriteLine("Нет");
}
Console.WriteLine("Введите число:");
int num = Math.Abs(int.Parse(Console.ReadLine()!));
FindNum(CreateArray(), num);