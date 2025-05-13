using System;

namespace Laba10part3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать массив из объектов разных классов из созданной иерархии.
            //Реализовать сортировку элементов массива,
            //используя стандартный интерфейс IComparable и метод Sort класса Array.
            Person p3 = new Person();
            p3.RandomInit();
            Student s3 = new Student();
            s3.RandomInit();
            Teacher t3 = new Teacher();
            t3.RandomInit();
            Employee e3 =new Employee();
            e3.RandomInit();
            Console.WriteLine("________________________________");
            Console.WriteLine("ВЫВОД МАССИВА");
            Console.WriteLine("________________________________");
            Person[] person = { p3, s3, t3, e3 };
            foreach (Person p in person)
            {
                Console.WriteLine(p);
            }

            // используется метод CompareTo
            Array.Sort(person);
            Console.WriteLine("________________________________");
            Console.WriteLine("ВЫВОД ОТСОРТИРОВАННОГО ПО АЛФАВИТУ МАССИВА (используется compareTo)");
            Console.WriteLine("________________________________");
            foreach (Person p in person)
            {
                Console.WriteLine(p);
            }

            //Реализовать сортировку (по другому критерию) и поиск элемента в массиве,
            //используя стандартный интерфейс ICompare и метод Sort класса Array.
            PersonAgeComparer ageComparer = new PersonAgeComparer();
            Array.Sort(person, ageComparer);
            Console.WriteLine("________________________________");
            Console.WriteLine("ВЫВОД ОТСОРТИРОВАННОГО ПО ВОЗРАСТУ МАССИВА (используется array.sort)");
            Console.WriteLine("________________________________");
            foreach (Person p in person)
            {
                Console.WriteLine(p);
            }

            // Элемент для поиска (поиск будет по возрасту)
            Person searchPerson = new Person(0,"Неважно", "Неважно", 36); // Возраст - ключ для поиска
            // Поиск элемента
            int index = Array.BinarySearch(person, searchPerson, ageComparer);

            // Результат поиска
            if (index >= 0)
            {
                Console.WriteLine($"\nЭлемент найден: {person[index]} (индекс: {index})");
            }
            else
            {
                Console.WriteLine("\nЭлемент не найден.");
            }

            //Реализовать бинарный поиск.
            // Выполняем бинарный поиск
            Console.WriteLine("Выполняем бинарный поиск");
            Console.WriteLine("\nВведите возраст для поиска:");
            int searchAge = int.Parse(Console.ReadLine());

            Person searchPerson2 = new Person(0, "Неважно", "Неважно", searchAge);
            int index2 = Array.BinarySearch(person, searchPerson2, ageComparer);

            if (index2 >= 0)
            {
                Console.WriteLine($"\nЭлемент найден: {person[index2]} (индекс: {index2})");
            }
            else
            {
                Console.WriteLine("\nЭлемент не найден.");
            }

            //Создать класс, не относящийся к иерархии классов, но реализующий интерфейс IInit.
            //Создать массив элементов типа IInit и поместить в него экземпляры различных классов иерархии и нового класса.
            //Выполнить просмотр массива, показать работу методов Init() и RandomInit().
            Console.WriteLine("\nПроверка Init RandomInit с новым классом");
            IInit[] arr = new IInit[10];
            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    Employee e = new Employee();
                    e.RandomInit();
                    arr[i] = e;
                }
                else
                {
                    Student s = new Student();
                    s.RandomInit();
                    arr[i] = s;
                }
            }
            for (int i = 5; i < 10; i++)
            {
                arr[i] = new Animal();
                arr[i].RandomInit();
            }

            foreach (IInit x in arr)
            {
                Console.WriteLine(x);
            }

            //Реализовать метод клонирования объектов из интерфейса IClonable.
            //Показать разницу между клонированием и поверхностным копированием объектов.
            //Для поверхностного копирования написать метод ShallowCopy(),
            //в котором использовать метод MemberwiseClone() из класса object.
            Console.WriteLine("\nКопирование");
            Student originalStudent = new Student(3,"Иванов Иван Иванович", "Мужчина", 23, "ПНИПУ", 3);
            // Поверхностное копирование
            Student shallowCopy = (Student)originalStudent.ShallowCopy();

            // Глубокое копирование
            Student deepCopy = (Student)originalStudent.Clone();

            // Показ исходных данных
            Console.WriteLine("Оригинальный объект:");
            Console.WriteLine(originalStudent);

            Console.WriteLine("\nПоверхностная копия:");
            Console.WriteLine(shallowCopy);

            Console.WriteLine("\nГлубокая копия:");
            Console.WriteLine(deepCopy);

            // Изменим поле id у оригинального объекта
            originalStudent.id.number = 25;

            Console.WriteLine("\nПосле изменения поля 'id=25' у оригинального объекта:");

            Console.WriteLine("Оригинальный объект:");
            Console.WriteLine(originalStudent);

            Console.WriteLine("Поверхностная копия:");
            Console.WriteLine(shallowCopy);

            Console.WriteLine("Глубокая копия:");
            Console.WriteLine(deepCopy);
        }

    }
}