// Напишите программу, 
// которая по заданному номеру четверти,
//  показывает диапазон возможных координат
//   точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int x = int.Parse(Console.ReadLine()!);
if(x == 1) Console.WriteLine("X = (0 : unlim), Y = (0 : unlim)");
if(x == 2) Console.WriteLine("X = (0 : - unlim), Y = (0 : unlim)");
if(x == 3) Console.WriteLine("X = (0 : - unlim), Y = (0 : - unlim)");
if(x == 1) Console.WriteLine("X = (0 : unlim), Y = (0 : - unlim)");