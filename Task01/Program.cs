//Задача 2 Напишите программу, которая на вход принимает два числа и выдает какое число большее, а какое меньшее.

Console.WriteLine("Введите 1-ое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число ");
int numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA;
int min = numberB;

if (numberA > max)
{ max = numberA; min = numberB; }
if (numberB > max)
{ max = numberB; min = numberA; }

Console.WriteLine($"Максимальное число: {max} Минимальное число: {min}");




