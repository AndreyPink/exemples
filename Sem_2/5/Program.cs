// Напишите программу, которая принимает на 
// вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите два числа (через enter)");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
if (num1 == Math.Pow(num2, 2) | num2 == Math.Pow(num1,2))
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
