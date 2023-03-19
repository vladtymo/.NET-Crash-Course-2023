namespace Task12.Entities
{
    public class ArmoredCar : CombatVehicle
    {
        public int WeaponCapacity { get; }
        public double Speed { get; }

        public ArmoredCar(double powerIndex = 1000)
        {
            Random random = new Random();

            Health = random.Next((int)(powerIndex * 0.01), (int)(powerIndex * 0.1));
            WeaponCapacity = random.Next(1, (int)(powerIndex * 0.05));
            Speed = powerIndex * 0.1;
        }

        public override double Attack()
        {
            return WeaponCapacity;
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

        public override double Defence(double damage)
        {
            Health -= (damage / Speed);
            return Health;
        }
    }
}