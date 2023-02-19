namespace crash_course_OOP_constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Champion human = new Champion();
            Champion warrior = new Champion("Darius", 5500, 1400, 400, 50);
            Champion mage = new Champion("Ryze", 3800, 6800, 75, 650);
            Champion assasin = new Champion("Zed", 2000, 800, 1500, 30);
            Champion tank = new Champion("Sion", 8000, 300, 200, 200);

            Champion[] champions = { human, warrior, assasin, mage, tank };


            for (int i = 0; i < 10; i++)
            {
                champions[1].Attack(champions[2]);
            }
            champions[1].PrintStats();
            champions[2].PrintStats();
        }
    }
}