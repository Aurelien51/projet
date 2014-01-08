using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Countdown
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void countdownGame_Click(object sender, RoutedEventArgs e)
        {
            PlayerSetup playerDialog = new PlayerSetup();
            playerDialog.Owner = this;
            playerDialog.ShowDialog();
            if (!playerDialog.Cancel)
            {
                Player player1 = new Player(playerDialog.PlayerName);
                playerDialog = new PlayerSetup();
                playerDialog.Owner = this;
                playerDialog.ShowDialog();
                if (!playerDialog.Cancel)
                {
                    Player player2 = new Player(playerDialog.PlayerName);
                    GameEngine.newGame(player1, player2);
                    startCountdownGame();
                }
            }
        }

        private void longestwordGame_Click(object sender, RoutedEventArgs e)
        {
            PlayerSetup playerDialog = new PlayerSetup();
            playerDialog.Owner = this;
            playerDialog.ShowDialog();
            if (!playerDialog.Cancel)
            {
                Player player1 = new Player(playerDialog.PlayerName);
                playerDialog = new PlayerSetup();
                playerDialog.Owner = this;
                playerDialog.ShowDialog();
                if (!playerDialog.Cancel)
                {
                    Player player2 = new Player(playerDialog.PlayerName);
                    GameEngine.newGame(player1, player2);
                    startLongestwordGame();
                }
            }
        }
        
        private void quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void startCountdownGame()
        {
            CountdownWindow phase1 = new CountdownWindow();
            App.Current.MainWindow = phase1;
            this.Close();
            phase1.Show();
        }

        private void startLongestwordGame()
        {
            LongestWordWindow phase1 = new LongestWordWindow();
            App.Current.MainWindow = phase1;
            this.Close();
            phase1.Show();
        }
    }
}
