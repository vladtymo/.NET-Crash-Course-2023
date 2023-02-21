

using System;
 
namespace FlagOfGreece
{
    class Program
    {
        class Laptop{
            private int? ram;
            private double? diagonal;
            private readonly string processor;
            private readonly string seria;
            private string? color;

            public const int MIN_RAM = 2;
            public const int MAX_RAM = 16;
            public const double MIN_DIAGONAL = 11.6;
            public const string DEFAULT_COLOR = "black";

            public Laptop(){
                this.ram = MIN_RAM;
                this.diagonal = MIN_DIAGONAL;
                this.processor = "Intel core";
                this.seria = "i3";
                this.color = DEFAULT_COLOR;
            }
            public Laptop(string processor, string seria){
                this.ram = MIN_RAM;
                this.diagonal = MIN_DIAGONAL;
                this.processor = processor;
                this.seria = seria;
                this.color = DEFAULT_COLOR;
            }
            public Laptop(int? ram, double? diagonal, string processor, string seria, string color = DEFAULT_COLOR){
                this.ram = ram;
                this.diagonal = diagonal;
                this.processor = processor;
                this.seria = seria;
                this.color = color;

                if (ram < MIN_RAM)
                {
                    this.ram = MIN_RAM;
                }
                if(ram > MAX_RAM){
                    this.ram = MAX_RAM;
                }

                if (diagonal < MIN_DIAGONAL)
                {
                    this.diagonal = MIN_DIAGONAL;
                }

                
            }

            public int? getRam(){return this.ram;}
            public double? getDiagonal(){return this.diagonal;}
            public string getProcessor(){return this.processor;}
            public string getSeria(){return this.seria;}
            public string getColor(){return this.color;}
            public void showInfo(){
                Console.WriteLine($" RAM: {(this.ram == null ? "None" : this.ram)}\n Diagonal: {this.diagonal}\n Processor: {this.processor}\n Seria: {this.seria}\n Color: {this.color}\n");
            }
            public void increaseRam()
            {
                ++this.ram;
                if(this.ram > MAX_RAM){
                    Console.WriteLine($"You have max Ram Value :)");this.ram = MAX_RAM;
                }
            }
            public void changeColor(){
                Console.Write("Enter new color: ");
                string newColor = Console.ReadLine(); 
                this.color = newColor;
            }
        }
        static void Main(string[] args)
        {
            
            Laptop l1 = new Laptop();
            Laptop l2 = new Laptop("intel core", "i7");
            Laptop l3 = new Laptop(8,16.7,"intel core", "i9");
            
            
            l1.increaseRam();
            l1.increaseRam();
            l1.changeColor();
            l1.showInfo();
            l2.showInfo();
            l3.showInfo();
        } 
    }
}