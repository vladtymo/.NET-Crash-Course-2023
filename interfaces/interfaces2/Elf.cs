using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_interfaces_2
{
    enum ElfTypes { Healer, Fighter, Mage };
    enum Abilities { FireBall = 1, Tornado, LightningBlade, RockFall };
    enum Arsenal { Katana = 1, Knife, Spear, Axe};

    internal class Elf : Character, IHealable, IAttack, IDamageable
    {
        public ElfTypes CharacterClass { get; set; }
        public int AbilityPower { get; set; }
        public Weapon Weapon { get; set; } = null;

        public Elf(int hp, int mana, int ad, ElfTypes characterClass, int ap) 
            : base(hp, mana, ad)
        {
            CharacterClass = characterClass;
            AbilityPower = ap;
        }

        public Weapon ChooseWeapon()
        {
            Weapon weapon = new Weapon("No weapon", 0, 0);
            if (CharacterClass == ElfTypes.Mage)
            {
                Console.WriteLine($"Choose your ability:\n" +
                    $"{Abilities.FireBall} --- {(int)Abilities.FireBall}\n" +
                    $"{Abilities.Tornado} --- {(int)Abilities.Tornado}\n" +
                    $"{Abilities.LightningBlade} --- {(int)Abilities.LightningBlade} \n" +
                    $"{Abilities.RockFall} --- {(int)Abilities.RockFall} \n" +
                    $"Don`t choose --- 5\n");

                Abilities abilities = Enum.Parse<Abilities>(Console.ReadLine()!);

                switch (abilities)
                {
                    case Abilities.FireBall:
                        weapon = new Weapon("FireBall", 200, 150);
                        Console.WriteLine("You have choosen Fire Ball!");
                        break;
                    case Abilities.Tornado:
                        weapon = new Weapon("Tornado", 360, 210);
                        Console.WriteLine("You have choosen Tornado!");
                        break;
                    case Abilities.LightningBlade:
                        weapon = new Weapon("LightningBlade", 100, 50);
                        Console.WriteLine("You have choosen LightningBlade!");
                        break;
                    case Abilities.RockFall:
                        weapon = new Weapon("Rock Fall", 500, 450);
                        Console.WriteLine("You have choosen Rock Fall!");
                        break;
                    default:
                        Console.WriteLine("Your warrior has no ability");
                        break;
                }
            }
            else if (CharacterClass == ElfTypes.Fighter)
            {
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
            }

            return weapon;
        }

        public void Heal(IHealable target)
        {
            if (CharacterClass == ElfTypes.Healer)
            {
                target.GetHeal();
                AttackDamage /= 5;
            }
            else
            {
                Console.WriteLine("This type of character can`t healing");
            }
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
            Console.WriteLine($"Class: {CharacterClass}\n" +
                $"Weapon: {Weapon.Name}");
        }

        public int Attack()
        {
            int currnet_damage = 0;
            Weapon = ChooseWeapon();
            if (CharacterClass == ElfTypes.Mage || CharacterClass == ElfTypes.Healer)
            {
                if (Mana >= Weapon.ManaCost)
                {
                    currnet_damage += (AbilityPower + Weapon.Damage);
                    Mana -= Weapon.ManaCost;
                }
                else
                {
                    currnet_damage += AbilityPower;
                }

                Die();
            }
            else if (CharacterClass == ElfTypes.Fighter)
            {
                currnet_damage += (AttackDamage + Weapon.Damage);

                Die();
            }

            return currnet_damage;
        }

        public void TakeDamage(int current_damage)
        {
            Console.WriteLine(Health);
            Health -= current_damage;
            Console.WriteLine(Health);
        }
    }
}
