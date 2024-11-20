using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> {2341, 789, 1998, 2000};
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());

            Console.WriteLine("\n");

            //suma pe pozitii pare
            int suma = list.Where((num, index) => index % 2 == 0).Sum();
            Console.WriteLine(suma);

            Console.WriteLine("\n");

            //cmmn din primele cifre
            var primaCifra = list.Select(n => int.Parse(n.ToString().Substring(0, 1)));
            var sortare = primaCifra.OrderByDescending(d => d);
            int maxNumber = int.Parse(string.Join("", sortare));
            Console.WriteLine(maxNumber);

            Console.WriteLine("\n");

            //cifre distincte si frecventa lor
            var cifreDist = list.GroupBy(n => n).Select(group => new { Value = group.Key, Count = group.Count() }); 

            foreach (var item in cifreDist)
            {
                Console.WriteLine($"Valoare: {item.Value}, Frecventa: {item.Count}");
            }

            Console.WriteLine("\n\n");


            List<Student> students = new List<Student>()
            {
                new Student("Vasilica", "Vasile", 8.5),
                new Student("Marian", "Marin", 6.5),
                new Student("Ioana", "Ion", 9.5)
            };

            //studentii cu medie >8
            var medie8 = students.Where(s => s.Medie > 8);
            foreach (var student in medie8)
            {
                Console.WriteLine($"{student.Prenume} {student.Nume}");
            }

            Console.WriteLine("\n");

            //stundetii si media pt cei care incep cu v
            var numeV = students.Where(s => s.Nume.StartsWith("V", StringComparison.OrdinalIgnoreCase));
            foreach (var student in numeV)
            {
                Console.WriteLine($"{student.Prenume} {student.Nume} - Medie: {student.Medie}");
            }

            Console.ReadLine();
        }


        class Student
        {
            public string Nume { get; }
            public string Prenume { get; }
            public double Medie { get; }

            public Student(string nume, string prenume, double medie)
            {
                Nume = nume;
                Prenume = prenume;
                Medie = medie;
            }
        }

    }
}
