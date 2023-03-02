using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_OOP_inharitance
{
    internal class Bird : Animal
    {
        private bool isPredator;
        public string FeathersColor { get; set; }
        public string FoodSpecialization { get; set; }
        public string Order { get; set; }

        public Bird(string species, float speed, int weight, string environment, string featherColor, string foodSpecialization, string order, bool isPredator)
            : base(species, speed, weight, environment)
        {
            FeathersColor = featherColor;
            FoodSpecialization = foodSpecialization;
            Order = order;
            this.isPredator = isPredator;
        }

        public new void MakeSound()
        {
            Console.WriteLine(" * Bird makes bird`s sound *");
        }

        public new void Move()
        {
            Console.WriteLine("Bird flying");
        }

        public void Hunt()
        {
            if (isPredator)
            {
                Console.WriteLine("Hunting");
            }
            else
            {
                Console.WriteLine("Birds of this food specialization can`t hunting");
            }
        }

      
    }
}
