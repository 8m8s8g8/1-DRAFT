// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("введите искомое число ");
int num = Convert.ToInt32(Console.ReadLine());

int m = new Random().Next(2, 10);
int n = new Random().Next(2, 10);
int[,] arr = new int[m, n];


PrintArray(FillArray(arr));
int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }

    }
    return arr;

}

void PrintArray(int[,] arr2)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr2[i, j]} {" | "} ");
        }
        Console.WriteLine();
    }

}
int sum = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (arr[i, j] == num)
        {
            Console.WriteLine($"введеное число находится в {i + 1} строке, {j + 1} столбце, ");

            sum++;
        }
    }

}Console.WriteLine($"ВВЕДЕННОЕ ЧИСЛО ВСТРЕЧАЕТСЯ В МАССИВЕ {sum} РАЗ(а)");

if (sum == 0)
{
    Console.WriteLine($"ВВЕДЕННОЕ ЧИСЛО НЕ ВСТРЕЧАЕТСЯ В ДАННОМ МАССИВЕ");
}

