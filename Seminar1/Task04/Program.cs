// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


System.Console.WriteLine("данный алгоритм наибольшее число из трех введенных \n");
System.Console.Write("Введи число А:");
double numberA = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введи число B:");
double numberB = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введи число C:");
double numberC = Convert.ToDouble(Console.ReadLine());

double[] numbers = { numberA, numberB, numberC };
Console.WriteLine($"Последовательность чисел {numberA} {numberB} {numberC}");
Console.WriteLine($"Наибольшее число : {numbers.Max()}");