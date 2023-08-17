// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine();
System.Console.WriteLine("Данный алгоритм принимает на вход пятизначное число и проверяет, является ли оно палиндромом");

Console.Write("введи 5ти значное число: ");
int number = Convert.ToInt32(Console.ReadLine()!);

if (Math.Abs(number) < 10000 | Math.Abs(number) > 99999)
{
    System.Console.WriteLine("Вы ввели число, не удовлетворяющее условиям");
}

else if ((number / 10000 == number % 10) & (number / 1000 % 10 == number % 100 / 10))
{
    System.Console.WriteLine($"Число {number} является палиндромом");
}
else System.Console.WriteLine($"Число {number} не является палиндромом");
