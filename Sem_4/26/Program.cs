// Задача 26: Напишите программу, которая принимает
//  на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int count = 0;
int CountNum(int num)
{
    while (num > 0)
    {
        num /= 10;
        count++;
    }
    return count;
}
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);
Console.Write($"Кол-во цифр в числе {n} = {CountNum(n)}");

