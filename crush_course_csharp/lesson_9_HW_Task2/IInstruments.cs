using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9_HW_Task2
{
    internal interface IInstruments
    {
        public string Producer { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public void WriteInfo();
        public bool ChangePrice(double newPrice);
    }
}
