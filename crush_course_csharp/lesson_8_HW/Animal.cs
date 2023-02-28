
namespace lesson_8_HW
{
    public class Animal
    {

        public string Kind { get; set; }
        public string Name { get; set; }
        public double? Speed { get; set; }
        public double Weight { get; set; }
        public string LivingEnv { get; set; }
        public int? MaxLifeTime { get; set; }
        public string? Sound { get; set; }

        public string Move()
        {
            return "I`m moving";
        }
        public string TextSound()
        {
            return (Sound == null ? "Звук не вказаний" : Sound );
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Kind: {Name}\n" +
                $"Name: {Name}\n" +
                $"Speed: {(Speed == null ? "Швидкість не вказана" : Speed)}\n" +
                $"Weight: {Weight}\n" +
                $"Living Enveronment: {LivingEnv}\n" +
                $"Maximum Life Time: {(MaxLifeTime == null ? "Невідомо" : MaxLifeTime)}\n" +
                $"Sound: {TextSound()}");
        }
    }
}
