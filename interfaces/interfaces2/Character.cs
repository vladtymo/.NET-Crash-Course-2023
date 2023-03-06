using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_interfaces_2
{
    internal class Character
    {
        public int Health { get; set; }
        public int Mana { get; set; }
        public int AttackDamage { get; set; }
        public bool IsAlive { get; set; }

        public Character(int hp, int mana, int ad)
        {
            Health = hp;
            Mana = mana;
            AttackDamage = ad;
            IsAlive = true;
        }
    }
}
