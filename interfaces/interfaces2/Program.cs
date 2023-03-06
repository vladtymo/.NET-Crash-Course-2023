namespace crash_course_interfaces_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elf elf = new Elf(1750, 1000, 0, ElfTypes.Mage, 300);
            Nordling nord = new Nordling(2000, 0, 500, NordlingTypes.Assasin, 0);

            nord.ShowInfo();
            nord.TakeDamage(elf.Attack());
            nord.ShowInfo();
        }
    }
}