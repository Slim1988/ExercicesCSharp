// See https://aka.ms/new-console-template for more information

using System;

namespace exercice2
{
    public sealed class Student :IStudent
    {
        public  string name;
        public  string age;
        public  DateTime dateofbirth;
        public Matiere best_Mt;
        public string Name { get; set; }

        public  string FirstName { get; set; }
        private int Age;
        public Student(string name, string firstname, DateTime DateOfBirth)
        {
            Name = name;
            FirstName = firstname;
            dateofbirth = DateOfBirth;
        
            Age = Calcul.GetAge(dateofbirth);
            Console.WriteLine("l'étudiant {0} {1} à pour age:{2}",name,FirstName, Age);
        }
        public int GetAge2()
        {
            return 1;
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(1986, 10, 06);
            Console.WriteLine(d.Year);
            Student a = new Student("nouha", "beltaief", d);
            a.best_Mt = Matiere.Math;
            Console.WriteLine(a.GetAge2() + "  "+a.best_Mt);

        }
    }
}

