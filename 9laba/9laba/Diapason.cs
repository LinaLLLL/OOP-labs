using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9laba
{
    public class Diapason
    {
        // Статическая переменная для подсчета объектов
        private static int objectCount = 0;

        // Закрытые атрибуты
        private double x;
        private double y;

        // Конструктор для инициализации диапазона
        public Diapason(double x, double y)
        {
            this.x = x;
            this.y = y;
            objectCount++; // Увеличиваем счетчик объектов
        }

        // Свойства для доступа к закрытым атрибутам
        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        // Статическая функция для проверки, попадает ли число в диапазон
        public static bool IsInRange(double value, Diapason diapason)
        {
            return diapason.X <= value && value <= diapason.Y;
        }

        // Метод экземпляра для проверки, попадает ли число в диапазон
        public bool CheckInRange(double value)
        {
            return this.X <= value && value <= this.Y;
        }

        // Статическая функция для подсчета количества объектов
        public static int GetObjectCount()
        {
            return objectCount;
        }

        // Метод для вывода информации о диапазоне
        public void Show()
        {
            Console.WriteLine($"Диапазон: от {X} до {Y}");
        }
        // Унарная операция "!" для вычисления длины диапазона
        public double Length()
        {
            return this.Y - this.X;
        }

        // Операция "++" для увеличения координат на 1
        public void Increment()
        {
            this.x += 1;
            this.y += 1;
        }

        // Явное приведение типа (int) - целая часть координаты X
        public static explicit operator int(Diapason diapason)
        {
            return (int)diapason.X;
        }

        // Неявное приведение типа (double) - координата Y
        public static implicit operator double(Diapason diapason)
        {
            return diapason.Y;
        }

        // Бинарная операция "+" для увеличения координат на число
        public static Diapason operator +(Diapason diapason, int d)
        {
            return new Diapason(diapason.X + d, diapason.Y + d);
        }

        // Бинарная операция "<" для проверки, попадает ли число в диапазон
        public static bool operator <(Diapason diapason, int value)
        {
            return value >= diapason.X && value <= diapason.Y;
        }
        // Бинарная операция ">" для проверки, больше ли число, чем диапазон
        public static bool operator >(Diapason diapason, int value)
        {
            return value > diapason.Y;
        }

        // Статическая функция для подсчета количества объектов
        public static int CountObjects()
        {
            return objectCount;
        }
    }
}
