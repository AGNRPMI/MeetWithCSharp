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
                    Console.Write("Введи целое число больше 2: ");
                    FindDiffMaxMin(CreateArray(Convert.ToInt32(Console.ReadLine())));
                }
            }
            Console.Write("Нажмите любую клавишу для завершения ...");
            Console.ReadKey();
            Console.Clear();
        }

        static double[] CreateArray(int _number)
        {
            while (_number <= 2)
            {
                Console.WriteLine("Введи целое число больше 2: ");
                _number = Convert.ToInt32(Console.Read());
            }
            Console.WriteLine($"Массив из {_number} чисел: ");
            double[] _array = new double[_number];
            Random rand = new Random();
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = rand.Next(-100,101)+Math.Round(rand.NextDouble(),2);
                Console.Write(_array[i] + " ");
            }
            return _array;
        }
        static void FindDiffMaxMin(double[] _array)
        {
            double min = _array[0];
            double max = _array[0];
            for (int i = 1; i < _array.Length; i++)
            {
                if (_array[i]<min) min = _array[i];
                if (_array[i]>max) max = _array[i];
            }
            double diffMinMax = Math.Round(max - min,2);
            Console.WriteLine();
            Console.WriteLine($"Разница между максимальным {max} и минималным {min} составляет:  {diffMinMax}");
            Console.WriteLine("нажмите любую клавишу ...");
            Console.ReadKey();
        }
        static bool WorkingProcess(bool _isOpen)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Задача 38: ");
            Console.WriteLine("Задайте массив вещественных чисел. "
                            + "Найдите разницу между максимальным и минимальным элементов массива."
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

