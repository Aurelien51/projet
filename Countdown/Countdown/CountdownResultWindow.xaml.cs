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
            for (int i = 0; i < playerList.Length; i++)
            {
                Label tmp = new Label();
                tmp.Content = ""+(i+1)+"-";
                tmp.HorizontalAlignment = HorizontalAlignment.Left;
                tmp.VerticalAlignment = VerticalAlignment.Top;
                tmp.Width = 20;
                tmp.Margin = new Thickness(10, 10 + i * 33, 0, 0);
                this.grid.Children.Add(tmp);
                tmp = new Label();
                tmp.Content = playerList[i].Name;
                tmp.HorizontalAlignment = HorizontalAlignment.Left;
                tmp.VerticalAlignment = VerticalAlignment.Top;
                tmp.Width = 100;
                tmp.Margin = new Thickness(40, 10 + i * 33, 0, 0);
                this.grid.Children.Add(tmp);
                tmp = new Label();
                tmp.Content = playerList[i].Score;
                tmp.HorizontalAlignment = HorizontalAlignment.Left;
                tmp.VerticalAlignment = VerticalAlignment.Top;
                tmp.Margin = new Thickness(150, 10 + i * 33, 10, 10);
                this.grid.Children.Add(tmp);
            }
        }
    }
}
