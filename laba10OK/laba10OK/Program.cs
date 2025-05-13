using System;

namespace laba10OK
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("________________Персоны________________");
            Person p1 = new Person();
            p1.Show();
            Console.WriteLine("________________________________");
            Person p2 = new Person("Петров петр петрович", "Мужчина", 23);
            p2.Show();
            Console.WriteLine("________________________________");
            Person p3 = new Person();
            p3.RandomInit();
            p3.Show();
            Console.WriteLine("________________________________");
            Person p4 = new Person("Петров петр петрович", "Мужчина", 23);
            p4.Show();

            Console.WriteLine("_______________Студенты_________________");
            Student s1 = new Student();
            s1.Show();
            Console.WriteLine("________________________________");
            Student s2 = new Student("Петров петр петрович", "Мужчина", 23, "ПНИПУ", 3);
            s2.Show();
            Console.WriteLine("________________________________");
            Console.WriteLine("рандом");
            Student s3 = new Student();
            s3.RandomInit();
            s3.Show();
            Console.WriteLine("________________________________");
            Student s4 = new Student("Петров петр петрович", "Мужчина", 23, "ПНИПУ", 3);
            s4.Show();

            Console.WriteLine("______________Учителя__________________");
            Teacher t1 = new Teacher();
            t1.Show();
            Console.WriteLine("________________________________");
            Teacher t2 = new Teacher("Иванов Иван Иванович", "Мужчина", 53, "Школа", 20);
            t2.Show();
            Console.WriteLine("________________________________");
            Teacher t3 = new Teacher();
            t3.RandomInit();
            t3.Show();
            Console.WriteLine("________________________________");

            Console.WriteLine("______________Рабочие__________________");
            Employee e1 = new Employee();
            e1.Show();
            Console.WriteLine("________________________________");
            Employee e2 = new Employee("Норматова Галина Сергеевна", "Женщина", 35, "Ресторан", "Шеф-повар", 10);
            e2.Show();
            Console.WriteLine("________________________________");


            //Person p3 = new Person();
            p3.RandomInit();
            //Student s3 = new Student();
            s3.RandomInit();
            //Teacher t3 = new Teacher();
            t3.RandomInit();
            Employee e3 = new Employee();
            e3.RandomInit();
            //e3.Show();
            Console.WriteLine("________________________________");
            Console.WriteLine("ВЫВОД МАССИВА");
            Console.WriteLine("________________________________");
            Person[] arr = { p3, s3, t3, e3 };
            foreach (Person p in arr)
            {
                p.Show();
                Console.WriteLine("________________________________");
            }

            Console.WriteLine($"Равны ли {p3.name} и {p4.name}: {p3.Equals(p4)}"); // проверка на равенство Person
            Console.WriteLine($"Равны ли {s2.name} и {s4.name}: {s2.Equals(s4)}"); // проверка на равенство Student
                    
        }
    }
}