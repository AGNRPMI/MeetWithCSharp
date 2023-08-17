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
                    SumOddPositions(CreateArray(Convert.ToInt32(Console.ReadLine())));
                }
            }
            Console.Write("Нажмите любую клавишу для завершения ...");
            Console.ReadKey();
            Console.Clear();
        }

        static int[] CreateArray(int _number)
        {
            while (_number <= 2)
            {
                Console.WriteLine("Введи целое число больше 2: ");
                _number = Convert.ToInt32(Console.Read());
            }
            Console.WriteLine($"Массив из {_number} чисел: ");
            int[] _array = new int[_number];
            Random rand = new Random();
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = rand.Next(-10, 11);
                Console.Write(_array[i] + " ");
            }
            return _array;
        }
        static void SumOddPositions(int[] _array)
        {
            int sumNumbers = 0;
            for (int i = 1; i < _array.Length; i += 2)
            {
                sumNumbers = sumNumbers + _array[i];
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма чисел на нечетных позициях:  {sumNumbers}");
            Console.WriteLine("нажмите любую клавишу ...");
            Console.ReadKey();
        }
        static bool WorkingProcess(bool _isOpen)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Задача 36:");
            Console.WriteLine("Задайте одномерный массив, заполненный случайными числами."
                            + "Найдите сумму элементов, стоящих на нечётных позициях. "
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

