// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Хотел сделать так, но нужен цикл по условиям задачи 

// Console.WriteLine("Введите число A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int B = Convert.ToInt32(Console.ReadLine());
// // for (int i = 1; i <= Math.Abs(N); i++)
// if (A)
// Console.WriteLine($"Число А ({A}) в степени B равно {Math.Pow(A, B)}"); 

// Сделал вот такой вариант

Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int num = a;

for (int i = 1; i < b; i++)
{
num = num * a;
}
Console.WriteLine("A в степени B равно: " + num);