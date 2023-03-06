using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_interfaces_2
{
    internal class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int ManaCost { get; set; }

        public Weapon(string name, int damage, int manaCost )
        {
            Name= name;
            Damage= damage;
            ManaCost= manaCost;
        }
    }
}
