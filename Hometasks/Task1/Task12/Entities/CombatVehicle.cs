namespace Task12.Entities
{
    public abstract class CombatVehicle
    {
        public double Health { get; protected set; }
        public bool IsDestroyed => Health <= 0;

        public abstract bool CanAttack(CombatVehicle combatVehicle);
        public abstract double Attack();
        public abstract double Defence(double damage);
    }
}