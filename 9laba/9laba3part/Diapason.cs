using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9laba3part
{
    internal class Diapason
    {
        // Одномерный массив для хранения значений
        private double[] array;

        // Статическая переменная для подсчета объектов
        private static int objectCount = 0;

        // Конструктор без параметров
        public Diapason()
        {
            array = new double[0]; // Инициализация пустым массивом
            objectCount++;
        }

        // Конструктор с параметром для заполнения массива случайными значениями
        public Diapason(int size, double minValue, double maxValue)
        {
            array = new double[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.NextDouble() * (maxValue - minValue) + minValue; //rand.NextDouble() генерирует число от 0,0 до 1,0
            }
            objectCount++;
        }

        // Конструктор с параметром для ввода элементов массива с клавиатуры
        public Diapason(int size)
        {
            array = new double[size];
            Console.WriteLine($"Введите {size} элементов:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            objectCount++;
        }

        // Метод для просмотра элементов массива
        public void Show()
        {
            Console.WriteLine("Элементы массива:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Элемент {i + 1}: {array[i]}");
            }
        }

        // Индексатор для доступа к элементам массива
        public double this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Индекс выходит за пределы массива.");
                }
            }
            set
            {
                if (index >= 0 && index < array.Length)
                {
                    array[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Индекс выходит за пределы массива.");
                }
            }
        }

        // Статический метод для подсчета количества созданных объектов
        public static int GetObjectCount()
        {
            return objectCount;
        }

        // Метод для нахождения максимального значения в массиве
        public double MaxValue()
        {
            if (array.Length == 0)
                throw new InvalidOperationException("Массив пуст.");

            double max = array[0];
            foreach (double value in array)
            {
                if (value > max)
                    max = value;
            }
            return max;
        }
    }
}
