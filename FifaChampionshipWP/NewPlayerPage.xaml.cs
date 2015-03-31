using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace FifaChampionshipWP
{
    public partial class NewPlayer : PhoneApplicationPage
    {

        public NewPlayer()
        {
            InitializeComponent();
            Transitions.UseSlideTransition(this, SlideTransitionMode.SlideUpFadeIn, SlideTransitionMode.SlideUpFadeOut);
            
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            
        }
    }
}