using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookersAndBlackjack.Model
{
    class Kortti
    {
        public string Suit;
        public ushort Number;

        public Kortti() { }

        public Kortti(string suit, ushort number)
        {
            Suit = suit;
            Number = number;
        }

        public override string ToString()
        {
            return "\nSuit: " + Suit + ", Number: " + Number;
        }
    }
}
