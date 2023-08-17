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
                    Console.WriteLine("Сортировка отдельных строк по возрастанию: ");
                    int[,] sortArray = SortingSingleRow(array, row, col, true);
                    PrintArray(sortArray);
                    Console.WriteLine("Сортировка отдельных по убыванию: ");
                    sortArray = SortingSingleRow(array, row, col, false);
                    PrintArray(sortArray);
                    Console.WriteLine("Сортировка всех элементов по возрастанию: ");
                    sortArray = SortingAllRow(array, row, col, true);
                    PrintArray(sortArray);
                    Console.WriteLine("Сортировка всех элементов по убыванию: ");
                    sortArray = SortingAllRow(array, row, col, false);
                    PrintArray(sortArray);
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
        static int[,] SortingAllRow(int[,] array2D, int row, int col, bool upOrDown)
        {
            int[] tempArray = new int[row * col];
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    tempArray[i * col + j] = array2D[i, j];
                }
            }
            Array.Sort(tempArray);
            if (upOrDown == false) Array.Reverse(tempArray);
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    array2D[i, j] = tempArray[i * col + j];
                }
            }
            return array2D;
        }

        static int[,] SortingSingleRow(int[,] array2D, int row, int col, bool upOrDown)
        {
            int[] tempArray = new int[col];
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    tempArray[j] = array2D[i, j];
                }
                Array.Sort(tempArray);
                if (upOrDown == false) Array.Reverse(tempArray);
                for (int k = 0; k < array2D.GetLength(0); k++)
                {
                    for (int j = 0; j < array2D.GetLength(1); j++)
                    {
                        array2D[i, j] = tempArray[j];
                    }
                }
            }


            return array2D;
        }


        static bool WorkingProcess(bool _isOpen)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Задача 54: ");
            Console.WriteLine("Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива."
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

