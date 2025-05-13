using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace laba10OK
{
    public class Person
    {
        protected static Random rnd = new Random();
        public static int GetMaxAge => 100;

        static string[] NamesMen = { "Петр", "Павел", "Константин", "Георгий", "Николай", "Михаил", "Сергей" };
        static string[] SurnamesMen = { "Петров", "Павлович", "Константинович", "Георгиевич", "Михайлович", "Сергеевич" };
        static string[] NamesWomen = { "Елизавета", "Наталия", "Лилия", "Ольга", "Марина", "Екатерина", "Алена" };
        static string[] SurnamesWomen = { "Петрова", "Павловна", "Константиновна", "Георгиевна", "Михайловна", "Сергеевна" };

        public string name;
        public string gender;
        public int age;

        // конструктор без параметров
        public Person()
        {
            name = "No Name";
            gender = "No gender";
            age = 0;
        }

        // конструктор с параметрами
        public Person(string _name, string _gender, int _age)
        {
            name = _name;
            gender = _gender;
            age = _age;
        }

        // конструктор копирования
        public Person(Person p)
        {
            this.name = p.name;
            this.gender = p.gender;
            this.age = p.age;
        }
        //метод show для вывода результата
        public virtual void Show()
        {
            Console.WriteLine(name);
            Console.WriteLine($"Пол: {gender}");
            Console.WriteLine($"Возраст: {age}");
        }

        //метод show для вывода Имени
        public virtual void ShowName()
        {
            Console.WriteLine(name);
        }

        // метод init для ввода информации с клавиатуры
        public void Init(Person p)
        {
            Console.WriteLine("Введите имя: ");
            p.name = Console.ReadLine();
            Console.WriteLine("Введите пол: ");
            p.gender = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            p.age = Convert.ToInt32(Console.ReadLine());
        }

        // метод random init для заполнения данных с помощью ДСЧ
        public void RandomInit()
        {
            age = rnd.Next(21, 80);
            int value2 = rnd.Next(1, 3);
            if (value2 == 1)
            {
                gender = "Мужчина";
                name = NamesMen[rnd.Next(NamesMen.Length)] + " " + SurnamesMen[rnd.Next(SurnamesMen.Length)];
            }
            else
            {
                gender = "Женщина";
                name = NamesWomen[rnd.Next(NamesWomen.Length)] + " " + SurnamesWomen[rnd.Next(SurnamesWomen.Length)];
            }
            
        }
        //Метод Equals для сравнения объектов
        public virtual bool Equals(object obj)
        {
            // Проверка на null
            if (obj == null) return false;

            // Проверка на тип
            if (obj.GetType() != this.GetType()) return false;

            // Приведение к типу Person
            var other = (Person)obj;

            // Сравнение ключевых свойств
            return name == other.name && age == other.age && gender == other.gender;
        }

        //метод для вывода имен всех лиц заданного пола
        public static void ShowNamesByGender(int n, Person[] arr)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine("________________________________");
                    Console.WriteLine("ВЫВОД МАССИВА МУЖЧИН");
                    Console.WriteLine("________________________________");
                    int countMen = 0;
                    foreach (Person p in arr)
                    {
                        if (p.gender == "Мужчина")
                        {
                            countMen++;
                            p.ShowName();
                            Console.WriteLine("________________________________");
                        }
                    }
                    Console.WriteLine($"Мужчин {countMen}");
                    break;
                case 2:
                    Console.WriteLine("________________________________");
                    Console.WriteLine("ВЫВОД МАССИВА ЖЕНЩИН");
                    Console.WriteLine("________________________________");
                    int countWomen = 0;
                    foreach (Person p in arr)
                    {
                        if (p.gender == "Женщина")
                        {
                            countWomen++;
                            p.ShowName();
                            Console.WriteLine("________________________________");
                        }
                    }
                    Console.WriteLine($"Женщин {countWomen}");
                    break;
            }
        }

        //метод для вывода имен студентов заданного курса
        public static void ShowNamesByYear(int k, Person[] arr)
        {
            int prov = 0;
            if (k > 0 && 5 > k)
            {
                foreach (Person p in arr)
                {
                    if (p is Student s && s.yearUniversity == k)
                    {
                        p.Show();
                        Console.WriteLine("________________________________");
                        prov++;
                    }
                }
                if (prov == 0)
                {
                    Console.WriteLine("Людей на таком курсе нет");
                }
            }
            else
            {
                Console.WriteLine("Ввели несуществующий курс");
            }
        }

        //метод для вывода имен служащих со стажен не менее заданного
        public static void ShowNamesByExperience(int year, Person[] arr)
        {
            int prov2 = 0;
            foreach (Person p in arr)
            {
                if (p is Employee e && e.experience >= year)
                {
                    p.Show();
                    Console.WriteLine("________________________________");
                    prov2++;
                }
                if (p is Teacher t && t.experience >= year)
                {
                    p.Show();
                    Console.WriteLine("________________________________");
                    prov2++;
                }
            }
            if (prov2 == 0)
            {
                Console.WriteLine("Людей с таким и более стажем нет");
            }
        }
    }

}