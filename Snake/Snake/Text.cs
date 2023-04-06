using static Snake.Program;


namespace Snake
{
    class Text
    {
        delegate int AddDelegat(int x);
        public event Action<int> EndTitel;
        private int Add(int value)
        {
            number++;
            return number;
        }

        private int number;
        public Text()
        {
            number = -1;
        }

        public void Draw()
        {
            AddDelegat add = Add;
            Console.ForegroundColor= ConsoleColor.White;
            Console.SetCursorPosition(width + 5, 3);
            Console.WriteLine($"Count: {add.Invoke(number)}");
        }

        public void EndGame()
        {
            Console.SetCursorPosition(width / 2 - 5, heigth / 2);
            Console.ForegroundColor = ConsoleColor.Red;
            if (Win())
                Console.WriteLine("Your Win!!!!");
            else
                Console.WriteLine("Your Died");
            EndTitel.Invoke(number);
        }
        public bool Win()
        {
            if(number == 10)
                return true;

            return false;
        }
    }
}
