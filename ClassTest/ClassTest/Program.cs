using System;

namespace ClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.WriteLine("Adinizi daxil edin");
            student.Name =  Console.ReadLine();

            Console.WriteLine("Soyadinizi daxil edin");
            student.Surname = Console.ReadLine();

            Console.WriteLine("Qrupunuzu daxil edin");
            student.Group = Console.ReadLine();

            Console.WriteLine("Adiniz " + student.Name + " \nSoyadiniz: " + student.Surname + " \nQrupunuz " + student.Group);
            Console.ReadLine();

        }
    }



    class Group
    {
        public string Name { get; set; }
    }
    class Student
    {
        Group group = new Group();
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Group
        {
            get
            {
                return group.Name;
            }
            set
            {
                group.Name = value;
            }
        }

    }
}
