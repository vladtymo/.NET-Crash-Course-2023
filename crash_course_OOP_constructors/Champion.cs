using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace crash_course_OOP_constructors
{
    internal class Champion 
    {
        private readonly string name;
        private int health;
        private int level;
        private int mana;
        private int attackDamage;
        private int spellDamage;
        private bool isAlive;
        private int? totalDamage;
        private const int maxLevel = 18;
        private int currentExperience;
        private int nextLevelExperience = 2000;
        

        public Champion(string name, int health, int mana, int attackDamage, int spellDamage)
        {
            this.name = name;
            this.health = health;
            this.mana = mana;
            this.attackDamage = attackDamage;
            this.spellDamage = spellDamage; 
            this.isAlive = true;
            this.level = 1;
            this.currentExperience = 0;
        }

        public Champion()
        {
            name = "Absolutely normal human";
            health = 100;
            mana = 0;
            attackDamage = 1;
            spellDamage = 0;
            isAlive = true;
            this.level = 1;
            this.currentExperience = 0;
        }

        public void IncreaseLevel()
        {
            currentExperience += (attackDamage / 2);
            currentExperience += (spellDamage / 2);

            if (currentExperience >= nextLevelExperience && level < maxLevel)
            {
                currentExperience += (currentExperience - nextLevelExperience);
                spellDamage += 140;
                attackDamage += 300;
                health += 1000;
                nextLevelExperience += 1400;
                level++;
            }

            if (level == maxLevel && currentExperience > nextLevelExperience)
            {
                currentExperience = nextLevelExperience;
            }
        }

        public void PrintStats()
        {
            Console.Write($"-------------------------------------------\n" +
                $"Name: {name}\n" +
                $"Current HP: {health}\n" +
                $"Current mana: {mana}\n" +
                $"Attack damage: {attackDamage}\n" +
                $"Spell damage: {spellDamage}\n" +
                $"Level: {level}\n" +
                $"Experience: {currentExperience}/{nextLevelExperience}\n" +
                $"-------------------------------------------\n");
        }

        public void TakeDamage(int damage)
        {
            health -= damage;

            if (health <= 0)
            {
                Die();
            }
        }

        public void Die()
        {
            health = 0;
            isAlive = false;
            Console.WriteLine("Champion dead");
        }

        public void Attack(Champion target)
        {
            target.TakeDamage(attackDamage);
            IncreaseLevel();
        }

        public void SpellAtack(Champion target)
        {
            if (mana >= 100)
            {
                mana -= 100;
                target.TakeDamage(spellDamage);
            }
        }
    }

}
