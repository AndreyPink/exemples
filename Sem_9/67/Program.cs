// Задача 67: Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр


//МЕТОД ЧЕРЕЗ VOID
void SumDigit(int num)
{
    if (num > 0) num = num % 10 + SumDigit2(num / 10);
    Console.WriteLine(num); 
}
SumDigit(22222);

Console.WriteLine();

//МЕТОД ЧЕРЕЗ INT
int SumDigit2(int num)
{
    if (num > 0) return num % 10 + SumDigit2(num / 10);
    return num;
}
Console.WriteLine(SumDigit2(4535));