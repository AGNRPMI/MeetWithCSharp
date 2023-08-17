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
                    Console.Write("введи некоторое количество слов/чисел/символов через пробел (пример 5ыва+++ 3345345 впав345) ");
                    string[] aray = Console.ReadLine()!.Split();
                    Console.WriteLine("Введи число N, которое покажет массив строк,"
                                     + "которые по длине не будут превышать данное число N"
                                     + "(пример 3 - покажет строки длиной 3 и менее символов): ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    arrFunc(aray, number);

                }
            }
            Console.Write("Нажмите любую клавишу для завершения ...");
            Console.ReadKey();
            Console.Clear();
        }

        static void arrFunc(string[] arr, int num)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length <= num) temp++;
            }

            if (arr.Length == 0)
            {
                Console.WriteLine("вы ввели пустой массив");
            }

            else if (temp == 0)
            {
                Console.WriteLine($"во введенном массиве нет строк короче {num}");
            }
            else
            {
                Console.WriteLine($"элементы массива, длина которых меньше или равна {num}:");
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j].Length <= num) Console.Write($"{arr[j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }



        static bool WorkingProcess(bool _isOpen)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Итоговая контрольная работа по основному блоку: ");
            Console.WriteLine("Написать программу, которая из имеющегося массива строк"
                            + "формирует новый массив из строк, длина которых меньше, "
                            + "либо равна 3 символам. "
                            + "Первоначальный массив можно ввести с клавиатуры,"
                            + "либо задать на старте выполнения алгоритма. "
                            + "При решении не рекомендуется пользоваться коллекциями, "
                            + "лучше обойтись исключительно массивами."
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


