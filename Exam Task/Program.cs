namespace Final_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student olena = new Student("Olena", "Sheremet", "lenk.sheremet1978@gmail.com", true, 3);
            Student ivan = new Student("Ivan", "Kyka", "kichakovalskiy@gmail.com", true, 5);
            Student nastya = new Student("Anastasia", "Sokolvak", "nasta2003sok@gmail.com", true, 3);
            Student dima = new Student("Dmytro", "White", "demonWhite@gmail.com", false, 3);
            StudentGroup group1 = new StudentGroup("IPZ");
            StudentGroup group2 = new StudentGroup("KN");
            group1.AddStudent(olena);
            group1.AddStudent(nastya);
            group1.AddStudent(dima);
            group2.AddStudent(ivan);
            olena.PrintInfo();
            Console.WriteLine();
            Teacher teacher1 = new Teacher("Andriy", "Syaskiy", "andriysyasky@gmail.com ", "Professor", 10000);
            teacher1.PrintInfo();
            teacher1.DoWork();
            Console.WriteLine();
            Subject subject1 = new Subject("Numerical Methods", 48);
            Subject subject2 = new Subject("Basic of the scientic research", 24);
            Subject subject3 = new Subject("Information protection", 20);
            Subject subject4 = new Subject("Administration of computer system", 26);
            teacher1.AddStudentGroup(group1);
            teacher1.AddStudentGroup(group2);
            teacher1.RemoveStudentGroup(group2);
            Console.WriteLine();
            teacher1.AddSubject(subject1);
            teacher1.AddSubject(subject3);
            teacher1.AddSubject(subject2);
            Console.WriteLine();
            teacher1.GetSubjects();
            Console.WriteLine();
            teacher1.RemoveSubject(subject3);
            Console.WriteLine();
            teacher1.GetSubjects();
            Console.WriteLine();
            group1.AddSubject(subject4);
            group1.AddSubject(subject1);
            group1.AddSubject(subject3);
            Console.WriteLine();
            group2.AddSubject(subject1);
            group2.AddSubject(subject2);
            group2.AddSubject(subject3);
            group2.AddSubject(subject4);
            Console.WriteLine();
            group1.GetStudents();
            group1.GetSubjects();
            Console.WriteLine();
            group2.GetStudents();
            group2.GetSubjects();
            Console.WriteLine();
            teacher1.GetSubjects();
            Console.WriteLine();
            olena.AddExemGrade(subject1, 5);
            olena.AddExemGrade(subject2, 4);
            olena.AddExemGrade(subject3, 4);
            olena.GetExamGrades();
        }
    }
}