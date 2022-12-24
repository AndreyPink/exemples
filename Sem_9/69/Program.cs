// Задача 69: Напишите программу, которая на вход 
// принимает два числа A и B и возводит число A в целую степень B
// с помощью рекурсии.


//МЕТОД ЧЕРЕЗ INT С ТЕРНАРНЫМ ОПЕРАТОРОМ
int DegreeNumber2(int a, int b) 
{return b == 0 ? 1 : a * DegreeNumber2(a, b - 1);}

Console.WriteLine(DegreeNumber2(2, 10));

//МЕТОД ЧЕРЕЗ INT
int DegreeNumber(int a, int b)
{
    if (b == 0) return 1;
    else return a * DegreeNumber(a, b - 1);
}
Console.WriteLine(DegreeNumber(2, 3));