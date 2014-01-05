using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChiffresEtLettres
{
    class CompteEstBon : Phase
    {
        public int NumberToReach
        {
            get;
            private set;
        }
        public int[] NumbersAvailable
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
            this.NumberToReach = random.Next(100, 999);
            this.NumbersAvailable = new int[6];
            for (int i = 0; i < 6; i++)
            {
                this.NumbersAvailable[i] = random.Next(1, 14);
                switch (this.NumbersAvailable[i])
                {
                    case (11):
                        this.NumbersAvailable[i] = 25;
                        break;
                    case (12):
                        this.NumbersAvailable[i] = 50;
                        break;
                    case (13):
                        this.NumbersAvailable[i] = 75;
                        break;
                    case (14):
                        this.NumbersAvailable[i] = 100;
                        break;
                }
            }
        }
    }
}
