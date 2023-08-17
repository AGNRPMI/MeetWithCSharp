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
                    
                    FindIntersection(CreateArray(), CreateArray());
                }
            }
            Console.Write("Нажмите любую клавишу для завершения ...");
            Console.ReadKey();
            Console.Clear();
        }

        static double[] CreateArray()
        {
            double[] _array = new double[2];
            Random rand = new Random();
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = Math.Round(rand.NextDouble(),2);
                
            }
            Console.WriteLine($"y = {_array[0]}*x + {_array[1]}");
            return _array;
        }
        static void FindIntersection(double[] _arrayOne, double[] _arrayTwo)
        {
            double x = Math.Round((_arrayTwo[1] - _arrayOne[1]) / (_arrayOne[0] - _arrayTwo[0]),2);
            double y =Math.Round(_arrayOne[0] * x + _arrayOne[1],2);
            Console.WriteLine();
            Console.WriteLine($"Точка пересечения располагается в координате ({x}; {y})");
            Console.WriteLine("нажмите любую клавишу ...");
            Console.ReadKey();
        }
        static bool WorkingProcess(bool _isOpen)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Задача 43: ");
            Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых, "
                            + "заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем."
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

