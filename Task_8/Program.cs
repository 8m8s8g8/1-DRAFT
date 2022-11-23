//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8;

int [] array = {3,33,87,64,34,52,98,9,35,72,31};
int n = array.Length;
int index = 0;
int find = array[index];
while(index < n)
{
  if ((array[index] % 2) == 0)
  {
  Console.WriteLine(array[index]);      
  }    
  index++;
}