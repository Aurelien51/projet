using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Countdown
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
        public Number[] NumbersFound
        {
            get;
            set;
        }

        public int CurrentOperationRow = 0;
        public int CurrentOperationCol = 0;
        public Number[,] operationGrid;
        public Number.Sign[] signGrid;

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
            this.NumbersFound = new Number[5];
            this.operationGrid = new Number[5, 2];
            this.signGrid = new Number.Sign[5];
        }

        private Number Calculate(Number firstNumber, Number secondNumber, Number.Sign sign)
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

        public bool addNumber(Number number)
        {
            if (CurrentOperationCol > 0)
            {
                switch (signGrid[CurrentOperationRow])
                {
                    case Number.Sign.Plus:
                        this.operationGrid[CurrentOperationRow, CurrentOperationCol] = number;
                        number.HasBeenUsed = true;
                        NumbersFound[CurrentOperationRow] = new Number(this.operationGrid[CurrentOperationRow, 0].Value + this.operationGrid[CurrentOperationRow, 1].Value);
                        break;
                    case Number.Sign.Minus:
                        if (number.Value < this.operationGrid[CurrentOperationRow, 0].Value)
                        {
                            this.operationGrid[CurrentOperationRow, CurrentOperationCol] = number;
                            number.HasBeenUsed = true;
                            NumbersFound[CurrentOperationRow] = new Number(this.operationGrid[CurrentOperationRow, 0].Value - this.operationGrid[CurrentOperationRow, 1].Value);
                            break;
                        }
                        else
                        {
                            return false;
                        }
                    case Number.Sign.Multiply:
                        this.operationGrid[CurrentOperationRow, CurrentOperationCol] = number;
                        number.HasBeenUsed = true;
                        NumbersFound[CurrentOperationRow] = new Number(this.operationGrid[CurrentOperationRow, 0].Value * this.operationGrid[CurrentOperationRow, 1].Value);
                        break;
                    case Number.Sign.Divide:
                        if (this.operationGrid[CurrentOperationRow, 0].Value%number.Value == 0)
                        {
                            this.operationGrid[CurrentOperationRow, CurrentOperationCol] = number;
                            number.HasBeenUsed = true;
                            NumbersFound[CurrentOperationRow] = new Number(this.operationGrid[CurrentOperationRow, 0].Value / this.operationGrid[CurrentOperationRow, 1].Value);
                            break;
                        }
                        else
                        {
                            return false;
                        }
                }
                CurrentOperationRow++;
                CurrentOperationCol = 0;
            }
            else
            {
                this.operationGrid[CurrentOperationRow, CurrentOperationCol] = number;
                number.HasBeenUsed = true;
                CurrentOperationCol = 1;
            }
            return true;
        }

        public void addSign(Number.Sign sign)
        {
            this.signGrid[CurrentOperationRow] = sign;
        }

        internal void CancelNumber(Number number)
        {
            if (CurrentOperationCol == 0)
            {
                CurrentOperationRow--;
                CurrentOperationCol++;
                NumbersFound[CurrentOperationRow] = null;
            }
            else
            {
                CurrentOperationCol--;
            }
            if (this.operationGrid[CurrentOperationRow, CurrentOperationCol] == number)
            {
                this.operationGrid[CurrentOperationRow, CurrentOperationCol] = null;
                number.HasBeenUsed = false;
            }
        }

        internal void CancelSign(Number.Sign sign)
        {
            throw new NotImplementedException();
        }
    }
}