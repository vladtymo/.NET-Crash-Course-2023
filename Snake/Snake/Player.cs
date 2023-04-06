


using System.Collections;

namespace Snake
{
    internal class Player : IComparable<Player>
    {
        public string?  NikName { get; set; }
        public int Number { get; set; }

        public Player(string nikName)
        {
            NikName = nikName;
            Number = 0;
        }

        public Player()
        {
            NikName = null;
            Number = 0;
        }

        public void Count(int number)
        {
            Number = number;
        }

        public void SortList(List<Player> list)
        {
            list.Sort();
        }
        public int CompareTo(Player? other)
        {
            if (other == null) return 1;
            return this.Number.CompareTo(other.Number) * -1;
        }
        public override string ToString() => $"Nikname: {NikName} - number: {Number}";

    }
}
