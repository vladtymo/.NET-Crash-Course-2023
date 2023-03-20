using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_collections
{
    internal class Card
    {
        public string Suit { get; set; }
        public string Priority { get; set; }

        public Card(string suit, string priority)
        {
            this.Suit = suit;
            this.Priority = priority;
        }
    }
}
