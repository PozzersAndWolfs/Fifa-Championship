using System;
using System.Data.Linq.Mapping;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace FifaChampionshipWP
{
    public partial class PlayersPage : PhoneApplicationPage
    {
        public PlayersPage()
        {
            InitializeComponent();
            this.BuildLocalizedApplicationBar();
            Transitions.UseTurnstileTransition(this);

            PlayerPage players = new PlayerPage();

            this.StackPanelPlayers.Children.Add(players);
            PlayerPage players2 = new PlayerPage();
            this.StackPanelPlayers.Children.Add(players2);
            PlayerPage players3 = new PlayerPage();
            this.StackPanelPlayers.Children.Add(players3);
            PlayerPage players4 = new PlayerPage();
            this.StackPanelPlayers.Children.Add(players4);
            PlayerPage players5 = new PlayerPage();
            this.StackPanelPlayers.Children.Add(players5);
            PlayerPage players6 = new PlayerPage();
            this.StackPanelPlayers.Children.Add(players6);
            PlayerPage players7 = new PlayerPage();
            this.StackPanelPlayers.Children.Add(players7);
            PlayerPage players8 = new PlayerPage();
            this.StackPanelPlayers.Children.Add(players8);
            PlayerPage players9 = new PlayerPage();
            this.StackPanelPlayers.Children.Add(players9);
            PlayerPage players10 = new PlayerPage();
            this.StackPanelPlayers.Children.Add(players10);
        }

        // Sample code for building a localized ApplicationBar
        private void BuildLocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();

            // Create a new button and set the text value to the localized string from AppResources.
            ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/add.png", UriKind.Relative));
            appBarButton.Text = "novo";
            appBarButton.Click += appBarButton_Click;
            ApplicationBar.Buttons.Add(appBarButton);
        }

        void appBarButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/NewPlayerPage.xaml", UriKind.RelativeOrAbsolute));
            
        }
    }
}