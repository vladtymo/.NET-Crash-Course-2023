
namespace lesson_8_HW
{
    public class Fish : Animal
    {
        public string PlaceOfResidence { get; set; }
        public new string Move()
        {
            return "I'm swimming";
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Kind: {Name}\n" +
                $"Name: {Name}\n" +
                $"Speed: {(Speed == null ? "Швидкість не вказана" : Speed)}\n" +
                $"Weight: {Weight}\n" +
                $"Living Enveronment: {LivingEnv}\n" +
                $"Maximum Life Time: {(MaxLifeTime == null ? "Невідомо" : MaxLifeTime)}\n" +
                $"Sound: {TextSound()}\n" +
                $"Place of Resifence: {PlaceOfResidence}");
        }
    }
}
