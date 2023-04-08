
using System.Drawing;

namespace ExamProg
{
    public class PCPlayer : Player
    {

        public string Name { get; set; }
        public ConsoleColor Color { get; set; }

        public PCPlayer()
        {
            Color = ConsoleColor.Yellow;
            Name = "PC";
            playField = new PlayerField();
            attackField = new AttackField();
        }

        public override void setField()
        {
            playField.RandomGenerateField();
        }
        public override int[] makeAttack(PlayerField playerField)
        {
            return attackField.pcMakeAttack(playerField);
        }
        public override void confirmDamage(bool isDamage, PlayerField playerField, PlayerField damagedField)
        {
            attackField.confirmPCDamage(isDamage, damagedField);
        }
        public override string getName()
        {
            return this.Name;
        }
    }
}
