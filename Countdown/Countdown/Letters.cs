using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Countdown
{
    class Letters
    {
        public char vowel()
        {
            String vowels = "AEIOUY";
            return this.randomLetter(vowels);            
        }

        public char consonant()
        {
            String consonants = "BCDFGHJKLMNPQRSTVWXZ";
            return this.randomLetter(consonants);
        }

        private char randomLetter(String letters)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, letters.Length);

            char letter = letters[randomNumber];

            return letter;
        }
    }
}
