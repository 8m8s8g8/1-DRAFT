//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int number1 = new Random(). Next(1, 100000);
int number2 = new Random(). Next(1, 100000);
int number3 = new Random(). Next(1, 100000);

Console.WriteLine(number1);
Console.WriteLine(number2);
Console.WriteLine(number3);

int numeric1 = number1 % 1000;
int numeric1_2 = numeric1 / 100;
int numeric2 = number2 % 1000;
int numeric2_2 = numeric2 / 100;
int numeric3 = number3 % 1000;
int numeric3_2 = numeric3 / 100;
if (number1 < 100)
{
Console.WriteLine("Нет третьей цифры");
numeric1_2 = -1;
}
else
Console.WriteLine("третья цифра первого числа");
Console.WriteLine(numeric1_2);

if (number2 < 100)
{
Console.WriteLine("Нет третьей цифры второго числа");
numeric2_2 = -1;
}
else
Console.WriteLine("третья цифра второго числа");
Console.WriteLine(numeric2_2);
if (number3 < 100)
{
Console.WriteLine("Нет третьей цифры третьего числа");
numeric3_2 = -1;
}
else
Console.WriteLine("вторая цифра третьего числа");
Console.WriteLine(numeric3_2);
