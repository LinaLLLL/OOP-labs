using Microsoft.Win32;
using System;
using System.Diagnostics;

namespace _2laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение X: ");
            double X = double.Parse(Console.ReadLine());

            Console.Write("Введите значение n: ");
            int n = int.Parse(Console.ReadLine());

            double Sum = 0;
            int i = 1;

            do
            {
                Sum += Math.Sin(Math.Pow(X, i));
                i++;
            } while (i <= n);

            Console.WriteLine($"Сумма Sum = {Sum}");
        }
    }
}