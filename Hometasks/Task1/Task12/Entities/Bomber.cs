namespace Task12.Entities
{
    public class Bomber : CombatVehicle
    {
        public int Engines { get; }
        public double Speed { get; }
        public double BombRate { get; }

        public Bomber(double powerIndex = 1000)
        {
            Random random = new Random();

            Health = random.Next((int)(powerIndex * 0.3), (int)(powerIndex * 0.6));
            Engines = random.Next(1, 11);
            Speed = random.Next((int)(powerIndex * 0.05), (int)(powerIndex * 0.1));
            BombRate = random.NextDouble();
        }

        public override double Attack()
        {
            return Engines * Speed * BombRate;
        }

        public override bool CanAttack(CombatVehicle combatVehicle)
        {
            if (combatVehicle is AirDefence) return true;
            if (combatVehicle is ArmoredCar) return false;
            if (combatVehicle is Bomber) return false;
            if (combatVehicle is Fighter) return false;
            if (combatVehicle is Tank) return true;

            return false;
        }

        public override double Defence(double damage)
        {
            Health -= (damage - Engines / Speed);
            return Health;
        }
    }
}