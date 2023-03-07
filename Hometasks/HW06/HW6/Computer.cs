using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static HW6.RAM;

namespace HW6
{
    internal class Laptop
    {
        private readonly string name;
        private int memory { get; set; }
        private int ram { get; set; }
        private CPU cpu { get; set; }
        private GPU gpu { get; set; }

        public Laptop() { }
        public Laptop(string name, CPU cpu, GPU gpu, int ram, int memory) 
        {
            this.name = name;
            this.cpu = cpu;
            this.gpu = gpu;
            this.ram = ram;
            this.memory = memory;
        }

        public void Print()
        {
            Console.WriteLine($"Laptop:\nName: {name};");
            cpu.Print();
            gpu.Print();
            Console.WriteLine($"RAM: {ram} GB");
            Console.WriteLine($"Memory: {memory} GB\n");
        }

        public void AddMemory(int memory)
        {
            this.memory += memory;
        }
        public void AddRam(int ram)
        {
            this.ram += ram;
        }
    }

    internal class PC
    {
        private MotherBoard motherBoard { get; set; }
        private List<Drive> drives { get; set; }
        private List<RAM> rams { get; set; }
        private CPU cpu { get; set; }
        private GPU gpu { get; set; }
        private PowerSupply powerSupply { get; set; }

        public PC() { }
        public PC(MotherBoard motherBoard, CPU cpu, GPU gpu, PowerSupply powerSupply, List<RAM> rams, List<Drive> drives) 
        {
            this.motherBoard = motherBoard;
            this.cpu = cpu;
            this.gpu = gpu;
            this.powerSupply = powerSupply;
            this.rams = rams;
            this.drives = drives;
        }

        public void Print()
        {
            Console.WriteLine("PC:");
            cpu.Print();
            gpu.Print();
            Console.WriteLine("RAM:");
            PrintRam();
            Console.WriteLine("Memory:");
            PrintDrives();
            powerSupply.Print();
            Console.WriteLine();
        }
        
        private void PrintRam()
        {
            foreach(RAM ram in rams)
                ram.Print();
        }

        private void PrintDrives()
        {
            foreach (Drive drive in drives)
                drive.Print();
        }

        public void AddRam(RAM ram)
        {
            rams.Add(ram);
        }

        public void AddDrive(Drive drive)
        {
            drives.Add(drive);
        }
    }

    internal class CPU
    { 
        private string name;
        private int frequency;
        private int cores;
        public CPU(string name, int frequency, int cores)
        {
            this.name = name;
            this.frequency = frequency;
            this.cores = cores;
        }
        public void Print() { Console.WriteLine($"CPU: Name: {name},\tCores: {cores},\tFrequency: {frequency} MHz;"); }
    }

    internal class GPU
    {
        private string name;
        private int videoMemory;
        public GPU(string name, int videoMemory)
        {
            this.name = name;
            this.videoMemory = videoMemory;
        }
        public void Print() { Console.WriteLine($"GPU: Name: {name},\tVideo Memory: {videoMemory} GB;"); }
    }

    internal class RAM
    {
        public enum RamType { SDR, DDR, DDR2, DDR3, DDR4, DDR5 }
        private string name;
        private int memory;
        private int frequency;
        private RamType ramType;
        public RAM(string name, int memory, int frequency, RamType ramType)
        {
            this.name = name;
            this.memory = memory;
            this.frequency = frequency;
            this.ramType = ramType;
        }
        public void Print() { Console.WriteLine($"Name: {name},\tRAM Type: {ramType.ToString()},\tMemory: {memory} GB,\tFrequency: {frequency} MHz;"); }
    }

    internal class Drive
    {
        public enum DriveType { HDD, SSD, SSD_M2, Flash }
        private string name;
        private int memory;
        private int frequency;
        private DriveType driveType;
        public Drive(string name, int memory, int frequency, DriveType driveType)
        {
            this.name = name;
            this.memory = memory;
            this.frequency = frequency;
            this.driveType = driveType;
        }
        public void Print() { Console.WriteLine($"Name: {name},\tDrive Type: {driveType.ToString()},\tMemory: {memory} GB,\tFrequency: {frequency} MHz;"); }
    }

    internal class MotherBoard
    {
        public enum FormFactor { Pico_ITX, Nano_ITX, Mini_ITX, Micro_ATX, ATX, E_ATX }
        private string name;
        private string socket;
        private FormFactor formFactor;
        public MotherBoard(string name, string socket, FormFactor formFactor)
        {
            this.name = name;
            this.socket = socket;
            this.formFactor = formFactor;
        }
        public void Print() { Console.WriteLine($"MotherBoard: Name: {name},\tForm Factor: {formFactor.ToString()},\tSocket: {socket};"); }
    }

    internal class PowerSupply 
    {
        private string name;
        private int power;
        public PowerSupply(string name, int power)
        {
            this.name = name;
            this.power = power;
        }
        public void Print() { Console.WriteLine($"Power Supply: Name: {name},\tPower: {power} watt;"); }
    }
}
