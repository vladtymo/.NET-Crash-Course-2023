
namespace lesson_12_HW_abstract
{
    public class AirDefenceVehicle : CombatVehicle
    {
        public double Range { get; set; }
        public double RateOfFire { get; set; }
        public int Mobility { get; set; }

        public AirDefenceVehicle(string model, double health, int mobility) : base("Air Defence Vehicle")
        {
            Model = model;
            Health = health;
            if (mobility >= 1 && mobility <= 10)
                Mobility = mobility;
            else if (mobility > 10)
                Mobility = 10;
            else
                Mobility = 1;
        }

        public override double Attack()
        {
            return 150 + Range*(RateOfFire/10);
        }

        public override void Defance(double damage)
        {
            Health -= (damage/Mobility);
        }
    }
}
