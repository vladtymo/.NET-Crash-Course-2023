
namespace task_12
{
    internal class Tank : CombatVehicle
    {
        public int RechargeTime { get; set; }
        public int ShotAccuraly { get; set; }
        public int Armor { get; set; }
        public Tank( int rechargeTime, int armor, int health, int shorAccuraly, string model ) : base("Tank", model, health)
        {
            RechargeTime = rechargeTime;
            Armor = armor;
            ShotAccuraly = shorAccuraly;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Recharge time: {RechargeTime}\n" +
                $"Armor: {Armor}\n" +
                $"Shot accuraly: {ShotAccuraly}\n\n\n");
        }
        public override int Attack()
        {
            return (100 * ShotAccuraly / RechargeTime);
        }

        public override void Defense(int damage)
        {
            Health -= damage - Armor;
        }


    }
}
