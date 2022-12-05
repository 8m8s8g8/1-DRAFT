// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
double a1 = a / 10000;
double a2;
Math.Round(a1);
a1 = Math.Round(a1, 0);
a2 = a - a1 * 10000;
a2 = (a2 - (a2 % 1000)) / 1000;
double a4;
a4 = (a % 100 - a % 10) / 10;
double a5 = a % 10;
if (a1 == a5 && a2 == a4)
{
    Console.WriteLine("Да, это число является палиндром");
}
else
    Console.WriteLine("Нет, это число не является палиндром");
