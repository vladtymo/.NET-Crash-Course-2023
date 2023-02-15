using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_OOP
{
    internal class Weapon
    {
        string name;
        int range;
        int caliber;
        int curr_bullets;
        int max_bullets;

        public void Initialize(string name, int range, int caliber, int curr_bullets, int max_bullets)
        {
            this.name = name;   
            this.range = range;
            this.caliber = caliber;
            this.curr_bullets= curr_bullets;
            this.max_bullets = max_bullets;
        }

        public bool Shot()
        {
            if (curr_bullets > 0)
            {
                --curr_bullets;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void Recharge()
        {
            curr_bullets = max_bullets;
            Console.WriteLine("Gun was recharged");
        }


        public void Save(StreamWriter info)
        {
            info.WriteLine($"Gun: {name}; Range: {range}m; Caliber: {caliber}mm; Max magazine`s size: {max_bullets} bullet(-s)");
        }
    }
}
