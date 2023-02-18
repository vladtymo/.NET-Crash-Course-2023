namespace _05_exercise
{
    class Weapon
    {
        private int shot_range;
        private float calib;
        private int number_bullets;
        private int max_number_bullets;

        public void Initialize(int range, float caliber, int maxSize)
        {
            if(range <= 0 || caliber <= 0 || maxSize <= 0)
            {
                Console.WriteLine("Invalid parameters!!!");
                return;
            }

            shot_range = range;
            calib = caliber;
            number_bullets = maxSize;
            max_number_bullets = maxSize;
        }

        public bool Shot()
        {
            if (number_bullets > 0)
            {
                number_bullets--;
                Console.WriteLine("Shot!!!");
                return true;
            }
            else
                Console.WriteLine("Empty magazine!!!");
                return false;
        }

        public void Recharge()
        {
            number_bullets = max_number_bullets;
            Console.WriteLine("Recharge!");
        }

        public void Save()
        {
            string file_name = "file.txt";
            using(StreamWriter writer = new StreamWriter(file_name))
            {
                writer.WriteLine(shot_range);
                writer.WriteLine(calib);
                writer.WriteLine(number_bullets);
                writer.WriteLine(max_number_bullets);
            }
            Console.WriteLine("Weapon containted in the file: " + file_name);
        }

        public void Load()
        {
            string file_name = "file.txt";
            using(StreamReader reader = new StreamReader(file_name))
            {
                shot_range = Convert.ToInt32(reader.ReadLine());
                calib = Convert.ToSingle(reader.ReadLine());
                number_bullets = Convert.ToInt32(reader.ReadLine());
                max_number_bullets = Convert.ToInt32(reader.ReadLine());
            }
            Console.WriteLine("Weapon loaded from file: " + file_name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon g = new Weapon();
            g.Initialize(47, 7.62f, 30);
            g.Shot();
            g.Recharge();
            g.Save();
            g.Load();
        }
    }
}