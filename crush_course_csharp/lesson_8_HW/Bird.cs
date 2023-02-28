
namespace lesson_8_HW
{
    public class Bird : Animal
    {
        public int MaxFlightHeight { get; set; }
        public int CurentFlightHeight { get; set; }
        public new string Move()
        {
            return "I'm flying";
        }
        public new void ShowInfo()
        {
            Console.WriteLine($"Kind: {Name}\n" +
                $"Name: {Name}\n" +
                $"Speed: {(Speed == null ? "Швидкість не вказана" : Speed)}\n" +
                $"Weight: {Weight}\n" +
                $"Living Enveronment: {LivingEnv}\n" +
                $"Maximum Life Time: {(MaxLifeTime == null ? "Невідомо" : MaxLifeTime)}\n" +
                $"Sound: {TextSound()}\n" +
                $"Curent Flight Height: {CurentFlightHeight}");
        }
        public string MoveToUp(int height)
        {
            CurentFlightHeight += height;
            if (MaxFlightHeight >= CurentFlightHeight)
                return "Done";
            else
            {
                CurentFlightHeight = MaxFlightHeight;
                return "Досягнута максимальна висота";
            }
        }
    }
}
