// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine();
System.Console.WriteLine("Данный алгоритм принимает на вход число и выдаёт сумму цифр в числе");



Console.Write("введи целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(number);
int[] Array = new int[str.Length];
int n = 0;
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = Convert.ToInt32(str[i].ToString());
    n = n + Array[i];
}
Console.WriteLine($"Сумма цифр в числе {number} равна {n}");