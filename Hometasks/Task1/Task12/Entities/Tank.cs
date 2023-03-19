namespace Task12.Entities
{
    public class Tank : CombatVehicle
    {
        public double ReloadTime { get; }
        public double Accuracy { get; }
        public double ArmorWidth { get; }

        public Tank(double powerIndex = 1000)
        {
            Random random = new Random();

            Health = random.NextDouble() * powerIndex;
            ReloadTime = random.Next(1, (int)(powerIndex * 0.1));
            Accuracy = random.NextDouble();
            ArmorWidth = random.Next(10, (int)(powerIndex * 0.1));
        }
        
        public override bool CanAttack(CombatVehicle combatVehicle)
        {
            if (combatVehicle is AirDefence) return true;
            if (combatVehicle is ArmoredCar) return true;
            if (combatVehicle is Bomber) return false;
            if (combatVehicle is Fighter) return false;
            if (combatVehicle is Tank) return true;

            return false;
        }

        public override double Attack()
        {
            return 100 * Accuracy * ReloadTime;
        }

        public override double Defence(double damage)
        {
            Health -= (damage - ArmorWidth / 5);
            return Health;
        }
    }
}