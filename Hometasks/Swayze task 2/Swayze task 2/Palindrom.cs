using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Swayze_task_2
{
    internal class Palindrom
    {
        public void comparasion()
        {
            Console.Write("Enter a number:");
            string number = Console.ReadLine();

            char[] nums = number.ToCharArray();

            int g = 0;

            for(int i =0; i < nums.Length; i++)
            {
                if (nums[i] == nums[nums.Length-1 - i])
                {
                    g++;
                }
            }
            if (g == nums.Length)
            {
                Console.WriteLine("Palidrom");
            }
            else
            {
                Console.WriteLine("Not palidrom");
            }
        }
    }
}
