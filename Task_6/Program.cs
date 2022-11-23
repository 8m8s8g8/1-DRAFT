//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет
int a = 4; 
int b =-3; 
int c = 7;
double a1 = (a % 2); double b1 = (b % 2); double c1 = (c % 2);
Console.WriteLine(a);
if(a1==0) 
Console.WriteLine("Четное");
else   
Console.WriteLine("Не четное");
Console.WriteLine(b); 
if(b1==0) 
Console.WriteLine("Четное");
else   
Console.WriteLine("Не четное");
Console.WriteLine(c);
if(c1==0) 
Console.WriteLine("Четное");
else   
Console.WriteLine("Не четное"); 
