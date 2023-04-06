using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Decanat
    {
        public List<Predmet> Predmets { get; set; }
        public List<Osoba> Osobas { get; set; }
        public List<Student> Students { get; set; }
        public List<Vukladach> Vukladachs { get; set; }
        public List<Grupa> Grups { get; set; }

        public Decanat()
        {
            Predmets = new List<Predmet>();
            Students = new List<Student>();
            Vukladachs = new List<Vukladach>();
            Grups = new List<Grupa>();
            Osobas = new List<Osoba>();
        }


        public void AddPredmet(Predmet predmet)
        {
            Predmets.Add(predmet);
        }

        public void DeletePredmet(Predmet predmet)
        {
            Predmets.Remove(predmet);
        }

        public void InfoPredmets()
        {
            Console.WriteLine();
            foreach (var item in Predmets)
            {
                item.Info();
            }
        }

        public void AddVukladach(Vukladach vukladach)
        {
            
            Vukladachs.Add(vukladach);
            Osobas.Add(vukladach);

        }

        public void DeleteVukladach(Vukladach vukladach)
        {

            Vukladachs.Remove(vukladach);
            Osobas.Remove(vukladach);

        }


        public void InfoVucladachs()
        {
            Console.WriteLine();
            foreach (var item in Vukladachs)
            {
                item.Info();
            }
        }

        public void AddStudent(Student student)
        {
            
            Students.Add(student);
            Osobas.Add(student);

        }

        public void DeleteStudent(Student student)
        {

            Students.Remove(student);
            Osobas.Remove(student);

        }

        public void InfoStudents()
        {
            Console.WriteLine();
            foreach (var item in Students)
            {
                item.Info();
            }
        }

        public void AddGrup(Grupa grupa)
        {
            Grups.Add(grupa);
        }

        public void DeleteGrup(Grupa grupa)
        {
            Grups.Remove(grupa);
        }


        public void InfoGrups()
        {
            Console.WriteLine();
            foreach (var item in Grups)
            {
                Console.WriteLine();
                item.Info();
            }
        }

        public void ListOsobs()
        {
            foreach (var item in Osobas)
            {
                item.Info();
            }
        }


        public void GrupaPredmets(Grupa grupa)
        {
            Console.WriteLine();
            Console.WriteLine($"Predmetu grupu {grupa.Name}");
            foreach (var item in grupa.Students[0].Ocinku.Keys)
            {
                Console.WriteLine(item.Name);
            }
        }


        
    }
}
