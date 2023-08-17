﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Данный алгоритм принимает на вход целок число и показывает 3ю цифру числа, либо сообщает что 3й цифры нет");

Console.Write("Введи число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number < 100) Console.WriteLine("3й цифры нет, введи 3х или более значное число");
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    Console.Write("Третья цифра числа: " + (number % 10));
}
