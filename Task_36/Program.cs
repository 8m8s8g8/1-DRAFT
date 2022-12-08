// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandonNumbers(numbers);
Console.WriteLine("В этом массиве: ");
PrintArray(numbers);

void RandonNumbers(int[] numbers)
{
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(1, 100);
    }
}


int count = 0;
int sum = 0;
for (int x = 0; x < numbers.Length; x++)
{
    if (x % 2 == 0)
    {
        sum = sum + numbers[x+1];
    }

    count++;

}
Console.WriteLine($"сумма чисел на четных позициях {sum}");


void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}