using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookersAndBlackjack.Model
{
    class Human : Player
    {
        public Statics statics { get; set; }

        public Human(string name, int ai):base(name,ai)
        {
            statics.Money = 200;
            statics.Chips = 0;
            statics.Games = 0;
            statics.Loses = 0;
            statics.Loans = 0;
        }
    }
}
