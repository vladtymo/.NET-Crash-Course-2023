
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;

namespace ExamProg
{
    public abstract class Player
    {
        public PlayerField playField;
        public AttackField attackField;

        public string Name { get; set; }
        public ConsoleColor Color { get; set; }

        public abstract void setField();
        public abstract int[] makeAttack(PlayerField playerField);
        public abstract void confirmDamage(bool isDamage, PlayerField playerField, PlayerField damagedField);
        public abstract string getName();
        public bool isLive()
        {
            return playField.isLive();
        }
        public bool checkDamage(int[] X_Y)
        {
            return playField.checkDamage(X_Y);
        }
        public void setRandomField()
        {
            playField.RandomGenerateField();
        }
        public void printField()
        {
            playField.PrintField();
        }
    }
}
