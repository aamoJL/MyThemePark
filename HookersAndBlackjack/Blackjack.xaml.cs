using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using HookersAndBlackjack.Model;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HookersAndBlackjack
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Blackjack : Page
    {
        public Blackjack()
        {
            this.InitializeComponent();
        }

        private void Deal_Click(object sender, RoutedEventArgs e)
        {
            DebugScreen.Text = "";
            ushort n;
            Random rand = new Random();

            //Jokainen maa on oma lista
            List<Kortti> Spades = new List<Kortti>();
            List<Kortti> Hearts = new List<Kortti>();
            List<Kortti> Diamonds = new List<Kortti>();
            List<Kortti> Clubs = new List<Kortti>();
            //Pakka on myös lista, johon myöhemmin muut listat lisätään.
            List<Kortti> Pack = new List<Kortti>();
            //Käsi
            List<Kortti> Hand = new List<Kortti>();
            //Pöytä
            List<Kortti> House = new List<Kortti>();
            //Checker
            List<Kortti> Cheker = new List<Kortti>();
            //Ylimääräinen kortti. Sekoitusta varten.
            Kortti T = new Kortti();

            //Spades
            for (ushort i = 0; i < 13; i++)
            {
                Kortti kortti = new Kortti("♠", (ushort)(i + 1));
                Spades.Add(kortti);
            }
            //Hertta
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

            //Lisätään kaikki maat pakkaan.
            Pack.AddRange(Spades);
            Pack.AddRange(Hearts);
            Pack.AddRange(Diamonds);
            Pack.AddRange(Clubs);

            //Fisher-Yates sekoitus
            n = (ushort)Pack.Count;
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

            DebugScreen.Text += "Pack count: " + Pack.Count + "\n";
            DebugScreen.Text += "Hand count: " + Hand.Count + "\n";

            foreach (Kortti k in Hand)
            {
                DebugScreen.Text += k.ToString();
            }
        }
    }
}
