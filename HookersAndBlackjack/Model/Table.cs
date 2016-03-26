using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using Windows.UI.Popups;

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
        
        // Tämä kutsutaan sivun avautuessa. Avaa popup ikkunan jonne tiedot laitetaan. Tai peritään.
        public async void Start ()
        {
            // create the message dialog and set its content
            var messageDialog = new MessageDialog("You thought your DDOS attack would succeed, it did not. You thought you could beat us, you can not. You can only hope to contain us, and fail.");
            // add commands and set theur callbacks; both buttons use the same callback function
            messageDialog.Commands.Add(new UICommand(
                "Ok",
                new UICommandInvokedHandler(this.CommandInvokedHandler)));

            messageDialog.Commands.Add(new UICommand(
                "Cancel",
                new UICommandInvokedHandler(this.CommandInvokedHandler)));

            // set the command that will be invoked by default
            messageDialog.DefaultCommandIndex = 0;
            // set the command to be invoked when escape is pressed
            messageDialog.DefaultCommandIndex = 1;

            await messageDialog.ShowAsync();
        }

        private void CommandInvokedHandler(IUICommand command)
        {
            // Display message showing the label of the command that was invoked
            Debug.WriteLine("The '" + command.Label + "' command has been selected.");
        }

        public void Deal (ushort NumberOfPacks)
        {
            Spades.Clear();
            Hearts.Clear();
            Diamonds.Clear();
            Clubs.Clear();
            Pack.Clear();
            Hand.Clear();

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
