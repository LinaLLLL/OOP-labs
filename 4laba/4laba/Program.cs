using Microsoft.Win32;
using System;
using System.Diagnostics;

namespace _2laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов в массиве: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(1,10);
            }

            Console.WriteLine("Массив:");
            for (int i = 0;i < n; i++)
            {
                Console.Write($"{arr[i]}, ");

            }

            Console.WriteLine("\n1. Удаление четных элементов");
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    count++;
                }
            }
            int[] arr2 = new int[count];
            int j = 0;  
            for(int i = 0; i < arr2.Length; i++)
            {
                while(j < arr.Length)
                {
                    if(arr[j] % 2 != 0)
                    {
                        arr2[i] = arr[j];
                        j++;
                        break;
                    }
                    j++;
                }
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($"{arr2[i]}, ");

            }

            Console.WriteLine("\n2. Добавление К элементов в начало массива");
            Console.WriteLine("Введите число элементов:");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] arr3 = new int[arr.Length+k];
            for(int i = 0; i < k; i++)
            {
                arr3[i] = rnd.Next(1, 10);
            }
            
            for (int o = 0; o < arr.Length; o++)
            { 
                arr3[k] = arr[o];
                k++;
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write($"{arr3[i]}, ");
            }

            Console.WriteLine("\n3. Четные элементы массива поставить в начало, нечетные в конец");
            int[] arr4 = new int[arr.Length];
            int p = 0;
            for(int i = 0;i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr4[p] = arr[i];
                    p++;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    arr4[p] = arr[i];
                    p++;
                }
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < arr4.Length; i++)
            {
                Console.Write($"{arr4[i]}, ");
            }

            Console.WriteLine("\n4. Поиск первого четного элемента");
            Console.WriteLine("Массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            int el = 0;
            for(int i = 0;i<arr.Length; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    Console.WriteLine($"\nПервый четный элемент - {arr[i]}");
                    el++;
                    Console.WriteLine($"Количество сравнений - {el}");
                    break;
                }
            }

            Console.WriteLine("5. Сортировка - простой выбор"); // что за простой выбор
        }
    }
}