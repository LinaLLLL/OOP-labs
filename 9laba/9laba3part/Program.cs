using _9laba3part;

class Program
{
    static void Main()
    {
        // Создание объектов с разными конструкторами
        Diapason diapason1 = new Diapason();  // Пустой массив
        Diapason diapason2 = new Diapason(5, 1.0, 10.0); // Массив случайных значений
        Diapason diapason3 = new Diapason(3);  // Массив с вводом пользователя

        // Вывод элементов массива
        diapason2.Show();
        diapason3.Show();

        // Попытка доступа через индексатор
        try
        {
            Console.WriteLine($"Первый элемент diapason2: {diapason2[0]}");
            diapason2[2] = 7.5;  // Изменение значения
            Console.WriteLine($"Третий элемент diapason2 после изменения: {diapason2[2]}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        // Подсчет количества созданных объектов
        Console.WriteLine($"Количество созданных объектов: {Diapason.GetObjectCount()}");

        // Нахождение максимального значения в массиве
        try
        {
            double maxValue = diapason2.MaxValue();
            Console.WriteLine($"Максимальное значение в diapason2: {maxValue}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}