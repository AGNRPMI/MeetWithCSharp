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
                    int[,] array = CreateArray(row, col);
                    Console.WriteLine("Сгенерированный массив: ");
                    PrintArray(array);
                    FindMinimalSumRow(array);
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
        static void FindMinimalSumRow(int[,] array2D)
        {
            int sum = 0;
            int sumRow = 0;
            int row = 1;
            for (int i = 0; i < array2D.GetLength(0); i++)
            {

                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    sumRow += array2D[i, j];
                }
                Console.WriteLine($"сумма чисел в строке {i + 1} составляет {sumRow}");
                if (sumRow < sum)
                {
                    sum = sumRow;
                    row = i;
                }
            }
            Console.WriteLine($"наименьшаяя сумма в строке {row + 1} составляет {sum}");
        }


        static bool WorkingProcess(bool _isOpen)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Задача 56: ");
            Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов."
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

