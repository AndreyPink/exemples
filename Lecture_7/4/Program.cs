// Вычислить А в степени N

int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
    //return n == 0 ? 1 : PowerRec(a, n - 1) * a;  //сокращенное написание тела метода
}
Console.WriteLine(PowerRec(2, 10));

// вариант с сокращением итераций перемножения
int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerRecMath(2, 10));
