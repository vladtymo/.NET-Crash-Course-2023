namespace Task12.Entities
{
    public class Fighter : CombatVehicle
    {
        public int Machineguns { get; }
        public int Engines { get; }
        public double Speed { get; }
        public int Range { get; }

        public Fighter(int powerIndex = 1000)
        {
            Random random = new Random();

            Health = random.Next((int)(powerIndex * 0.1), (int)(powerIndex * 0.3));
            Machineguns = random.Next(1, 11);
            Engines = random.Next(1, 5);
            Speed = powerIndex / 2;
            Range = random.Next((int)(powerIndex * 0.1), (int)(powerIndex * 0.3));
        }

        public override double Attack()
        {
            return Range * Machineguns / 10;
        }

        public override bool CanAttack(CombatVehicle combatVehicle)
        {
            if (combatVehicle is AirDefence) return true;
            if (combatVehicle is ArmoredCar) return true;
            if (combatVehicle is Bomber) return true;
            if (combatVehicle is Fighter) return true;
            if (combatVehicle is Tank) return false;

            return true;
        }

        public override double Defence(double damage)
        {
            Health -= (damage / Engines);
            return Health;
        }
    }
}