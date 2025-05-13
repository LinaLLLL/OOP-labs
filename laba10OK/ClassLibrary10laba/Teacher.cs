using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10OK
{
    public class Teacher : Person
    {
        static string[] PlaceWork = { "Школа", "ПНИПУ", "ПГНИУ" };

        public int experience;
        public string placeWork;
        // конструктор без параметров
        public Teacher() : base()
        {
            placeWork = "No work";
            experience = 0;
        }
        // конструктор с параметрами
        public Teacher(string _name, string _gender, int _age, string _placeOfWork, int _experience) : base(_name, _gender, _age)
        {
            placeWork = _placeOfWork;
            experience = _experience;
        }

        // конструктор копирования
        public Teacher(Teacher t)
        {
            this.placeWork = t.placeWork;
            this.experience = t.experience;
        }

        //метод show для вывода результата
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Место работы: {placeWork}");
            Console.WriteLine($"Стаж: {experience}");
        }

        // метод init для ввода информации с клавиатуры
        public void Init(Teacher t)
        {
            Console.WriteLine("Введите место работы: ");
            t.placeWork = Console.ReadLine();
            Console.WriteLine("Введите стаж: ");
            t.experience = Convert.ToInt32(Console.ReadLine());
        }

        // метод random init для заполнения данных с помощью ДСЧ
        public void RandomInit()
        {
            base.RandomInit();
            experience = rnd.Next(1, age - 20); // age-20 необходимо для того чтобы возраст был больше стажа
            placeWork = PlaceWork[rnd.Next(PlaceWork.Length)];
        }
    }
}