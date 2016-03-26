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
        public Kolikkopeli()
        {
            this.InitializeComponent();
        }

        private void textBox_TextChanged(System.Object sender, TextChangedEventArgs e)
        {

        }

        private void button_Play_Click(object sender, RoutedEventArgs e)
        {
            kolikkopeli.KPeli_play(int.Parse(textBlock_Bet.Text));
        }
    }
}
