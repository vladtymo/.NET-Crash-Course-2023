namespace Task12.Entities
{
    public class AirDefence : CombatVehicle
    {
        public double Range { get; }
        public double FireRate { get; }
        public int Mobility { get; }

        public AirDefence(int powerIndex = 1000)
        {
            Random random = new Random();

            Health = random.Next((int)(powerIndex * 0.05), (int)(powerIndex * 0.1));
            Range = random.Next((int)(powerIndex * 0.05), (int)(powerIndex * 0.1));
            FireRate = random.NextDouble();
            Mobility = random.Next(0, 11);
        }

        public override double Attack()
        {
            return 150 + Range * (FireRate / 10);
        }

        public override bool CanAttack(CombatVehicle combatVehicle)
        {
            if (combatVehicle is AirDefence) return false;
            if (combatVehicle is ArmoredCar) return false;
            if (combatVehicle is Bomber) return true;
            if (combatVehicle is Fighter) return true;
            if (combatVehicle is Tank) return false;

            return false;
        }

        public override double Defence(double damage)
        {
            Health -= (damage / Mobility);
            return Health;
        }
    }
}