using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_abstract
{
    internal class AirDefenceVehicle : CombatVehicle
    {
        public float AttackRange { get; set; }
        public int AttackSpeed { get; set; }

        private int mobility;
        public int Mobility {
            get
            {
                return mobility;
            }
            set 
            {
                if (mobility >= 1  && mobility <= 10)
                {
                    Mobility= mobility;
                }
                else
                {
                    Mobility = 10;
                }
            } 
        }

        public AirDefenceVehicle(string model, int health, Types type, float attackRange, int attackSpeed, int mobility) 
            : base(model, health, type)
        {
            AttackRange = attackRange;
            AttackSpeed = attackSpeed;
            this.mobility = mobility;
        }

        public override int Attack()
        {
            int attackDamage = 150 + (int)AttackRange * (AttackSpeed / 10);
            return attackDamage;
        }

        public override int Defence(int damage)
        {
            int damageReceived = damage/Mobility;
            IsDestroyed();
            return damageReceived;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Attack range: {AttackRange}\n" +
                $"Attack speed: {AttackSpeed}\n" +
                $"Mobility: {Mobility}\n");
        }
    }
}
