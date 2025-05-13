using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10OK
{
    public class Employee : Person
    {
        static string[] PlaceWork = { "Школа", "Завод", "Магазин" };
        static string[] PostSchool = { "Повар", "Охранник", "Уборщик" };
        static string[] PostFactory = { "Контроллер", "Токарь", "Наладчик" };
        static string[] PostShop = { "Кассир", "Консультант", "Менеджер" };


        public string placeOfWork;
        public string post;
        public int experience;
        // конструктор без параметров
        public Employee() : base()
        {
            placeOfWork = "Нет работы";
            post = "Нет должности";
            experience = 0;
        }
        // конструктор с параметрами
        public Employee(string _name, string _gender, int _age, string _placeOfWork, string _post, int _experience) : base(_name, _gender, _age)
        {
            post = _post;
            placeOfWork = _placeOfWork;
            experience = _experience;
        }

        // конструктор копирования
        public Employee(Employee e)
        {
            this.placeOfWork = e.placeOfWork;
            this.post = e.post;
            this.experience = e.experience;
        }

        //метод show для вывода результата
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Место работы: {placeOfWork}");
            Console.WriteLine($"Должность: {post}");
            Console.WriteLine($"Стаж: {experience}");
        }

        // метод init для ввода информации с клавиатуры
        public void Init(Employee e)
        {
            Console.WriteLine("Введите место работы: ");
            e.placeOfWork = Console.ReadLine();
            Console.WriteLine("Введите должность: ");
            e.post = Console.ReadLine();
            Console.WriteLine("Введите стаж: ");
            e.experience = Convert.ToInt32(Console.ReadLine());
        }

        // метод random init для заполнения данных с помощью ДСЧ
        public void RandomInit()
        {
            base.RandomInit();
            experience = rnd.Next(1, age - 20);
            placeOfWork = PlaceWork[rnd.Next(PlaceWork.Length)];
            if (placeOfWork == "Школа")
            {
                post = PostSchool[rnd.Next(PostSchool.Length)];
            }
            else if (placeOfWork == "Завод")
            {
                post = PostFactory[rnd.Next(PostFactory.Length)];
            }
            else
            {
                post = PostShop[rnd.Next(PostShop.Length)];
            }
        }
    }
}