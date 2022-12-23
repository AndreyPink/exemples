// Задача 69: Напишите программу, которая на вход 
// принимает два числа A и B и возводит число A в целую степень B
// с помощью рекурсии.

//МЕТОД ЧЕРЕЗ INT
int DegreeNumber(int a, int b)
{
    if(b > 1) return a * DegreeNumber(a, b -1);
    return a;
}
Console.WriteLine(DegreeNumber(2,10));

