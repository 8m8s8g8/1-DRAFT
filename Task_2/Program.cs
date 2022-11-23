// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a = new Random().Next(0,10), b = new Random().Next(0,10);
Console.WriteLine(a);
Console.WriteLine(b);
int max = a;
if(a > b) max = a;
if(a < b) max = b;
Console.WriteLine (max);
