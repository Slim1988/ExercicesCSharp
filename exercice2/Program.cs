// See https://aka.ms/new-console-template for more information

using System;

namespace exercice2
{
    public sealed class Student
    {
        public  string name;
        public  string age;
        public  DateTime dateofbirth;
        public string Name { get; set; }

        public  string FirstName { get; set; }
        private int Age;
        public Student(string name, string firstname, DateTime DateOfBirth)
        {
            Name = name;
            FirstName = firstname;
            Age = GetAge.calcul(DateOfBirth);
            Console.WriteLine("l'étudiant " + Name + " " + FirstName + " à pour age:" + Age);
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {   DateTime d = new DateTime(1986,10,06);
            Student a = new Student("nouha", "beltaief",d);

        }
    }
}

