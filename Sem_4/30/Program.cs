// Задача 30: Напишите программу, которая выводит 
// массив из 8 элементов, заполненный нулями и 
// единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] CreateRandArray()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}
void PrintRandArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < 7; i++) Console.Write(arr[i] + ",");
    Console.Write(arr[7] + "]");
}
PrintRandArray(CreateRandArray());