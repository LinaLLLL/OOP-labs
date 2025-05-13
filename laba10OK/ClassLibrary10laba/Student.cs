using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10OK
{
    public class Student : Person
    {
        static string[] PlaceStudy = { "ПНИПУ", "ПГНИУ", "Педагогический университет" };

        public string placeStudy;
        public int yearUniversity;

        // конструктор без параметров
        public Student() : base()
        {
            placeStudy = "No university";
            yearUniversity = 0;
        }
        // конструктор с параметрами
        public Student(string _name, string _gender, int _age, string _placeOfStudy, int _yearUniversity) : base(_name, _gender, _age)
        {
            placeStudy = _placeOfStudy;
            yearUniversity = _yearUniversity;
        }

        // конструктор копирования
        public Student(Student s)
        {
            this.placeStudy = s.placeStudy;
            this.yearUniversity = s.yearUniversity;
        }

        //метод show для вывода результата
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Место учебы: {placeStudy}");
            Console.WriteLine($"Курс: {yearUniversity}");
        }

        // метод init для ввода информации с клавиатуры
        public void Init(Student s)
        {
            Console.WriteLine("Введите университет: ");
            s.placeStudy = Console.ReadLine();
            Console.WriteLine("Введите год обучения: ");
            s.yearUniversity = Convert.ToInt32(Console.ReadLine());
        }

        // метод random init для заполнения данных с помощью ДСЧ
        public new void RandomInit()
        {
            base.RandomInit();
            placeStudy = PlaceStudy[rnd.Next(PlaceStudy.Length)];
            yearUniversity = rnd.Next(0, 6);
        }
        //Метод Equals для сравнения объектов
        public override bool Equals(object obj)
        {
            // Сравниваем базовые свойства
            if (!base.Equals(obj)) return false;

            // Приведение к типу Student
            var other = (Student)obj;

            // Сравнение ключевых свойств
            return placeStudy == other.placeStudy && yearUniversity == other.yearUniversity;
        }
    }
}