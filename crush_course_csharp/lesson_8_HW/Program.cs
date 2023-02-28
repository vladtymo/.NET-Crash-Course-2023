namespace lesson_8_HW
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird()
            {
                Name = "Bird",
                Kind = "Bird",
                Speed = 15,
                Sound = "Some sound",
                Weight = 1,
                LivingEnv = "Air",
                MaxFlightHeight = 150,
                CurentFlightHeight = 10,
                MaxLifeTime = 10
            };
            Fish fish = new Fish()
            {
                Name = "Fish",
                Kind = "Fish",
                Speed = 10,
                Sound = "Some sound",
                Weight = 3,
                LivingEnv = "Water",
                MaxLifeTime = 5,
                PlaceOfResidence = "Atlantic Ocean"
            };
            Reptile reptile = new Reptile()
            {
                Name = "Reptile",
                Kind = "Reptile",
                Speed = 20,
                Sound = "Some sound",
                Weight = 5,
                LivingEnv = "Terrestial",
                MaxLifeTime = 10
            };

            bird.ShowInfo();
            Console.WriteLine("\n\n" + bird.Move() + "\n\n");
            bird.MoveToUp(10);
            bird.ShowInfo();
            Console.WriteLine("\n\n");


            fish.ShowInfo();
            Console.WriteLine("\n\n" + fish.Move() + "\n\n");

            reptile.ShowInfo();
            Console.WriteLine("\n\n" + reptile.Move() + "\n\n");
        }
    }
}