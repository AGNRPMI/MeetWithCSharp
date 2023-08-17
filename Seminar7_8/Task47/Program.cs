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

                    PrintArray(CreateArray(col, row));
                }
            }
            Console.Write("Нажмите любую клавишу для завершения ...");
            Console.ReadKey();
            Console.Clear();
        }

        static double[,] CreateArray(int col, int row)
        {
            double[,] _array = new double[row, col];
            Random rand = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                    _array[i, j] = rand.Next(-100, 101) + Math.Round(rand.NextDouble(), 2);
            }
            Console.WriteLine();

            return _array;
        }
        static void PrintArray(double[,] _array)
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
        static bool WorkingProcess(bool _isOpen)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Задача 47: ");
            Console.WriteLine("Задайте двумерный массив размером m×n, заполненный случайными вещественными числами."
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

