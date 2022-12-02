/* Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

Console.WriteLine("Введите два числа (через enter)");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
if (num2 % num1 != 0)
{
    Console.WriteLine($"не кратно, остаток {num2%num1}");
}
else
{
    Console.WriteLine("кратно");
}