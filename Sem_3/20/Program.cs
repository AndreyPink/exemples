// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите координату Х1");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y1");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Х2");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y2");
int y2 = int.Parse(Console.ReadLine()!);

double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"расстояние между точками равно {d}");

