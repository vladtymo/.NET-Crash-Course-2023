
namespace Snake
{
    internal class Player
    {
        public string  FirstName { get; set; }
        public string SelectName { get; set; }
        public int Number { get; set; }

        public Player(string firstName, string selectName)
        {
            FirstName = firstName;
            SelectName = selectName;
            Number = 0;
        }

        public void Count()
        {

        }

    }
}
