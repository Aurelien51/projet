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
    /// Interaction logic for CompteEstBon.xaml
    /// </summary>
    public partial class CompteEstBon : Window
    {
        private UIElement[,] buttons;

        public CompteEstBon()
        {
            InitializeComponent();

            buttons = new UIElement[5,5];

            for (int i = 0; i < 5; i++)
            {
                var tmp = new Button();
                tmp.IsEnabled = false;
                tmp.Width = 50;
                tmp.Height = 23;
                tmp.Margin = new Thickness(10, i * 50 + 10, 0, 0);
                tmp.HorizontalAlignment = HorizontalAlignment.Left;
                tmp.VerticalAlignment = VerticalAlignment.Top;
                calculGrid.Children.Add(tmp);
                buttons[0, i] = tmp;

                tmp = new Button();
                tmp.IsEnabled = false;
                tmp.Width = 23;
                tmp.Height = 23;
                tmp.Margin = new Thickness(70, i * 50 + 10, 0, 0);
                tmp.HorizontalAlignment = HorizontalAlignment.Left;
                tmp.VerticalAlignment = VerticalAlignment.Top;
                calculGrid.Children.Add(tmp);
                buttons[1, i] = tmp;

                tmp = new Button();
                tmp.IsEnabled = false;
                tmp.Width = 50;
                tmp.Height = 23;
                tmp.Margin = new Thickness(103, i * 50 + 10, 0, 0);
                tmp.HorizontalAlignment = HorizontalAlignment.Left;
                tmp.VerticalAlignment = VerticalAlignment.Top;
                calculGrid.Children.Add(tmp);
                buttons[2, i] = tmp;

                Label lTmp = new Label();
                lTmp.IsEnabled = false;
                lTmp.FontSize = 14;
                lTmp.Content = '=';
                lTmp.HorizontalContentAlignment = HorizontalAlignment.Center;
                lTmp.VerticalContentAlignment = VerticalAlignment.Top;
                lTmp.Width = 23;
                lTmp.Height = 23;
                lTmp.Margin = new Thickness(163, i * 50 + 10, 0, 0);
                lTmp.HorizontalAlignment = HorizontalAlignment.Left;
                lTmp.VerticalAlignment = VerticalAlignment.Top;
                calculGrid.Children.Add(lTmp);
                buttons[3, i] = lTmp;

                tmp = new Button();
                tmp.IsEnabled = false;
                tmp.Width = 50;
                tmp.Height = 23;
                tmp.Margin = new Thickness(196, i * 50 + 10, 0, 0);
                tmp.HorizontalAlignment = HorizontalAlignment.Left;
                tmp.VerticalAlignment = VerticalAlignment.Top;
                calculGrid.Children.Add(tmp);
                buttons[4, i] = tmp;
            }
        }
    }
}
