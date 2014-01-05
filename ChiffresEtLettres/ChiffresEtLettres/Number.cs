using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChiffresEtLettres
{
    public class Number
    {
        public enum Sign {Plus, Minus, Multiply, Divide};

        public int Value;
        public bool HasBeenUsed;

        public Number(int value)
        {
            this.Value = value;
            this.HasBeenUsed = false;
        }
    }
}