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
                    FindEvenNumbers(CreateArray(Convert.ToInt32(Console.ReadLine())));
                }
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения ...");
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
            Console.WriteLine("Массив: ");
            int[] _array = new int[_number];
            Random rand = new Random();
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = rand.Next(100, 1000);
                Console.Write(_array[i] + " ");
            }
            return _array;
        }
        static void FindEvenNumbers(int[] _array)
        {
            int evenNumbers = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] % 2 == 0) evenNumbers++;
            }
            Console.WriteLine();
            Console.WriteLine($"колличество четных чисел:  {evenNumbers}");
        }
        static bool WorkingProcess(bool _isOpen)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Задача 34");
            Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами."
                            + "Напишите программу, которая покажет количество чётных чисел в массиве. "
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