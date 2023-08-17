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

                    Console.WriteLine($"сумма чисел ряда от M до N равна: {SumRow(m, n)}");

                }
            }
            Console.Write("Нажмите любую клавишу для завершения ...");
            Console.ReadKey();
            Console.Clear();
        }

        static int SumRow(int m, int n)
        {
            if (m == 0) return (n * (n + 1)) / 2;            
            else if (n == 0) return (m * (m + 1)) / 2;       
            else if (m == n) return m;                       
            else if (m < n) return n + SumRow(m, n - 1); 
            else return n + SumRow(m, n + 1);            
            
        }


        static bool WorkingProcess(bool _isOpen)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Задача 66: ");
            Console.WriteLine("Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N."
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

