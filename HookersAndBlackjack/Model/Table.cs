using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookersAndBlackjack.Model
{
    class Table
    {
        private Random rand = new Random();
        public string DebugMessage { get; set; }

        //Jokainen maa on oma lista
        private List<Kortti> Spades = new List<Kortti>();
        private List<Kortti> Hearts = new List<Kortti>();
        private List<Kortti> Diamonds = new List<Kortti>();
        private List<Kortti> Clubs = new List<Kortti>();
        //Pakka on myös lista, johon myöhemmin muut listat lisätään.
        private List<Kortti> Pack = new List<Kortti>();
        //Käsi
        private List<Kortti> Hand = new List<Kortti>();
        //Ylimääräinen kortti. Sekoitusta varten.
        private Kortti T = new Kortti();
        

        public void Deal (ushort NumberOfPacks)
        {
            DebugMessage = "";
            //Spades
            for (ushort i = 0; i < 13; i++)
            {
                Kortti kortti = new Kortti("♠", (ushort)(i + 1));
                Spades.Add(kortti);
            }
            //Hertz
            for (ushort i = 0; i < 13; i++)
            {
                Kortti kortti = new Kortti("♥", (ushort)(i + 1));
                Hearts.Add(kortti);
            }
            //Diamonds
            for (ushort i = 0; i < 13; i++)
            {
                Kortti kortti = new Kortti("♦", (ushort)(i + 1));
                Diamonds.Add(kortti);
            }
            //Clubs
            for (ushort i = 0; i < 13; i++)
            {
                Kortti kortti = new Kortti("♣", (ushort)(i + 1));
                Clubs.Add(kortti);
            }

            //Lisätään kaikki maat pakkaan ja lisätään
            for (ushort i = 0; i < NumberOfPacks; i++)
            {
                Pack.AddRange(Spades);
                Pack.AddRange(Hearts);
                Pack.AddRange(Diamonds);
                Pack.AddRange(Clubs);
            }

            //Fisher-Yates sekoitus
            ushort n = (ushort)Pack.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                T = Pack[k];
                Pack[k] = Pack[n];
                Pack[n] = T;
            }
            ushort x = (ushort)Pack.Count;
            for (n = 0; n < 2; n++)
            {
                x--;
                Hand.Add(Pack[x]);
                Pack.RemoveAt(x);
            }

            DebugMessage += "Pack count: " + Pack.Count + "\n";
            DebugMessage += "Hand count: " + Hand.Count + "\n";

            foreach (Kortti k in Hand)
            {
                DebugMessage += k.ToString();
            }
        }

        public Table() { }
    }
}
