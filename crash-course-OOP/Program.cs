namespace crash_course_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon glock = new Weapon();
            Weapon RPG = new Weapon();
            glock.Initialize("Glock-17", 50, 9, 17, 17);
            RPG.Initialize("RPG-7", 700, 40, 1, 1);

            Console.WriteLine(glock.Shot() ? "Boom!" : "Magazine is empty!");
            Console.WriteLine(RPG.Shot() ? "Big boom!" : "Magazine is empty!");

            using (StreamWriter guns_info = new StreamWriter("guns.txt"))
            {
                RPG.Save(guns_info);
                glock.Save(guns_info);
                guns_info.Close();  
            }

            Load();
        }

        static void Load()
        {
            using (StreamReader info = new StreamReader("guns.txt"))
            {
                Console.WriteLine(info.ReadToEnd());
            }
        }
    }
}