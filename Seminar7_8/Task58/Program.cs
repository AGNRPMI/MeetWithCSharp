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
                    Console.WriteLine("Введи количество строк матрицы А: ");
                    int rowA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введи количество столбцов матрицы А: ");
                    int colA = Convert.ToInt32(Console.ReadLine());
                    int[,] arrayA = CreateArray(rowA, colA);

                    Console.WriteLine("Введи количество строк матрицы Б: ");
                    int rowB = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введи количество столбцов матрицы Б: ");
                    int colB = Convert.ToInt32(Console.ReadLine());
                    int[,] arrayB = CreateArray(rowB, colB);

                    Console.WriteLine("Сгенерированная матрица А: ");
                    PrintArray(arrayA);

                    Console.WriteLine("Сгенерированная матрица Б: ");
                    PrintArray(arrayB);




                    PrintArray(Multiplication(arrayA, arrayB));
                }
            }
            Console.Write("Нажмите любую клавишу для завершения ...");
            Console.ReadKey();
            Console.Clear();
        }

        static int[,] CreateArray(int row, int col)
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
        static int[,] Multiplication(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            Console.WriteLine("Перемножение матриц А и Б: ");
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }
        static bool WorkingProcess(bool _isOpen)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Задача 58: ");
            Console.WriteLine("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.."
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

