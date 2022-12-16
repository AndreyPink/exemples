// Задача 40: Напишите программу, которая принимает на вход три 
// числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите длину каждой из сторон треугольника, после каждой нажмите ВВОД:");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

void Check(int A, int B, int C)
{
    bool yes = true;
    if(A >= B + C || B >= A + C || C >= B + A) yes = false;
    if(yes) Console.WriteLine("Треугольник возможен");
    else Console.WriteLine("Треугольник невозможен");
}
Check(a,b,c);