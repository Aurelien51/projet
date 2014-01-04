using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChiffresEtLettres
{
    class Lettre
    {
        public String Voyelle()
        {
         String maLettre="";
                //A, E, I, O, U, Y.
                Random random = new Random();
                int randomNumber = random.Next(1, 6);
                switch (randomNumber)
                {
                    case 1:
                        maLettre= "a";
                        break;
                    case 2:
                       maLettre = "e";
                        break;
                    case 3:
                        maLettre = "i";
                        break;
                    case 4:
                        maLettre = "o";
                        break;
                    case 5:
                        maLettre = "u";
                        break;
                    case 6:
                        maLettre = "y";
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            return maLettre;
        }
    }
}
