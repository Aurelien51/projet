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
            // Instantiate the dialog box
            PlayerSetup playerDialog = new PlayerSetup();

            // Configure the dialog box
            playerDialog.Owner = this;

            // Open the dialog box modally 
            playerDialog.ShowDialog();

            // Instantiate the dialog box
            playerDialog = new PlayerSetup();

            // Configure the dialog box
            playerDialog.Owner = this;

            // Open the dialog box modally 
            playerDialog.ShowDialog();
        }

        private void newBotGame_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private void quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
