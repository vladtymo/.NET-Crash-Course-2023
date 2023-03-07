using System.ComponentModel;

namespace lab_08_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Turtles turtles= new Turtles();
            turtles.Show();
            turtles.Move();
            turtles.MakeSound();
            turtles.MakeNewSound();
            turtles.ColdOrWarmBloodet();

            Parrot parrot = new Parrot("Parrot Ara", 10.4f, 1.25f, "Dissemination in Central and South America", true);
            parrot.Show();
            parrot.Move();
            parrot.MakeSound();
            parrot.MakeNewSound();
            parrot.Fly();

            Catfish catfish = new Catfish();
            catfish.Show();
            catfish.Move();
            catfish.MakeSound();
            catfish.MakeNewSound();
            catfish.TypeWater();
            /*List<Animal> zoo = new List<Animal>();
            zoo.Add(parrot);
            zoo.Add(catfish);
            zoo.Add(turtles);
            for (int i = 0; i < zoo.Count; ++i)
            {
                zoo[i].Show();
            }
            */
            Animal[] zoo = new Animal[3];

            zoo[0] = parrot;
            zoo[1] = catfish;
            zoo[2] = turtles;

            foreach (Animal animal in zoo) {
                animal.Show();
                animal.MakeSound();
                animal.Move();

        
        }
    }
}
