
public class Animal
{
    public string Species { get; set; }
    public double Speed { get; set; }
    public double Weight { get; set; }
    public string? Habitat { get; set; }

    public Animal(string species, double speed,double weight, string? habitat){
        this.Species = species;
        this.Speed = speed;
        this.Weight = weight;
        this.Habitat = habitat;
    }
    public void Move(){
        Console.WriteLine("I am moving...");
    }
    public void MakeSound(){
        Console.WriteLine("I am talking...");
    }
    public void Show(){
        Console.WriteLine($"Species: {this.Species}\nSpeed: {(this.Speed).ToString("0.##")} \nWeight: {(this.Weight).ToString("0.##")}\nEnviroonment: {this.Habitat ?? "who knows"}");
    }
}
