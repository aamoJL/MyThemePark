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
    public sealed partial class Kolikkopeli : Page
    {
        KPeli kolikkopeli = new KPeli();
        int winnings = 0;
        //Player player = "valittu pelaaja classi";

        public Kolikkopeli()
        {
            this.InitializeComponent();
        }

        //mikähän tämä on xD
        private void textBox_TextChanged(System.Object sender, TextChangedEventArgs e)
        {

        }

        //Rullan pyöräytys
        private void button_Play_Click(object sender, RoutedEventArgs e)
        {
            /*
            if (player.bet(int.Parse(textBlock_Bet.Text)) == true)
            {
                winnings = 0;
                //button_Double.Disabled
                int bet = int.Parse(textBlock_Bet.Text);
                string prize = kolikkopeli.Draw();
                int prize_int = int.Parse(prize);

                //Kuvien vaihto
                Images(int.Parse(prize[0].ToString()), image1);
                Images(int.Parse(prize[1].ToString()), image2);
                Images(int.Parse(prize[2].ToString()), image3);
                
                //Voitot
                if (prize_int == 555)
                {
                    winnings = bet * 1;
                    textBlock_Log.Text += "You Won" + winnings+". Do You want to double?";
                    //player.AddMoney(winnings);
                    //button_Double.Visible

                    
                }
                else if (prize_int == 444)
                {
                    winnings = bet * 2;
                    textBlock_Log.Text += "You Won" + winnings+". Do You want to double?";
                    //player.AddMoney(winnings);
                    //button_Double.Visible
                }
                else if (prize_int == 333)
                {
                    winnings = bet * 5;
                    textBlock_Log.Text += "You Won" + winnings + ". Do You want to double?";
                    //player.AddMoney(winnings);
                    //button_Double.Visible
                }
                else if (prize_int == 222)
                {
                    winnings = bet * 10;
                    textBlock_Log.Text += "You Won" + winnings + ". Do You want to double?";
                    //player.AddMoney(winnings);
                    //button_Double.Visible
                }
                else if (prize_int == 111)
                {
                    winnings = bet * 25;
                    textBlock_Log.Text += "You Won" + winnings + ". Do You want to double?";
                    //player.AddMoney(winnings);
                    //button_Double.Visible
                }
                else
                {
                    textBlock_Log.Text += "You lost"+bet;
                    //button_Double.Disabled
                }
            }
            else
            {
                textBlock_Log.Text += "Error: Not enough money!";
            }
        */
        }

        //Kuvarullan kuvien vaihto
        private void Images(int i, Image img)
        {
            /*
                if (i == 5)
                {
                    img = kuva5;
                }
                else if (i == 4)
                {
                    img = kuva4;
                }
                else if (i == 3)
                {
                    img = kuva3;
                }
                else if (i == 2)
                {
                    img = kuva2;
                }
                else
                {
                    img = kuva1;
                }
            */
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            // get root frame (which show pages)
            Frame rootFrame = Window.Current.Content as Frame;
            // did we get it correctly
            if (rootFrame == null) return;
            // navigate back if possible
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }
        //Tuplaus
        /*
                //button_Double.isPressed())
                {
                    if(kolikkopeli.Double() == 1)
                    {
                        player.TakeMoney(winnings);
                        winnings = winnings * 2;
                        //player.AddMoney(winnings);
                    }
                    else
                    {
                        player.TakeMoney(winnings)
                    }
                }

                    */

    }

}


