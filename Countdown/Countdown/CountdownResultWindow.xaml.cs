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

namespace Countdown
{
    /// <summary>
    /// Interaction logic for CountdownResultWindow.xaml
    /// </summary>
    public partial class CountdownResultWindow : Window
    {
        public CountdownResultWindow()
        {
            InitializeComponent();

            var playerList = GameEngine.CurrentPhase.GetScores();
            foreach (Player player in playerList)
            {
                this.AddChild(new Label().Content = player.Name);
                this.AddChild(new Label().Content = player.Score);
            }
        }
    }
}
