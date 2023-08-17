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
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введи количество столбцов: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введи стартовое число: ");
                    int startNumber = Convert.ToInt32(Console.ReadLine());

                    int[,] array2D = CreateSpiralArray(a, b, startNumber);

                    PrintArray2D(array2D);

                }
            }
            Console.Write("Нажмите любую клавишу для завершения ...");
            Console.ReadKey();
            Console.Clear();
        }

        static int[,] CreateSpiralArray(int a, int b, int startNumber)
        {

            int[,] array = new int[a, b];
            array[0, 0] = startNumber;
            int size = a * b;
            int x = 0, y = 0;
            while (size > 0)
            {
                for (int i = y; i <= y + b - 1; i++)
                {
                    array[x, i] = startNumber++;
                }

                for (int j = x + 1; j <= x + a - 1; j++)
                {
                    array[j, y + b - 1] = startNumber++;
                }

                for (int i = y + b - 2; i >= y; i--)
                {
                    array[x + a - 1, i] = startNumber++;
                }

                for (int i = x + a - 2; i >= x + 1; i--)
                {
                    array[i, y] = startNumber++;
                }
                x = x + 1;
                y = y + 1;
                size = size - 2 * (a + b);
                a = a - 2;
                b = b - 2;

            }

            return array;

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
                {
                    if (_array[i, j] < 10) Console.Write("0" + _array[i, j] + " ");
                    else Console.Write(_array[i, j] + " ");
                }
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
            Console.WriteLine("Задача 62: ");
            Console.WriteLine("Напишите программу, которая заполнит спирально массив 4 на 4"
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

