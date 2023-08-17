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
                    Console.WriteLine("Введи число M: ");
                    int m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введи число N: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Функция Аккермана равна: {AkkFunc(m, n)}");

                }
            }
            Console.Write("Нажмите любую клавишу для завершения ...");
            Console.ReadKey();
            Console.Clear();
        }

        static int AkkFunc(int m, int n)
        {
            if (m == 0) return n + 1;
            else if (n == 0) return AkkFunc(m-1, 1);
            else return AkkFunc(m-1, AkkFunc(m, n-1));
        }


        static bool WorkingProcess(bool _isOpen)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Задача 68: ");
            Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n"
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

