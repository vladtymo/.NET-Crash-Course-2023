using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApp3
{
    public class Weapon
    {
        int range_of_shoot { get; set; }
        int weapon_maxshootcount {get; set; }
        float weapon_calibr {get; set; }
        int weapon_shootcountnow {get; set; }
        public void Initialize(int range, float caliber, int maxSize, int nowsize)
        {
            range_of_shoot = range;
            weapon_maxshootcount = maxSize;
            weapon_calibr = caliber;
            weapon_shootcountnow = nowsize;
        }
        public bool Shot()
        {
            bool weapon_shoot;
            if (weapon_shootcountnow >= 1)
            {
                weapon_shootcountnow--;
                weapon_shoot = true;
            }
            else
            {
                Console.WriteLine("You dont have ammo");
                weapon_shoot = false;
            }
            return weapon_shoot;
        }

        public void Recharge()
        {
            Console.WriteLine("Wait, weapon reloading...");
            Thread.Sleep(2000);
            Console.WriteLine("Weapon reloaded");
            weapon_shootcountnow = weapon_maxshootcount;
        }

        public void Save()
        {
            var file_dir = @"C:\Users\Swayze\AppData\Local\Temp\weapon_info\";
            var file_name = @"C:\Users\Swayze\AppData\Local\Temp\weapon_info\weapon_info";

            FileInfo infofile = new FileInfo(file_name);
            DirectoryInfo oDirInfo = new DirectoryInfo(file_dir);

            oDirInfo.Delete(true);
            oDirInfo.Create();

            File.AppendAllText(file_name + "_range_of_shoot" + ".txt", range_of_shoot.ToString());
            File.AppendAllText(file_name + "_weapon_maxshootcount" + ".txt", weapon_maxshootcount.ToString());
            File.AppendAllText(file_name + "_weapon_calibr" + ".txt", weapon_calibr.ToString());
            File.AppendAllText(file_name + "_weapon_shootcountnow" + ".txt", weapon_shootcountnow.ToString());   
        }

        public void Load()
        {
            var file_name = @"C:\Users\Swayze\AppData\Local\Temp\weapon_info\weapon_info";

            FileInfo infofile = new FileInfo(file_name);

                range_of_shoot = int.Parse(File.ReadAllText(infofile+"_range_of_shoot.txt"));
                weapon_maxshootcount = int.Parse(File.ReadAllText(infofile + "_weapon_maxshootcount.txt"));
                weapon_calibr = float.Parse(File.ReadAllText(infofile + "_weapon_calibr.txt"));
                weapon_shootcountnow = int.Parse(File.ReadAllText(infofile + "_weapon_shootcountnow.txt"));
                Console.WriteLine(range_of_shoot);
                Console.WriteLine(weapon_shootcountnow);

        }
    }
    public class Program
    {
        enum Menu { Writeinfo = 1, shoot = 2, reload = 3, save = 4, load = 5 };
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon();
            while (true)
            {
                Console.WriteLine("Enter a number of task" + "\n" +
                    $"{(int)Menu.Writeinfo} Write info about weapon.\n" +
                    $"{(int)Menu.shoot} Shoot a weapon.\n" +
                    $"{(int)Menu.reload} Relaod weapon.\n" +
                    $"{(int)Menu.save} Save info about weapon.\n" +
                    $"{(int)Menu.load} Load info about weapon.");

                Menu task = (Menu)Enum.Parse(typeof(Menu), Console.ReadLine());

                switch (task)
                {
                    case Menu.Writeinfo:
                        Console.Write("Write range of shoot:");
                        int range = int.Parse(Console.ReadLine());
                        Console.Write("Write max shoot count:");
                        int maxSize = int.Parse(Console.ReadLine());
                        Console.Write("Write caliber of your weapon:");
                        float caliber = float.Parse(Console.ReadLine());
                        Console.Write("Write shoot count now:");
                        int nowsize = int.Parse(Console.ReadLine());
                        weapon.Initialize(range, caliber, maxSize, nowsize);
                        break;
                    case Menu.shoot:
                        weapon.Shot();
                        break;
                    case Menu.reload:
                        weapon.Recharge();
                        break;
                    case Menu.save: 
                        weapon.Save(); 
                        break;
                    case Menu.load:
                        weapon.Load();
                        break;
                    default: Console.WriteLine("I dont see this task"); break;
                }

            }
        }
    }
}
