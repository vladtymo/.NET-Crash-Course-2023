using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    internal class Exchange
    {
        public Exchange()
        {
            ExchangeRate = new Random().Next(1, 100);
        }
        public int ExchangeRate { get; set; }

        public event Action<int> UpdateDay;

        public void Update()
        {
            UpdateDay?.Invoke(ExchangeRate);
        }
    }
}
