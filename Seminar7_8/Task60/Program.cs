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
                    Console.WriteLine("Введи размерность А для 3хмерного массива: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введи размерность B для 3хмерного массива: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введи размерность C для 3хмерного массива: ");
                    int c = Convert.ToInt32(Console.ReadLine());

                    int[,,] array3D = CreateArray3D(a, b, c);

                    PrintArray3D(array3D);

                }
            }
            Console.Write("Нажмите любую клавишу для завершения ...");
            Console.ReadKey();
            Console.Clear();
        }

        static int[,] CreateArray2D(int row, int col)
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
        static int[,,] CreateArray3D(int a, int b, int c)
        {
            int[,,] array3d = new int[a, b, c];
            int[] array1d = new int[a * b * c];
            int tempValue = 0;
            int count = 0;
            Random rand = new Random(DateTime.Now.Microsecond);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {
                        array3d[i, j, k] = rand.Next(10, 100);

                        array1d[count] = array3d[i, j, k];
                        tempValue = array3d[i, j, k];
                        while (Array.IndexOf(array1d, tempValue) != -1)
                        {
                            tempValue = array3d[i, j, k] + 1;
                            array3d[i, j, k] = tempValue;
                        }
                        array1d[count] = tempValue;
                        count += 1;
                    }
                }

            }
            Console.WriteLine();

            return array3d;
        }
        static void PrintArray2D(int[,] _array)
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
        static void PrintArray3D(int[,,] _array)
        {

            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    for (int k = 0; k < _array.GetLength(2); k++)
                    {
                        Console.Write($"{_array[i, j, k]}({i};{j};{k}) ");

                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            }

        }



        static bool WorkingProcess(bool _isOpen)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Задача 60: ");
            Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, \nкоторая будет построчно выводить массив, добавляя индексы каждого элемента."
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

