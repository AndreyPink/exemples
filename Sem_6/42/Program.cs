// Задача 42: Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


// 45%2 = 22 -> 1
// 22%2 = 11 -> 0
// 11%2 = 5 -> 1
// 5%2 = 2 -> 1
// 2%2 = 1 -> 0
// 1%2 = 0 -> 1


void ConvertToDouble(int Number)
{
string numDouble = String.Empty;
while (true)
{
    int res = Number%2;
    numDouble = res + numDouble; 
    Number/=2; 
    if(Number == 0) break;
}
Console.Write(numDouble);
}
Console.WriteLine("Введите число для преобразования:");
int num = int.Parse(Console.ReadLine()!);
Console.Write($"Число {num} конвертировали в двоичное ");
ConvertToDouble(num);