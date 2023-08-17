using System;
using System.Text;

namespace CSharpExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            while (isOpen)
            {
                isOpen = WorkingProcess(isOpen);
                if (isOpen == true)
                {
                    Console.WriteLine("Введи количество строк: ");
                    int row = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введи количество столбцов: ");
                    int col = Convert.ToInt32(Console.ReadLine());
                    int[,] array = CreateArray(col, row);
                    PrintArray(array);
                    
                    AverageCol(array);
                }
            }
            Console.Write("Нажмите любую клавишу для завершения ...");
            Console.ReadKey();
            Console.Clear();
        }

        static int[,] CreateArray(int col, int row)
        {
            int[,] _array = new int[row, col];
            Random rand = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                    _array[i, j] = rand.Next(-100, 101);
            }
            Console.WriteLine();

            return _array;
        }
        static void PrintArray(int[,] _array)
        {
            int width = _array.GetLength(0);
            int heigth = _array.GetLength(1);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < heigth; j++)
                    Console.Write(_array[i, j] + " ");
                Console.WriteLine();
            }

        }
        static void AverageCol(int[,] array2D)
        {
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                double sum = 0;
                for (int i = 0; i < array2D.GetLength(0); i++)
                {
                    sum += array2D[i, j];
                }
                Console.WriteLine($"СреднееF арифметическое в колонке {j+1} составляет {sum/array2D.GetLength(0)}");
            }
            


        }
        static bool WorkingProcess(bool _isOpen)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Задача 52: ");
            Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце"
                            + "\nКоманды: ");
            Console.WriteLine("1 - выполнить функцию, \n \"любое\" - завершить работу. \n");
            Console.WriteLine("введите команду: ");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    // какая то функция
                    Console.WriteLine("Выполняется функция ...");
                    break;
                default:
                    _isOpen = false;
                    break;
            }
            Console.ForegroundColor = ConsoleColor.White;
            return _isOpen;
        }
    }
}

