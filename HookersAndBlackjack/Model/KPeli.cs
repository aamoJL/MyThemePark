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
        public void KPeli_play(int bet)
        {
            /*
            //Take bet
            if (Player.money >= bet)
            {
                Pelaaja.money -= bet;
            }
            else { TextBlock_Log.Text += "\nError: Not enough money."; }

            //Select Random
            Random random = new Random();
            int rnd = random.Next(1 - 201);

            //Draw
            if (160 < rnd < 179) { bet 1x}
            else if (178 < rnd < 189) { bet 2.5x}
            else if (188 < rnd < 196) { bet 5x}
            else if (195 < rnd < 200) { bet 10x}
            else if (200) { voitit pelin, bet 25x}
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    rnd = random.Next(1 - 6);


                    switch (rnd)
                    {
                        case 1: kuva1 = kvua1;
                            break;
                        case 2: kuva2 = kvua2;
                            break;
                        case 3: kuva3 = kvua3;
                            break;
                        default: TextBlock_Log.Text += "Error: error";
                            break;
                    }
                }
            }
            */
        }
    }
}

/*
1. 25x	0.5%	1
2. 10x	2%		4
3. 5x	3.5%	7
4. 2,5x	5%		10
5. 1x	9%		18
6. 0x	80%		160

160-178-188-195-199-200
*/