﻿using System;
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
        private Table House = new Table();
        public Blackjack()
        {
            this.InitializeComponent();
        }

        private void Deal_Click(object sender, RoutedEventArgs e)
        {
            DebugScreen.Text = "";
            House.Deal(1);
        }

        private void DebugButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DebugScreen.Text = House.DebugMessage;
            }
            catch
            {
                DebugScreen.Text = "No Data";
            }
        }
    }
}
