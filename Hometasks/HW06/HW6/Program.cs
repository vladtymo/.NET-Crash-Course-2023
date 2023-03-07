namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop
                ( 
                "Lenovo Legion 5", 
                new CPU("AMD Ryzen 7 4800H", 12, 3200), 
                new GPU("NVIDIA GeForce RTX 2060", 4),
                16, 
                2048
                );

            PC pc = new PC
                (
                new MotherBoard("MSI MAG B550 TOMAHAWK", "AM4", MotherBoard.FormFactor.Micro_ATX),
                new CPU("AMD Ryzen 5 5600X", 12, 3200),
                new GPU("NVIDIA GeForce RTX 2060", 4),
                new PowerSupply("Gamemax GM-500B", 500),
                new List<RAM> { new RAM("Kingston Fury Beast", 8, 3200, RAM.RamType.DDR4), new RAM("Kingston Fury Beast", 8, 3200, RAM.RamType.DDR4) },
                new List<Drive> { new Drive("SSD GOODRAM CL100 GEN 3 SSDPR-CL100-960-G3", 960, 3200, Drive.DriveType.SSD), new Drive("Seagate BarraCuda Compute ST2000DM008", 2048, 7200, Drive.DriveType.HDD) }
                );

            laptop.Print();
            pc.Print();

            laptop.AddRam(16);
            laptop.AddMemory(512);
            Console.WriteLine("Laptop: Added ram and memory...\n");
            laptop.Print();

            pc.AddRam(new RAM("Kingston Fury Beast", 8, 3200, RAM.RamType.DDR4));
            pc.AddDrive(new Drive("Kingston FURY Renegade", 4096, 3200, Drive.DriveType.SSD_M2));
            Console.WriteLine("PC: Added ram and memory...\n");
            pc.Print();
        }
    }
}