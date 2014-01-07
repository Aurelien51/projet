using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;
using System.Data;

namespace Countdown
{
    public class LongestWord : Phase
    {
        private Database database;
        private Letters letters;

        public char[] lettersAvailable
        {
            get;
            private set;
        }

        public LongestWord()
        {
            this.letters = new Letters();
            this.database = new Database();
            this.lettersAvailable = new char[10];

            Random random = new Random();

            //Examples
            int vowelNumber = random.Next(2, 10);

            for (int i = 0; i < vowelNumber; i++)
            {
                this.lettersAvailable[i] = this.letters.vowel();
            }

            for (int i = vowelNumber; i < 10; i++)
            {
                this.lettersAvailable[i] = this.letters.consonant();
            }

            this.lettersAvailable = this.lettersAvailable.OrderBy(x => random.Next()).ToArray();
            MessageBox.Show("Lettres: " + new String(this.lettersAvailable));

            String query = "SELECT word FROM dictionary WHERE word LIKE 'aboie%' ORDER BY LENGTH(word) DESC LIMIT 5";
            DataTable list = this.database.GetDataTable(query);

            foreach (DataRow row in list.Rows)
            {
                MessageBox.Show("Disponible: " + row["word"].ToString() + " / Taille: " + row["word"].ToString().Length);
            }
        }
    }
}