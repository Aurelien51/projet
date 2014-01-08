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
    /// Interaction logic for LongestWordWindow.xaml
    /// </summary>
    public partial class LongestWordWindow : Window
    {
        public LongestWordWindow()
        {
            InitializeComponent();
            LongestWord l = new LongestWord();
            button1.Content = l.lettersAvailable[0];
            button2.Content = l.lettersAvailable[1];
            button3.Content = l.lettersAvailable[2];
            button4.Content = l.lettersAvailable[3];
            button5.Content = l.lettersAvailable[4];
            button6.Content = l.lettersAvailable[5];
            button7.Content = l.lettersAvailable[6];
            button8.Content = l.lettersAvailable[7];
            button9.Content = l.lettersAvailable[8];
            button10.Content = l.lettersAvailable[9];
            button1.IsEnabled = true;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = button1.Content;
        }
    }
}
