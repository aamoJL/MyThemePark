using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookersAndBlackjack.Model
{
    interface IStatics
    {
        int Money { get; set; }
        int Chips { get; set; }
        int Loses { get; set; }
        int Games { get; set; }
        int Loans { get; set; }
    }
}
