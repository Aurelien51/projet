using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChiffresEtLettres
{
    public class CompteEstBon : Phase
    {
        private Number numberToReach;
        public int NumberToReach
        {
            get { return numberToReach.Value; }
        }
        public Number[] NumbersAvailable
        {
            get;
            private set;
        }
        public int[] NumbersFound
        {
            get;
            set;
        }

        public CompteEstBon()
        {
            Random random = new Random();
            this.numberToReach = new Number(random.Next(100, 999));
            this.NumbersAvailable = new Number[6];
            for (int i = 0; i < 6; i++)
            {
                this.NumbersAvailable[i] = new Number(random.Next(1, 14));
                switch (this.NumbersAvailable[i].Value)
                {
                    case (11):
                        this.NumbersAvailable[i].Value = 25;
                        break;
                    case (12):
                        this.NumbersAvailable[i].Value = 50;
                        break;
                    case (13):
                        this.NumbersAvailable[i].Value = 75;
                        break;
                    case (14):
                        this.NumbersAvailable[i].Value = 100;
                        break;
                }
            }
        }

        public Number Calculate(Number firstNumber, Number secondNumber, Number.Sign sign)
        {
            Number result = new Number(0);
            switch (sign)
            {
                case Number.Sign.Plus:
                    result.Value = firstNumber.Value + secondNumber.Value;
                    break;
                case Number.Sign.Minus:
                    result.Value = firstNumber.Value - secondNumber.Value;
                    break;
                case Number.Sign.Multiply:
                    result.Value = firstNumber.Value * secondNumber.Value;
                    break;
                case Number.Sign.Divide:
                    result.Value = firstNumber.Value / secondNumber.Value;
                    break;
            }
            firstNumber.HasBeenUsed = true;
            secondNumber.HasBeenUsed = true;
            return result;
        }
    }
}