// Задача 28: Напишите программу, которая принимает на вход число N
//  и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);
int GetProdNum(int num)
{
    int prod = 1;
   for (int i = 1; i <= num; i++) prod *= i; 
    return prod;
}
Console.Write($"Сумма чисел равна {GetProdNum(n)}");
