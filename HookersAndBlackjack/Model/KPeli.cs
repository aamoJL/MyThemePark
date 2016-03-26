using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookersAndBlackjack.Model
{
    public class KPeli
    {

        //Play
        public string Draw()
        {
            /*
            //Take bet
            if (Player.money >= bet)
            {
                Pelaaja.money -= bet;
            }
            else { TextBlock_Log.Text += "\nError: Not enough money."; }
            */

            //Select Random
            Random random = new Random();
            int rnd = random.Next(1 - 201);

            //Draw
            if (160 < rnd || rnd < 179)
            {
                return "555";
            }
            else if (178 < rnd || rnd < 189)
            {
                return "444";
            }
            else if (188 < rnd || rnd < 196)
            {
                return "333";
            }
            else if (195 < rnd || rnd < 200)
            {
                return "222";
            }
            else if (rnd == 200)
            {
                return "111";
            }
            else
            {
                string s = "";
                for (int i = 0; i < 3; i++)
                {
                    rnd = random.Next(1 - 6);
                    if (s.Contains(rnd.ToString()) == true)
                    {
                        i--;
                    }
                    else
                    {
                        s += "i";
                        s += rnd;
                    }
                }
                return s;
            }
        }
    }
}

//voittotaulukko
/*
1. 25x	0.5%	1
2. 10x	2%		4
3. 5x	3.5%	7
4. 2,5x	5%		10
5. 1x	9%		18
6. 0x	80%		160

160-178-188-195-199-200
*/