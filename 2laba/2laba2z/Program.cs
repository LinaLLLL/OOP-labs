//30.	Дана последовательность целых чисел, за которой следует 0.
//Найти количество четных элементов этой последовательности.

using Microsoft.Win32;
using System;
using System.Diagnostics;

namespace _2laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countEven = 0;
            int number;

            Console.WriteLine("Введите последовательность чисел, оканчивающуюся 0:");
            while (true)  //бесконечный цикл
            {
                number = int.Parse(Console.ReadLine());

                if (number == 0)
                    break;

                if (number % 2 == 0)
                    countEven++;
            }
            Console.WriteLine($"Количество чётных элементов в последовательности: {countEven}");
        }
    }
}