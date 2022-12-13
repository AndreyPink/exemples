// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] CreateArray()
{
    int[] array = new int[4];
    for(int i = 0; i < 4; i++)
    {
        array[i] = new Random().Next(-9, 9);
       Console.Write($"{array[i]} "); 
    }
    Console.WriteLine("\n");
    return array;
}
void LineNum(int[] Array)
{
for(int i=0; i<4; i++)
{
    Array[i] *= -1;
    Console.Write($"{Array[i]} ");
}
}
LineNum(CreateArray());


