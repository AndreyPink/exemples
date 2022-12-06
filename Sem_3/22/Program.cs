// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);
for(int i = 1; i < n; i++) Console.Write(Math.Pow(i, 2) + ", ");
Console.Write(Math.Pow(n, 2) + ".");