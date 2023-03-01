using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08_inheritance
{
    internal class Catfish : Fish
    {
        public Catfish() : base("Common catfish",25f, 90.5f, "lives in deep areas of rivers", false) { }
        Catfish(string kind,float speed,float weight,string? environment,bool isSaltWater) 
            : base(kind,speed,weight,environment,isSaltWater){ }
    }
}
