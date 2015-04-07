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

            PlayersList players = new PlayersList();

            this.StackPanelPlayers.Children.Add(players);
            PlayersList players2 = new PlayersList();
            this.StackPanelPlayers.Children.Add(players2);
            PlayersList players3 = new PlayersList();
            this.StackPanelPlayers.Children.Add(players3);
            PlayersList players4 = new PlayersList();
            this.StackPanelPlayers.Children.Add(players4);
            PlayersList players5 = new PlayersList();
            this.StackPanelPlayers.Children.Add(players5);
            PlayersList players6 = new PlayersList();
            this.StackPanelPlayers.Children.Add(players6);
            PlayersList players7 = new PlayersList();
            this.StackPanelPlayers.Children.Add(players7);
            PlayersList players8 = new PlayersList();
            this.StackPanelPlayers.Children.Add(players8);
            PlayersList players9 = new PlayersList();
            this.StackPanelPlayers.Children.Add(players9);
            PlayersList players10 = new PlayersList();
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