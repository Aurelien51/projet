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
using System.Windows.Shapes;

namespace ChiffresEtLettres
{
    /// <summary>
    /// Interaction logic for PlayerSetup.xaml
    /// </summary>
    public partial class PlayerSetup : Window
    {
        private bool cancel = true;
        public bool Cancel
        {
            get { return this.cancel; }
            private set { this.cancel = value; }
        }

        public String PlayerName
        {
            get { return this.playerName.Text; }
        }

        public PlayerSetup()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            this.Cancel = false;
            if (this.PlayerName != "")
                this.Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}