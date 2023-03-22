
namespace task_12
{
    internal class ArmoredCar : CombatVehicle
    {
        public int NumberOfGuns { get; set; }
        public int Speed { get; set; }
        public ArmoredCar(int countGuns, int  speed, int health, string model) : base("Armor car", model, health)
        {
            NumberOfGuns = countGuns;
            Speed =  speed;

        }
        public override int Attack()
        {
            return 50 * NumberOfGuns;
        }

        public override void Defense(int damage)
        {
            Health -= damage - Speed/2;

        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Number of guns: {NumberOfGuns}\n" +
                                $"Speed: {Speed}\n\n\n");

        }
    }
}
