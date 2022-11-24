// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number1 = new Random(). Next(100, 1000);
int number2 = new Random(). Next(100, 1000);
int number3 = new Random(). Next(100, 1000);

Console.WriteLine(number1);
Console.WriteLine(number2);
Console.WriteLine(number3);

int numeric1 = number1 % 100;
int numeric1_2 = numeric1 / 10;
int numeric2 = number2 % 100;
int numeric2_2 = numeric2 / 10;
int numeric3 = number3 % 100;
int numeric3_2 = numeric3 / 10;

Console.WriteLine("вторая цифра первого числа");
Console.WriteLine(numeric1_2);
Console.WriteLine("вторая цифра второго числа");
Console.WriteLine(numeric2_2);
Console.WriteLine("вторая цифра третьего числа");
Console.WriteLine(numeric3_2);

