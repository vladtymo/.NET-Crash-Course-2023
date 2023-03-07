using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9_HW_Task1
{
    internal class Comp
    {
        private int countDisk;
        private int countPrintDevice;
        private Disk[] disks;
        private IPrintInformation[] printDevice;

        public Comp(int d, int pd)
        {
            countDisk = d; 
            countPrintDevice = pd;
            disks = new Disk[countDisk];
            printDevice = new IPrintInformation[countPrintDevice];
        }
        public void AddDevice(int index, IPrintInformation si)
        {
            if(index < countPrintDevice)
                printDevice[index] = si;
            else
                Console.WriteLine("Нажаль перевищено ліміт девайсів!");
        }
        public void AddDisk(int index, Disk d)
        {
            if (index < countDisk)
                disks[index] = d;
            else
                Console.WriteLine("Нажаль перевищено ліміт дисків!");
        }
        public bool CheckDisk(string device)
        {
            foreach (IPrintInformation pd in printDevice)
            {
                if(pd.GetName() == device) return true;
            }
            return false;
        }
        public void InsertReject (string device, bool b)
        {
            if (!b)
            {
                Disk objD;
                foreach (Disk d in disks)
                {
                    if (d.GetName() == device)
                    {
                        objD = d;
                        break;
                    }
                }
            }
            else
            {
                CD d = new CD();
                disks[0] = d;
            }
        }
        public bool PrintInfo(string text, string device)
        {
            IPrintInformation pdObj;
            foreach (IPrintInformation pd in printDevice)
            {
                if (pd.GetName() == device) 
                { 
                    pdObj = pd;
                    Console.WriteLine($"Name: {pd.GetName()}");
                    return true;
                }
            }
            return false;
        }
        public string ReadInfo(string device)
        {
            foreach (IPrintInformation pd in printDevice)
            {
                if (pd.GetName() == device) return pd.GetName();
            }
            return "Такого девайсу не знайдено";
        }
        public void ShowDisk()
        {
            foreach (Disk d in disks)
            {
                Console.WriteLine($"MemSize: {d.MemSize}\n" +
                    $"Memory: {d.Memory}\n" +
                    $"Name: {d.GetName()}\n" + new string('-',35));
            }
        }
        public void ShowPrintDevice()
        {
            foreach (IPrintInformation pd in printDevice)
            {
                Console.WriteLine($"Name: {pd.GetName()}" + new string('-', 35));
            }
        }
        public bool WriteInfo(string text, string ShowDevice)
        {
            foreach (IPrintInformation pd in printDevice)
            {
                if (pd.GetName() == ShowDevice)
                {
                    Console.WriteLine($"{text}\nName: {pd.GetName()}" + new string('-', 35));
                    return true;
                }
            }
            return false;
        }
    }
}
