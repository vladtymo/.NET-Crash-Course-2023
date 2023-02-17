using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace crash_course_OOP
{
    internal class Weapon
    {
        [JsonProperty]
        private string name;
        
        [JsonProperty]
        private int range;
        
        [JsonProperty]
        private int caliber;
        
        [JsonProperty]
        private int curr_bullets;

        [JsonProperty]
        private int max_bullets;

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

        
        public void Save(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string output = JsonConvert.SerializeObject(this, Formatting.Indented);
                writer.Write(output);
            }
        }

        public static Weapon Load(string filePath)
        {
            string weaponInfo;
            using (StreamReader reader = new StreamReader(filePath))
            {
                weaponInfo = reader.ReadToEnd();
            }

            Console.Write(weaponInfo);
            Weapon weapon = JsonConvert.DeserializeObject<Weapon>(weaponInfo);

            return weapon;
        }
    }
}
