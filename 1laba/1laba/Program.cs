using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 задание 5 вариант
            /*Console.WriteLine("Введите два числа:");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--m-n++");
            Console.WriteLine(--m - n++);
            Console.WriteLine($"m = {m}");
            Console.WriteLine($"n = {n}");
            Console.WriteLine("m*m<n++");
            bool one = m * m < n++;
            Console.WriteLine(one);
            Console.WriteLine($"m = {m}");
            Console.WriteLine($"n = {n}");
            Console.WriteLine("n-->++m");
            bool two = n-- > ++m;
            Console.WriteLine(two);
            Console.WriteLine("Введите х:");
            int x = Convert.ToInt32(Console.ReadLine());
            double tang = Math.Tan(x);
            double result = tang - Math.Pow((5 - x), 4);
            Console.WriteLine(result);
            Console.ReadLine();*/

            //2 задание 5 вариант

            /*
            int x1 = 1;
            int x2 = 0;
            int y1 = 1;
            int y2 = -1;
            Console.WriteLine("Введите х и у:");
            double m = Convert.ToDouble(Console.ReadLine());
            double n = Convert.ToDouble(Console.ReadLine());
            if (m >= x2 && m <= x1 && n >= y2 && n <= y1)
            {
                Console.WriteLine($"Точка ({m};{n}) лежит в заштрихованной области");
            }
            else
            {
                Console.WriteLine($"Точка ({m};{n}) не лежит в заштрихованной области");
            }
            Console.ReadLine();
            */

            //3 задание 5 вариант

            double a = 1000;
            double b = 0.0001;
            Console.WriteLine($"Число а = {a}, число b = {b}");
            double one = (Math.Pow((a - b), 3))-(Math.Pow(a, 3) - 3 * Math.Pow(a, 2) * b);
            double two = 3*a*Math.Pow(b, 2)-Math.Pow(b,3);
            double result = one / two;
            Console.WriteLine($"Результат с типом данных double = {result}");
            float a1 = 1000F;
            float b1 = 0.0001F;
            Console.WriteLine($"Число а = {a1}, число b = {b1}");
            float one1 = (float)Math.Pow((a1 - b1), 3) - (float)(Math.Pow(a1, 3) - 3 * (float)Math.Pow(a1, 2) * b1);
            float two1 = 3 * a1 * (float)Math.Pow(b1, 2) - (float)Math.Pow(b1, 3);
            float result1 = one1 / two1;
            Console.WriteLine($"Результат с типом данных float = {result1}");
            Console.ReadLine();

        }
    }
}
