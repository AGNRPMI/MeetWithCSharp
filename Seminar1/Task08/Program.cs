
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("данный алгоритм показывает все четные числа от 1 до введенного числа N \n");
System.Console.Write("Введи целое положительное число N, которое больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 1) System.Console.WriteLine("вы ввели число, не соответствующее условию");
else 
{Console.Write ("Последовательность четных чисел: ");
    for (int i=2; i < number; i=i+2) 
    {Console.Write ($"{i}, ");}}
