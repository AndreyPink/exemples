// Задача №5. Напишите программу, которая на вход принимает одно число (N),
//  а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"
Console.WriteLine("Введите N");
int number = int.Parse(Console.ReadLine()!);
int start_number = number * (-1);
while (start_number < number + 1)
{
    Console.Write(start_number + " ");
    start_number ++;
}



