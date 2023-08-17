// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("данный алгоритм определяет наибольшее из двух введенных чисел \n");
System.Console.Write("Введи число А:");
double numberA = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введи число B:");
double numberB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Сравниваю два числа: ");
if (numberA == numberB) System.Console.WriteLine("эти два числа равны");
else if (numberA > numberB) System.Console.WriteLine($"число А={numberA} больше числа В={numberB}");
else System.Console.WriteLine($"число В={numberB} больше числа А={numberA}");