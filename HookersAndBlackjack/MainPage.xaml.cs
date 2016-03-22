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
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HookersAndBlackjack
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Deal_Click(object sender, RoutedEventArgs e)
        {
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
                Kortti kortti = new Kortti("Spades", (ushort)(i + 1));
                Spades.Add(kortti);
            }
            DebugScreen.Text += "Spades dun.\n";
            //Hertta
            for (ushort i = 0; i < 13; i++)
            {
                Kortti kortti = new Kortti("Hearts", (ushort)(i + 1));
                Hearts.Add(kortti);
            }
            DebugScreen.Text += "Hearts dun.\n";
            //Diamonds
            for (ushort i = 0; i < 13; i++)
            {
                Kortti kortti = new Kortti("Diamonds", (ushort)(i + 1));
                Diamonds.Add(kortti);
            }
            DebugScreen.Text += "Diamonds dun.\n";
            //Clubs
            for (ushort i = 0; i < 13; i++)
            {
                Kortti kortti = new Kortti("Clubs", (ushort)(i + 1));
                Clubs.Add(kortti);
            }
            DebugScreen.Text += "Clubs dun.\n";

            //Lisätään kaikki maat pakkaan.
            Pack.AddRange(Spades);
            Pack.AddRange(Hearts);
            Pack.AddRange(Diamonds);
            Pack.AddRange(Clubs);
            DebugScreen.Text += "Pack dun.\n";

            //Printataan koko pakka huvin vuoksi.
            /*
            foreach (Kortti k in Pack)
            {
                Console.Write(k.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("\nAnd now randomized.");
            */
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
            DebugScreen.Text += "Shuffle dun.\n";

            //Nyt printataan koko pakka uudestaan
            /*
            foreach (Kortti k in Pack)
            {
                Console.Write(k.ToString());
            }
            */
            ushort x = (ushort)Pack.Count;
            for (n = 0; n < 5; n++)
            {
                x--;
                Hand.Add(Pack[x]);
                Pack.RemoveAt(x);
            }
            DebugScreen.Text += "Hand dun.\n";

            DebugScreen.Text += "Pack count: " + Pack.Count + "\n";
            DebugScreen.Text += "Hand count: " + Hand.Count + "\n";

            foreach (Kortti k in Hand)
            {
                DebugScreen.Text += k.ToString();
            }
        }
    }
}
