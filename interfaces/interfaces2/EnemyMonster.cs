using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_interfaces_2
{
    internal class EnemyMonster : IAttack, IDamageable
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackDamage { get; set; }

        public EnemyMonster(string name, int hp, int ad)
        {
            Name = name;
            Health = hp;
            AttackDamage = ad;
        }

        public int Attack()
        {
            int current_damage = 0;
            current_damage += AttackDamage;

            return current_damage;
        }

        public void TakeDamage(int current_damage)
        {
            Health -= current_damage;
        }
    }
}
