using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Decanat decanat = new Decanat();

            Predmet predmet1 = new Predmet("Fizika", "Predmet pro fiz-vlastuvosti");
            decanat.AddPredmet(predmet1);
            Predmet predmet2 = new Predmet("Matumatuka", "Predmet pro mat-vlastuvosti");
            decanat.AddPredmet(predmet2);
            Predmet predmet3 = new Predmet("Istoriya", "Informatsiya po munuli roku");
            decanat.AddPredmet(predmet3);
            Predmet predmet4 = new Predmet("Geografiya", "Informatsiya pro pevni teretoriyi");
            decanat.AddPredmet(predmet4);
            Predmet predmet5 = new Predmet("Muzuka", "Predmet muzuky");
            decanat.AddPredmet(predmet5);
            
            Grupa grupa1 = new Grupa("IPZ-21", 2);
            decanat.AddGrup(grupa1);
            Grupa grupa2 = new Grupa("I-31", 3);
            decanat.AddGrup(grupa2);
            Grupa grupa3 = new Grupa("CT-41", 4);
            decanat.AddGrup(grupa3);


            Student student1 = new Student("Grugir", "Bzdunduntykevich", "0635588997", new DateTime(2001, 5, 7), "ST0001",79.5, grupa1);
            decanat.AddStudent(student1);
            Student student2 = new Student("Vasya", "Pupcin", "093000001", new DateTime(2001, 3, 5), "ST0002", 81.7, grupa1);
            decanat.AddStudent(student2);
            Student student3 = new Student("Olga", "Zubchata", "0635456997", new DateTime(2001, 1, 7), "ST0003", 95.5, grupa1);
            decanat.AddStudent(student3);
            Student student4 = new Student("Nazar", "Duduk", "0635487987", new DateTime(2000, 9, 9), "ST0004", 63.7, grupa2);
            decanat.AddStudent(student4);
            Student student5 = new Student("Ann", "Osobluva", "0635456997", new DateTime(2000, 3, 1), "ST0005", 55.9, grupa2);
            decanat.AddStudent(student5);
            Student student6 = new Student("Vitaliy", "Gaduk", "0637765897", new DateTime(2000, 6, 3), "ST0006", 65.3, grupa2);
            decanat.AddStudent(student6);
            Student student7 = new Student("Roman", "Duchuna", "0557764397", new DateTime(1999, 7, 9), "ST0007", 79.5, grupa3);
            decanat.AddStudent(student7);
            Student student8 = new Student("Macha", "Melnuk", "0667788557", new DateTime(1999, 2, 1), "ST0008", 79.3, grupa3);
            decanat.AddStudent(student8);
            Student student9 = new Student("Yaroslav", "Mechnuy", "0987763597", new DateTime(1999, 5, 7), "ST0009", 98.1, grupa3);
            decanat.AddStudent(student9);


            Vukladach vukladach1 = new Vukladach("Oleksandr", "Grigorovich", "093555777", new DateTime(1985, 7, 9), "Matematuku", predmet1);
            decanat.AddVukladach(vukladach1);
            Vukladach vukladach2 = new Vukladach("Dmitro", "Gemko", "066558337", new DateTime(1989, 5, 7), "Matematuku", predmet2);
            decanat.AddVukladach(vukladach2);
            Vukladach vukladach3 = new Vukladach("Vasil", "Drugko", "093555777", new DateTime(1979, 11, 3), "Istorii", predmet3);
            decanat.AddVukladach(vukladach3);
            Vukladach vukladach4 = new Vukladach("Tettyana", "Bayda", "093555777", new DateTime(1987, 9, 9), "Istorii", predmet4);
            decanat.AddVukladach(vukladach4);
            Vukladach vukladach5 = new Vukladach("Fedir", "Robochuy", "093555777", new DateTime(1990, 10, 7), "Muzuku", predmet5);
            decanat.AddVukladach(vukladach5);




            Console.WriteLine("Osobs");
            Console.WriteLine("---------------------------------------------------------------");
            decanat.ListOsobs();
            Console.WriteLine("Predmets");
            Console.WriteLine("---------------------------------------------------------------");
            decanat.InfoPredmets();
            Console.WriteLine("Grups");
            Console.WriteLine("---------------------------------------------------------------");
            decanat.InfoGrups();

            Console.WriteLine();
            Console.WriteLine("Okrema infa");
            Console.WriteLine("---------------------------------------------------------------");
            student1.Info();
            vukladach1.Info();
            predmet1.Info();
            grupa1.Info();


            student1.SetOcinka(predmet5, 3);
            student1.SetOcinka(predmet3, 5);
            student1.SetOcinka(predmet1, 5);

            Console.WriteLine();
            Console.WriteLine("Ocinku studenta");
            Console.WriteLine("---------------------------------------------------------------");
            student1.OcinkuStudentaInfo();

            Console.WriteLine("Serednya ocinka:" + student1.SerOcinka());

            Console.WriteLine();
            Console.WriteLine("Poshuk predmetiv grupu");
            Console.WriteLine("---------------------------------------------------------------");
            decanat.GrupaPredmets(grupa1);

            Console.WriteLine();
            Console.WriteLine("Interfeys IComparable");
            Console.WriteLine("---------------------------------------------------------------");

            student1.PorivnStudent(student7);
            student1.PorivnStudent(student2);
            student1.PorivnStudent(student5);

            

            var options = new JsonSerializerOptions
            { 
                WriteIndented = true, ReferenceHandler = ReferenceHandler.Preserve 
            };
            string jsonToSave = JsonSerializer.Serialize(decanat,options);

            File.WriteAllText("data.json", jsonToSave);



            //string loadedJson = File.ReadAllText("data.json");

            //var decanat1 = JsonSerializer.Deserialize<Decanat>(loadedJson);


        }
    }
}
