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
        private static String res;
        private Button[] charButton = new Button[10];
        private LongestWord l = new LongestWord();
        private int tmp = -1;
        private static int indexTab = 0;
        public LongestWordWindow()
        {
           
            InitializeComponent();
            res = "";
            
            charButton[0] = button1;
            button1.Content = l.lettersAvailable[0];
            charButton[1] = button2;
            button2.Content = l.lettersAvailable[1];
            charButton[2] = button3;
            button3.Content = l.lettersAvailable[2];
            charButton[3] = button4;
            button4.Content = l.lettersAvailable[3];
            charButton[4] = button5;
            button5.Content = l.lettersAvailable[4];
            charButton[5] = button6;
            button6.Content = l.lettersAvailable[5];
            charButton[6] = button7;
            button7.Content = l.lettersAvailable[6];
            charButton[7] = button8;
            button8.Content = l.lettersAvailable[7];
            charButton[8] = button9;
            button9.Content = l.lettersAvailable[8];
            charButton[9] = button10;
            button10.Content = l.lettersAvailable[9];
            button1.IsEnabled = true;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            res += button1.Content;
            label1.Content = res;
            button1.IsEnabled = false;
            tmp = 0;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            res += button2.Content;
            label1.Content = res;
            button2.IsEnabled = false;
            tmp = 1;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            res += button3.Content;
            label1.Content = res;
            button3.IsEnabled = false;
            tmp = 2;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            res += button4.Content;
            label1.Content = res;
            button4.IsEnabled = false;
            tmp = 3;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            res += button5.Content;
            label1.Content = res;
            button5.IsEnabled = false;
            tmp = 4;
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            res += button6.Content;
            label1.Content = res;
            button6.IsEnabled = false;
            tmp = 5;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            res += button7.Content;
            label1.Content = res;
            button7.IsEnabled = false;
            tmp = 6;
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            res += button8.Content;
            label1.Content = res;
            button8.IsEnabled = false;
            tmp = 7;
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            res += button9.Content;
            label1.Content = res;
            button9.IsEnabled = false;
            tmp = 8;
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            res += button10.Content;
            label1.Content = res;
            button10.IsEnabled = false;
            tmp = 9;
        }

        private void validate_Click(object sender, RoutedEventArgs e)
        {
            l.SearchWord(res);
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            res = "";
            label1.Content = "";
            button1.IsEnabled = true;
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            button5.IsEnabled = true;
            button6.IsEnabled = true;
            button7.IsEnabled = true;
            button8.IsEnabled = true;
            button9.IsEnabled = true;
            button10.IsEnabled = true;
            tmp = -1;
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            if (res.Length != 0)
            {
                res = res.Substring(0, res.Length - 1);
            }
            if (res == "")
            {
                button1.IsEnabled = true;
            }

            label1.Content = res;
            switch (tmp)
            {
                case (0):
                    button1.IsEnabled = true;
                    break;
                case (1):
                    button2.IsEnabled = true;
                    break;
                case (2):
                    button3.IsEnabled = true;
                    break;
                case (3):
                    button4.IsEnabled = true;
                    break;
                case (4):
                    button5.IsEnabled = true;
                    break;
                case (5):
                    button6.IsEnabled = true;
                    break;
                case (6):
                    button7.IsEnabled = true;
                    break;
                case (7):
                    button8.IsEnabled = true;
                    break;
                case (8):
                    button9.IsEnabled = true;
                    break;
                case (9):
                    button10.IsEnabled = true;
                    break;
            }
        }

        private void consonne_Click(object sender, RoutedEventArgs e)
        {
            if (indexTab <= 10)
            {
                switch (indexTab)
                {
                    case (0):
                        l.lettersAvailable[indexTab] = l.letters.consonant();
                        button1.Content = l.lettersAvailable[indexTab];
                        break;
                    case (1):
                        l.lettersAvailable[indexTab] = l.letters.consonant();
                        button2.Content = l.lettersAvailable[indexTab];
                        break;
                    case (2):
                        l.lettersAvailable[indexTab] = l.letters.consonant();
                        button3.Content = l.lettersAvailable[indexTab];
                        break;
                    case (3):
                        l.lettersAvailable[indexTab] = l.letters.consonant();
                        button4.Content = l.lettersAvailable[indexTab];
                        break;
                    case (4):
                        l.lettersAvailable[indexTab] = l.letters.consonant();
                        button5.Content = l.lettersAvailable[indexTab];
                        break;
                    case (5):
                        l.lettersAvailable[indexTab] = l.letters.consonant();
                        button6.Content = l.lettersAvailable[indexTab];
                        break;
                    case (6):
                        l.lettersAvailable[indexTab] = l.letters.consonant();
                        button7.Content = l.lettersAvailable[indexTab];
                        break;
                    case (7):
                        l.lettersAvailable[indexTab] = l.letters.consonant();
                        button8.Content = l.lettersAvailable[indexTab];
                        break;
                    case (8):
                        l.lettersAvailable[indexTab] = l.letters.consonant();
                        button9.Content = l.lettersAvailable[indexTab];
                        break;
                    case (9):
                        l.lettersAvailable[indexTab] = l.letters.consonant();
                        button10.Content = l.lettersAvailable[indexTab];
                        break;
                }
                indexTab++;
            }
        }

        private void voyelle_Click(object sender, RoutedEventArgs e)
        {
            if (indexTab <= 10)
            {
                switch (indexTab)
                {
                    case (0):
                        l.lettersAvailable[indexTab] = l.letters.vowel();
                        button1.Content = l.lettersAvailable[indexTab];
                        break;
                    case (1):
                        l.lettersAvailable[indexTab] = l.letters.vowel();
                        button2.Content = l.lettersAvailable[indexTab];
                        break;
                    case (2):
                        l.lettersAvailable[indexTab] = l.letters.vowel();
                        button3.Content = l.lettersAvailable[indexTab];
                        break;
                    case (3):
                        l.lettersAvailable[indexTab] = l.letters.vowel();
                        button4.Content = l.lettersAvailable[indexTab];
                        break;
                    case (4):
                        l.lettersAvailable[indexTab] = l.letters.vowel();
                        button5.Content = l.lettersAvailable[indexTab];
                        break;
                    case (5):
                        l.lettersAvailable[indexTab] = l.letters.vowel();
                        button6.Content = l.lettersAvailable[indexTab];
                        break;
                    case (6):
                        l.lettersAvailable[indexTab] = l.letters.vowel();
                        button7.Content = l.lettersAvailable[indexTab];
                        break;
                    case (7):
                        l.lettersAvailable[indexTab] = l.letters.vowel();
                        button8.Content = l.lettersAvailable[indexTab];
                        break;
                    case (8):
                        l.lettersAvailable[indexTab] = l.letters.vowel();
                        button9.Content = l.lettersAvailable[indexTab];
                        break;
                    case (9):
                        l.lettersAvailable[indexTab] = l.letters.vowel();
                        button10.Content = l.lettersAvailable[indexTab];
                        break;
                }
                indexTab++;
            }
        }
    }
}
