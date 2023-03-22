

namespace task_12
{
    internal abstract class CombatVehicle
    {

        public string Type { get; set; }
        public string Model { get; set; }
        public int Health { get; set; }

        public CombatVehicle(string type, string model, int health)
        {
            Type = type;
            Model = model;
            Health = health;
        }

        public abstract int Attack();
        public abstract void Defense(int damage);
        public bool IsDestroyed()
        {
            if(Health<=0)
                return true;
            else
                return false;
        }
        private string MachineCondition()
        {
            string state;
            if (IsDestroyed())
                state = "destroyed";
            else 
                state = "unhurt";
            
            return state;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Type: {Type}\n" +
                $"Model: {Model}\n" +
                $"Machine condition:{MachineCondition()} \n" +
                $"Health: {Health} hp");
        }

    }
}
