// Задача 24: Напишите программу, 
// которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите число N");
// int n = int.Parse(Console.ReadLine()!);
// int sum = 0;
// for(int i = 1; i <= n; i++) sum+=i;
// Console.Write($"Сумма чисел равна {sum}");

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);
int GetSumNum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num;
        num--;
    }
    return sum;
}
Console.Write($"Сумма чисел равна {GetSumNum(n)}");