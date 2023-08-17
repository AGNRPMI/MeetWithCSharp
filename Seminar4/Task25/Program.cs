// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine();
System.Console.WriteLine("Данный алгоритм принимает на вход два числа (A и B) и возводит число A в натуральную степень B");



Console.Write("введи координаты А и В через пробел (пример 5 3) ");
int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

double Powwww(int a, int b)
{
    double res = a;
    if (b > 0)
    {
        for (int i = 1; i < b; i++)
        {
            res = res * a;
        }
    }
    else if (b == 0) res = 1;
    else
    {
        res = 1 / Convert.ToDouble(a);
        for (int i = b; i < -1; i++)
        {
            res = res /a;
        }
    }
    return res;
}
double result = Math.Pow(numbers[0], numbers[1]);

Console.WriteLine($"Число {numbers[0]} в степени {numbers[1]} равно {result}");
Console.WriteLine();
Console.WriteLine($"Число {numbers[0]} в степени {numbers[1]} равно {Powwww(numbers[0], numbers[1])}");