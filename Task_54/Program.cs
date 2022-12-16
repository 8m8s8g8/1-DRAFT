// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
Console.WriteLine("===========================================================");
Console.WriteLine("===========================================================");
int[,] arr3 = arr;

for (int i2 = 0; i2 < arr.GetLength(0); i2++)
{
    for (int j2 = 0; j2 < arr.GetLength(1); j2++)
    {
        for (int k = 0; k < arr.GetLength(1) - 1; k++)
        {
            if (arr3[i2, k] < arr3[i2, k + 1])
            {
                int temp = arr[i2, k + 1];
                arr3[i2, k + 1] = arr3[i2, k];
                arr3[i2, k] = temp;
            }
        }
    }

}

for (int i3 = 0; i3 < arr.GetLength(0); i3++)
{
    for (int j3 = 0; j3 < arr.GetLength(1); j3++)
    {
        Console.Write($"{arr3[i3, j3]} {" | "} ");
    }
    Console.WriteLine();
}





