//Факториал числа

int FactorialRec(int n)
{
    if(n == 1) return 1;
    else return n * FactorialRec(n -1);
}
Console.WriteLine(FactorialRec(10));