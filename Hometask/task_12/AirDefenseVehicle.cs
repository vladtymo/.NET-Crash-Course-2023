

namespace task_12
{
    internal class AirDefenseVehicle : CombatVehicle
    {
        public int Long { get; set; }
        public int ShotSpeed { get; set; }
        public int Mobility { get; set; }
        public AirDefenseVehicle(int dist, int shotSpeed, int mobility, int health,  string model) : base("Plane", model, health)
        {
            Long = dist ;
            ShotSpeed = shotSpeed;
            Mobility = mobility;
        }

        public override int Attack()
        {
            return (150 + Long * (ShotSpeed / 10));
        }

        public override void Defense(int damage)
        {
            Health -= damage - damage / Mobility;

        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Long plane: {Long}\n" +
                                $"Shot speed: {ShotSpeed}\n" +
                                $"Mobility: {Mobility}\n\n");
        }
    }
}
