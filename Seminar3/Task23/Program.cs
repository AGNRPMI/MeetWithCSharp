// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


System.Console.WriteLine("Данный алгоритм принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N");

Console.Write("Введи целое число: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (N == 0) System.Console.WriteLine("вы ввели 0");
else
{
    for (int i = 1; i < N + 1; i++)
    {
        Console.Write(i + " | ");
    }
    Console.WriteLine();

    for (int i = 1; i < N + 1; i++)
    {
        Console.Write(Math.Pow(i, 3) + " | ");
    }
}
