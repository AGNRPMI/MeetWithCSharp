// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine();
System.Console.WriteLine("Данный алгоритм задаёт массив из 8 элементов и выводит их на экран");


int[] Array = new int[8];
Random rand = new Random();
System.Console.WriteLine("Порядковый номер элемента: ");
System.Console.WriteLine("0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 |");
for (int i = 0; i < 8; i++)
{
    Array[i] = rand.Next(0, 101);
    Console.Write(Array[i]);
    Console.Write(" | ");
}