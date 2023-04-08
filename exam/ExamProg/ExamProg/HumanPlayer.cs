
using System.Drawing;

namespace ExamProg
{
    public class HumanPlayer : Player
    {
        public HumanPlayer()
        {
            playField = new PlayerField();
            attackField = new AttackField();

        }
        public string Name { get; set; }
        public ConsoleColor Color { get; set; }

        public override int[] makeAttack(PlayerField playerField)
        {
            return attackField.makeAttack(playerField);
        }

        public override void setField()
        {
            playField.InputGenerateFild();
        }
        public override void confirmDamage(bool isDamage, PlayerField playerField, PlayerField damagedField)
        {
            attackField.confirmDamage(isDamage, playerField, damagedField);
        }
        public override string getName()
        {
            return this.Name;
        }
    }
}
