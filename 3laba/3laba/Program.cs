// 5 вариант

using Microsoft.Win32;
using System;
using System.Diagnostics;

namespace _2laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x =1;
            int a = 1; 
            int b = 2;
            int n = 15;
            int k = 10;
            double sum1 = 1;
            double step = (b - a) / k;
            for (int i = 1; i < n; i++) {
                int factorial = 1;
                factorial *= i;
                while (x <= b)
                {
                    sum1 += (Math.Pow(x, i) / (factorial));
                    Console.WriteLine(sum1);
                    x += step;
                }
            }
        }
    }
}