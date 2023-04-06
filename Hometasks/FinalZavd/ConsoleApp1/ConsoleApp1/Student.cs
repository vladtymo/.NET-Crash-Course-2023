using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ConsoleApp1
{


    class Student : Osoba, IComparable<Student>
    {
        public static int counter = 0;
        public readonly int nomer;
        public string StudentId { get; set; }
        public double Reyting { get; set; }
        public Grupa Grupa { get; set; }

        
        public Dictionary<Predmet, int> Ocinku { get; set; }



        public Student(string firstName, string lastName, string nomerTelefona, DateTime dataNarodgenya, string studentId, double reyting, Grupa grupa)
            : base(firstName, lastName, nomerTelefona, dataNarodgenya)
        {
            ++counter;
            nomer = counter;
            StudentId = studentId;
            Reyting = reyting;
            Grupa = grupa;
            grupa.Students.Add(this);
            Ocinku=new Dictionary<Predmet, int>();
        }

        public override void Info()
        {
            Console.WriteLine($"Student №{nomer}\n" +
                $"PIP: {FirstName} {LastName}\n" +
                $"Nomer telefona: {NomerTelefona}\n" +
                $"Data narodgennya: {DataNarodgenya}\n" +
                $"StudentID: {StudentId}\n" +
                $"Grupa: {Grupa.Name}\n");
        }


        public void SetOcinka(Predmet predmet, int ocinka)
        {
            Ocinku.Add(predmet, ocinka);
        }

        public void OcinkuStudentaInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Ocinku studenta: {FirstName} {LastName}");
            foreach (var item in Ocinku)
            {
                Console.WriteLine($"{item.Key.Name} --- {item.Value}");
            }
        }

        public void ReSetStudent(string firstName, string lastName, string nomerTelefona, DateTime dataNarodgenya, string studentId, Grupa grupa)
        {

            FirstName = firstName;
            LastName = lastName;
            NomerTelefona = nomerTelefona;
            DataNarodgenya = dataNarodgenya;
            StudentId = studentId;
            Grupa = grupa;
        }

        public double SerOcinka()
        {
            double sum = 0;
            foreach (var item in Ocinku.Values)
            {
                sum += item;
            }
             
            return sum / Ocinku.Count;
        }

        public int CompareTo(Student obj)
        {
            return this.Reyting.CompareTo(obj.Reyting);
        }

        public void PorivnStudent(Student student)
        {
            if (CompareTo(student)==0)
            {
                Console.WriteLine($"Reytung studentiv {this.LastName} i {student.LastName} rivnuy");
            }

            if (CompareTo(student) == 1)
            {
                Console.WriteLine($"Student {this.LastName} yspisnishuy za studenta {student.LastName}");
            }

            if (CompareTo(student) == -1)
            {
                Console.WriteLine($"Student {student.LastName} yspisnishuy za studenta {this.LastName}");
            }
        }
    }
}
