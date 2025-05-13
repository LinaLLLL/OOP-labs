using _9laba;
class Program
{
    static void Main()
    {
        // Создание объектов класса Diapason
        Diapason diapason1 = new Diapason(1, 10);
        Diapason diapason2 = new Diapason(20, 30);

        // Демонстрация работы с объектами
        diapason1.Show();
        diapason2.Show();

        // Проверка с использованием статической функции
        double number = 5;
        Console.WriteLine($"Число {number} в первом диапазоне: {Diapason.IsInRange(number, diapason1)}");

        // Проверка с использованием метода экземпляра
        number = 25;
        Console.WriteLine($"Число {number} во втором диапазоне: {diapason2.CheckInRange(number)}");

        // Подсчет количества объектов
        Console.WriteLine($"Количество созданных объектов: {Diapason.GetObjectCount()}");

        // Использование операции "!"
        Console.WriteLine($"Длина первого диапазона: {diapason1.Length()}");

        // Использование операции "++"
        diapason1.Increment();
        Console.WriteLine("После увеличения координат на 1:");
        diapason1.Show();

        // Приведение типов
        int xAsInt = (int)diapason1;  // Явное приведение
        double yAsDouble = diapason1; // Неявное приведение
        Console.WriteLine($"Явное приведение к int: {xAsInt}");
        Console.WriteLine($"Неявное приведение к double: {yAsDouble}");

        // Использование операции "+"
        diapason1 = diapason1 + 5;
        Console.WriteLine("После увеличения координат на 5:");
        diapason1.Show();

        // Использование операции "<"
        int value = 7;
        Console.WriteLine($"Число {value} попадает в первый диапазон: {diapason1 < value}");
    }
}