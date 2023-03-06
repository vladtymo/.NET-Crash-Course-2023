using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_interfaces_2
{
    enum NordlingTypes {Assasin, Tank, Bruiser} 

    internal class Nordling : Character, IHealable, IDamageable, IAttack
    {
        public NordlingTypes CharacterClass { get; set; }
        public Weapon NWeapon { get; set; } = null;

        public Nordling(int hp, int mana, int ad, NordlingTypes characterClass, int ap)
          : base(hp, mana, ad)
        {
            CharacterClass = characterClass;
        }

        public Weapon ChooseWeapon()
        {
            Weapon weapon = new Weapon("No weapon", 0, 0);
            
            Console.WriteLine($"Choose your weapon:\n" +
                $"{Arsenal.Katana} --- {(int)Arsenal.Katana}\n" +
                $"{Arsenal.Knife} --- {(int)Arsenal.Knife}\n" +
                $"{Arsenal.Spear} --- {(int)Arsenal.Spear} \n" +
                $"{Arsenal.Axe} --- {(int)Arsenal.Axe} \n" +
                $"Don`t choose --- 5\n");

            Arsenal arsenal = Enum.Parse<Arsenal>(Console.ReadLine()!);

            switch (arsenal)
            {
                case Arsenal.Katana:
                    weapon = new Weapon("Katana", 100, 0);
                    Console.WriteLine("You have choosen Katana!");
                    break;
                case Arsenal.Knife:
                    weapon = new Weapon("Knife", 50, 0);
                    Console.WriteLine("You have choosen Knife!");
                    break;
                case Arsenal.Spear:
                    weapon = new Weapon("Spear", 200, 0);
                    Console.WriteLine("You have choosen Spear!");
                    break;
                case Arsenal.Axe:
                    weapon = new Weapon("Axe", 300, 0);
                    Console.WriteLine("You have choosen Axe!");
                    break;
                default:
                    Console.WriteLine("Your warrior has no ability");
                    break;

            }
            
            return weapon;
        }

        void Die()
        {
            if (Health <= 0)
            {
                IsAlive = false;
                Health = 0;
                Mana = 0;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{new string('-', 15)}\n" +
                $"Health: {Health}\n" +
                $"Mana: {Mana}\n" +
                $"Attack damage: {AttackDamage}\n" +
                $"Class: {CharacterClass}\n");
        }

        public int Attack()
        {
            int current_damage = 0;
            NWeapon = ChooseWeapon();

            current_damage += (AttackDamage + NWeapon.Damage);
            Die();

            return current_damage;
        }

        public void TakeDamage(int current_damage)
        {
            Console.WriteLine(Health);
            Health -= current_damage;
            Console.WriteLine(Health);
        }
    }
}
