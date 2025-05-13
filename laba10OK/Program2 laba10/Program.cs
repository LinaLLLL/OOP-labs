using System;


namespace laba10OK
{
    class Program2
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.RandomInit();
            Person p2 = new Person();
            p2.RandomInit();
            Person p3 = new Person();
            p3.RandomInit();

            Student s1 = new Student();
            s1.RandomInit();
            Student s2 = new Student();
            s2.RandomInit();
            Student s3 = new Student();
            s3.RandomInit();
            Student s4 = new Student();
            s4.RandomInit();
            Student s5 = new Student();
            s5.RandomInit();

            Teacher t1 = new Teacher();
            t1.RandomInit();
            Teacher t2 = new Teacher();
            t2.RandomInit();
            Teacher t3 = new Teacher();
            t3.RandomInit();

            Employee e1 = new Employee();
            e1.RandomInit();
            Employee e2 = new Employee();
            e2.RandomInit();
            Employee e3 = new Employee();
            e3.RandomInit();
            Employee e4 = new Employee();
            e4.RandomInit();
            Employee e5 = new Employee();
            e5.RandomInit();

            Console.WriteLine("________________________________");
            Console.WriteLine("ВЫВОД МАССИВА");
            Console.WriteLine("________________________________");
            Person[] arr = { p1, p2, p3, s1, s2, s3, s4, s5, t1, t2, t3, e1, e2, e3, e4, e5 }; //16 человек
            foreach (Person p in arr)
            {
                p.Show();
                Console.WriteLine("________________________________");
            }
            //1 запрос: Имена всех лиц мужского (женского) пола.
            Console.WriteLine("1)Мужчины \n2)женщины?");
            int num = Convert.ToInt32(Console.ReadLine());
            
            Person.ShowNamesByGender(num, arr);

            //2 запрос: Имена студентов указанного курса.
            Console.WriteLine("\nВведите курс(1-5):");
            int k = Convert.ToInt32(Console.ReadLine());
            
            Person.ShowNamesByYear(k, arr);

            //3 запрос: Имена служащих со стажем не менее заданного.
            Console.WriteLine("\nВведите стаж:");
            int year = Convert.ToInt32(Console.ReadLine());
            
            Person.ShowNamesByExperience(year, arr);
        }
    }
}
