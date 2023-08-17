// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine();
System.Console.WriteLine("Данный алгоритм принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве");



Console.Write("введи координаты X Y Z точки А через пробел (пример 5 23 -15)");
int[] coordinatesA = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
Console.Write("введи координаты X Y Z точки B через пробел (пример -3 10 47)");
int[] coordinatesB = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

double Distance(int[] a, int[] b)
{
    double d = Math.Sqrt(Math.Pow((b[0] - a[0]), 2) + Math.Pow((b[1] - a[1]), 2) + Math.Pow((b[2] - a[2]), 2));
    return d = Math.Round(d, 2);
}


Console.WriteLine($"Расстояние между точкой А и точкой В составляет {Distance(coordinatesA, coordinatesB)}");