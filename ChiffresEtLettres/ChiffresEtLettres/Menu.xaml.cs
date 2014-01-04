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

namespace ChiffresEtLettres
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

        private void newHumanGame_Click(object sender, RoutedEventArgs e)
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
                    startGame();
                }
            }
        }

        private void newBotGame_Click(object sender, RoutedEventArgs e)
        {
            PlayerSetup playerDialog = new PlayerSetup();
            playerDialog.Owner = this;
            playerDialog.ShowDialog();
            if (!playerDialog.Cancel)
            {
                Player player = new Player(playerDialog.PlayerName);
                GameEngine.newGame(player);
                startGame();
            }
        }
        
        private void quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void startGame()
        {
            CompteEstBon phase1 = new CompteEstBon();
            App.Current.MainWindow = phase1;
            this.Close();
            phase1.Show();
        }
    }
}
