using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Countdown
{
    public class LongestWord : Phase
    {
        private Database database;
        private Letters letters = new Letters();

        public char[] lettersAvailable
        {
            get;
            private set;
        }

        public LongestWord()
        {
            
        }
    }
}