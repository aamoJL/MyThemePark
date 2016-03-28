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
using Windows.UI.Popups;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

using HookersAndBlackjack.Model;

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
            // House.Start();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is Table)
            { DebugScreen.Text += "Jotain Tapahtuu"; }
            Table house = (Table)e.Parameter;
            House.PackNumber = house.PackNumber;
            House.StakeSize = house.StakeSize;
            try
            {
                House.Deal();
            } catch
            {
                DebugScreen.Text += "Could not deal\n";
            }
            base.OnNavigatedTo(e);
        }
        // Deal buttoni on vain debugausta varten
        private void Deal_Click(object sender, RoutedEventArgs e)
        {
            DebugScreen.Text = "";
            House.Deal();
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

        private void Hit_Click(object sender, RoutedEventArgs e)
        {
            House.Hit();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // get root frame (which shows pages)
            Frame rootFrame = Window.Current.Content as Frame;
            // did we get it correctly
            if (rootFrame == null) return;
            // navigate back if possible
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }
    }
}
