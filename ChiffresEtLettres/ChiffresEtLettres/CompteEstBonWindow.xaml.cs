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
    public partial class CompteEstBonWindow : Window
    {
        private Button[,] mathGridButtons;
        private Button[] numbers;
        private Button[] signs;

        public Button NextNumberButton
        {
            get
            {
                switch (this.Rules.CurrentOperationCol)
                {
                    case 0:
                        return this.mathGridButtons[2, this.Rules.CurrentOperationRow-1];
                    case 1:
                        return this.mathGridButtons[0, this.Rules.CurrentOperationRow];
                }
                return null;
            }
        }
        public Button NextSignButton
        {
            get { return this.mathGridButtons[1, this.Rules.CurrentOperationRow]; }
        }

        /*private int row = 0;
        public int Row
        {
            get { return this.row; }
        }
        private int col = 0;
        public int Col
        {
            get { return this.col; }
        }
        public int CurrButton
        {
            get { return this.row; }
            set
            {
                if (value > 2)
                {
                    row = 0;
                    this.numberNumber = 0;
                    mathGridButtons[3, col].Tag = this.Rules.Calculate(numberOne, numberTwo, sign);
                    mathGridButtons[3, col].Content = ((Number)mathGridButtons[3, col].Tag).Value;
                    mathGridButtons[3, col].IsEnabled = true;
                    SwitchToNumberChoice();
                    col++;
                }
                else
                    row = value;
            }
        }*/

        public int numberNumber = 0;
        public Number numberOne;
        public Number.Sign sign;
        public Number numberTwo;

        public CompteEstBon Rules
        {
            get { return (CompteEstBon)(GameEngine.CurrentPhase); }
        }

        public CompteEstBonWindow()
        {
            InitializeComponent();

            mathGridButtons = new Button[4, 5];
            numbers = new Button[10];
            signs = new Button[4];

            signs[0] = plusButton;
            plusButton.Tag = Number.Sign.Plus;
            signs[1] = minusButton;
            minusButton.Tag = Number.Sign.Minus;
            signs[2] = multiplyButton;
            multiplyButton.Tag = Number.Sign.Multiply;
            signs[3] = divideButton;
            divideButton.Tag = Number.Sign.Divide;

            foreach (Button sign in signs)
            {
                sign.Click += AddSignButton;
            }

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
                mathGridButtons[0, i] = tmp;

                tmp = new Button();
                tmp.IsEnabled = false;
                tmp.Width = 23;
                tmp.Height = 23;
                tmp.Margin = new Thickness(70, i * 50 + 10, 0, 0);
                tmp.HorizontalAlignment = HorizontalAlignment.Left;
                tmp.VerticalAlignment = VerticalAlignment.Top;
                calculGrid.Children.Add(tmp);
                mathGridButtons[1, i] = tmp;

                tmp = new Button();
                tmp.IsEnabled = false;
                tmp.Width = 50;
                tmp.Height = 23;
                tmp.Margin = new Thickness(103, i * 50 + 10, 0, 0);
                tmp.HorizontalAlignment = HorizontalAlignment.Left;
                tmp.VerticalAlignment = VerticalAlignment.Top;
                calculGrid.Children.Add(tmp);
                mathGridButtons[2, i] = tmp;

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

                tmp = new Button();
                tmp.IsEnabled = false;
                tmp.Width = 50;
                tmp.Height = 23;
                tmp.Margin = new Thickness(196, i * 50 + 10, 0, 0);
                tmp.HorizontalAlignment = HorizontalAlignment.Left;
                tmp.VerticalAlignment = VerticalAlignment.Top;
                calculGrid.Children.Add(tmp);
                mathGridButtons[3, i] = tmp;
                if (i < 4)
                    numbers[6 + i] = tmp;
            }

            this.numberLabel.Content = this.Rules.NumberToReach;

            for (int i = 0; i < this.Rules.NumbersAvailable.Length; i++)
            {
                Button tmp = new Button();
                tmp.Width = 40;
                tmp.Height = 23;
                tmp.Margin = new Thickness(i * 50 + 50, 10, 0, 0);
                tmp.HorizontalAlignment = HorizontalAlignment.Left;
                tmp.VerticalAlignment = VerticalAlignment.Top;
                tmp.Content = this.Rules.NumbersAvailable[i].Value;
                tmp.Click += AddNumberButton;
                tmp.Tag = this.Rules.NumbersAvailable[i];
                this.numbersGrid.Children.Add(tmp);
                numbers[i] = tmp;
            }
        }

        private void AddNumberButton(object sender, RoutedEventArgs e)
        {
            if (this.Rules.addNumber((Number)((Button)sender).Tag))
            {
                this.NextNumberButton.Content = ((Number)(((Button)sender).Tag)).Value;
                this.NextNumberButton.Tag = ((Button)sender).Tag;
                this.NextNumberButton.IsEnabled = true;
                UpdateResults();
                if (this.Rules.CurrentOperationCol == 1)
                    SwitchToSignChoice();
                else
                    SwitchToNumberChoice();
            }
        }

        private void AddSignButton(object sender, RoutedEventArgs e)
        {
            this.Rules.addSign((Number.Sign)((Button)sender).Tag);
            this.NextSignButton.Content = ((Button)sender).Content;
            this.NextSignButton.Tag = ((Button)sender).Content;
            this.NextSignButton.IsEnabled = true;
            SwitchToNumberChoice();
        }

        private void UpdateResults()
        {
            for (int i = 0; i < this.Rules.NumbersFound.Length; i++ )
            {
                if (this.Rules.NumbersFound[i] != null)
                {
                    this.mathGridButtons[3, i].Tag = this.Rules.NumbersFound[i];
                    this.mathGridButtons[3, i].Content = this.Rules.NumbersFound[i].Value;
                    this.mathGridButtons[3, i].IsEnabled = !this.Rules.NumbersFound[i].HasBeenUsed;
                }
            }
        }

        private void SwitchToSignChoice()
        {
            foreach (Button sign in signs)
            {
                sign.IsEnabled = true;
            }
            foreach (Button number in numbers)
            {
                number.IsEnabled = false;
            }
        }

        private void SwitchToNumberChoice()
        {
            foreach (Button number in numbers)
            {
                if (number.Tag != null)
                    number.IsEnabled = !((Number)number.Tag).HasBeenUsed;
            }
            foreach (Button sign in signs)
            {
                sign.IsEnabled = false;
            }
        }
    }
}