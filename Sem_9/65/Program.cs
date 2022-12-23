// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до M.

//ВАРИАНТ ВЫВОДА ЧЕРЕЗ СТРОЧНЫЙ МАССИВ
string LineNumbers(int m, int n)
{
    return (m + 1 <= n) ? $"{m} " + LineNumbers(m + 1, n) : $"{m}";

}

Console.WriteLine(LineNumbers(5, 10));

//ВАРИАНТ ВЫВОДА VOID
void LineNumbers2(int m, int n)
{
    if (n > m) LineNumbers2(m, n - 1);
    Console.Write($"{n} ");
    if (m > n) LineNumbers2(m, n + 1);
}
LineNumbers2(10, 5);