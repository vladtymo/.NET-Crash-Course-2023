
namespace HW5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Weapon weapon = new Weapon();
            //weapon.Initialize(150, 7.62, 10);
            weapon.Load();
            for (int i = 0; i < 12; i++) 
                weapon.Shot();
            weapon.Save();
        }
    }
}