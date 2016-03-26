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
                int bet = int.Parse(textBlock_Bet.Text);
                string prize = kolikkopeli.Draw();
                int prize_int = int.Parse(prize);
                
                //Logitekstin muutos
                if(prize_int == 555)
                {
                    textBlock_Log.Text += "You Won" + bet * 1;
                }
                else if (prize_int == 444)
                {
                    textBlock_Log.Text += "You Won" + bet * 2.5;
                }
                else if (prize_int == 333)
                {
                    textBlock_Log.Text += "You Won" + bet * 5;
                }
                else if (prize_int == 222)
                {
                    textBlock_Log.Text += "You Won" + bet * 10;
                }
                else if (prize_int == 111)
                {
                    textBlock_Log.Text += "You Won" + bet * 25;
                }
                else
                {
                    textBlock_Log.Text += "You lost"+bet;
                }


                //image1
                Images(int.Parse(prize[0].ToString()), image1);
                Images(int.Parse(prize[1].ToString()), image2);
                Images(int.Parse(prize[2].ToString()), image3);
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
    }
    
    }
}

