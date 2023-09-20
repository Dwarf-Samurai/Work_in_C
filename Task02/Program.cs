// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите 1-ое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-ое число ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberA > max)
{ max = numberA; }
if (numberB > max )
{ max = numberB; }
if (numberC > max )
{ max = numberC; }

Console.WriteLine($"Максимальное число: {max}");

